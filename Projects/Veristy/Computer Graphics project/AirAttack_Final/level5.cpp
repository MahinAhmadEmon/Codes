#include "globals.h"
#include "levels.h"
#include "utils.h"

void dropBomb(float dropX, float dropY);
void explosion(float x, float y,
               float startRadius = 2.0f,
               float maxRadius   = 30.0f,
               float growthSpeed = 0.5f);

bool atomExplosionActive = false;
float atomExplosionX = 0;
float atomExplosionY = 0;


// ---------- LEVEL 5 DATA ----------
Plane level5Planes[LEVEL5_PLANE_COUNT];
AtomBomb atomBomb;
bool atomBombActivated = false;


bool gameOver = false;
bool gameWon  = false;

// ---------- INIT ----------
void initLevel5() {
    shieldActive = true;
shieldStartTime = glutGet(GLUT_ELAPSED_TIME);

    // Planes
    planesRemaining = LEVEL5_PLANE_COUNT;
    helicoptersRemaining = MAX_HELICOPTERS;
    for (int i = 0; i < LEVEL5_PLANE_COUNT; i++) {
        level5Planes[i].x = PLANE_ORIGIN_X + i * 150;
        level5Planes[i].y = PLANE_ORIGIN_Y + 50;
        level5Planes[i].y = randRange(420, 600);
        level5Planes[i].speed = levelBaseSpeed[4] + randFloat(-0.01f, 0.03f);
        level5Planes[i].dir = (i % 2 == 0) ? 1 : -1;
        level5Planes[i].alive = true;
        level5Planes[i].bombingTimer = 0;
    }

    // Helicopters (reuse pattern)
    initHelicopters();


    // Atom Bomb (WAITING STATE)
    atomBomb.x = width / 2;
    atomBomb.y = height + 100;   // above screen
    atomBomb.vy = -0.3f;         // FALL SPEED
    atomBomb.alive = false;      // NOT ACTIVE YET
    atomBombActivated = false;
}
void updateLevel5Planes() {
    for (int i = 0; i < LEVEL5_PLANE_COUNT; i++) {
        if(!level5Planes[i].alive) continue;

        level5Planes[i].x += level5Planes[i].speed * level5Planes[i].dir;
        if(level5Planes[i].dir == 1 && level5Planes[i].x > width + 150) level5Planes[i].dir = -1;
        if(level5Planes[i].dir == -1 && level5Planes[i].x < -150) level5Planes[i].dir = 1;

        if(level5Planes[i].bombingTimer >= 0) {
            level5Planes[i].bombingTimer--;
            if(level5Planes[i].bombingTimer <= 0) {
                dropBomb(level5Planes[i].x, level5Planes[i].y);
                level5Planes[i].bombingTimer = randRange(100, 300);
            }
        }
    }
}


void updateAtomBomb() {
    if (!atomBomb.alive) return;
    atomBomb.y += atomBomb.vy;
   // cout<<atomBomb.y<<endl;
    // Stop at ground level (optional explosion trigger)
    if (atomBomb.y <= 120) {   // ground height approx
        //atomBomb.alive = false;
        atomExplosionX = atomBomb.x;
        atomExplosionY = 120;
        atomExplosionActive = true;
        /*if (atomExplosionActive) {
            explosion(atomExplosionX, atomExplosionY, 10.0f, 200.0f, 3.0f);
        }*/

        atomBomb.alive = false;
        gameOver = true;
    }
}

void drawAtomBomb() {
    if (!atomBomb.alive) return;

    glColor3ub(0, 0, 0);
    glBegin(GL_POLYGON);
        glVertex2f(atomBomb.x - 20, atomBomb.y);
        glVertex2f(atomBomb.x + 20, atomBomb.y);
        glVertex2f(atomBomb.x + 20, atomBomb.y - 40);
        glVertex2f(atomBomb.x - 20, atomBomb.y - 40);
    glEnd();

    glColor3ub(255, 0, 0);
    glBegin(GL_TRIANGLES);
        glVertex2f(atomBomb.x, atomBomb.y - 60);
        glVertex2f(atomBomb.x - 10, atomBomb.y - 40);
        glVertex2f(atomBomb.x + 10, atomBomb.y - 40);
    glEnd();
}

void checkAtomBombCollision() {
    if (!atomBomb.alive) return;

    if (abs(soldierX - atomBomb.x) < 30 &&
        abs(soldierY - atomBomb.y) < 60) {

        soldierLife = 0;
        gameOver = true;
    }
}


