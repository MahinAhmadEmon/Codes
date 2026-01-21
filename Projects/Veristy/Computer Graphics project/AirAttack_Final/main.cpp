
#include "globals.h"
#include "utils.h"
#include "levels.h"

// From other .cpp files
void init();
void sky();
void tree();
void ground();
void building();

HeartPickup heartPickups[MAX_HEART_PICKUPS];
bool heartsSpawned = false;

void drawSoldier();
void updateSoldier();
void mouseMove(int mx, int my);
void mouseClick(int button, int state, int mx, int my);

void updateBullet();

void explosion(float x, float y,float startRadius = 2.0f,float maxRadius = 30.0f,float growthSpeed = 0.5f);

void dropBomb(float dropX = -1.0f, float dropY = -1.0f); // defaults here
void drawBombs();

void renderPlanes(Plane planeArr[], int planeCount);
void checkLevelPlanesCollision(Plane planeArr[], int planeCount);
bool levelTransitionStarted = false;
int nextLevel = 0;

void updateGame();

///--------text---------///
void drawText(const string &text, float x, float y, void* font = GLUT_BITMAP_HELVETICA_18) {
    glColor3ub(255, 0, 0);
    glRasterPos2f(x, y);
    for(char c : text) glutBitmapCharacter(font, c);
}

// ===================== GLOBAL DEFINITIONS =====================
const float pi = 3.141592653589f;

const int width = 1280;
const int height = 720;

double groundArr[28][2] = {
    {0  ,0.0},{0  ,83.17},{50 ,93.38},{100,79.22},{200,79.53},{250,96.24},
    {300,103.68},{350,91.98},{400,83.08},{450,79.22},{500,77.93},{550,84.43},
    {600,99.19},{650,84.37},{700,94.66},{750,89.52},{800,84.75},{850,84.37},
    {900,95.95},{950,88.23},{1000,95.89},{1050,88.23},{1100,84.37},
    {1150,106.255},{1200,104.55},{1250,92.09},{1280,89.52},{1280,0}
};

float soldierX = 400;
float soldierY = 0;
float soldierSpeed = 100.0f;
int soldierFacing = 1;
bool soldierRespawning = false;
float soldierFallSpeed = 10.0f;
float aimAngle = 0.0f;

bool isJumping = false;
float jumpVelocity = 0.0f;
float gravity = 110.0f;
float maxJumpVelocity = 380.0f;
float jumpOffset = 0.0f;
float jumpBaseY = 0.0f;
bool jumpKeyHeld = false;
const int soldierMaxLife = 5;
int soldierLife = 2;
bool shieldActive = false;
float shieldStartTime = 0.0f;


Bullet bullet = {0,0,0,0,false};
bool bulletAvailable = true;

const float PLANE_ORIGIN_X = 300.0f;
const float PLANE_ORIGIN_Y = 300.0f;

float levelBaseSpeed[5] = {0.15f, 0.17f, 0.2f, 0.26f , 0.28f };

Plane level1Planes[LEVEL1_PLANE_COUNT];
Plane level2Planes[LEVEL2_PLANE_COUNT];
Plane level3Planes[LEVEL3_PLANE_COUNT];

int planesRemaining = 0;

Helicopter helicopters[MAX_HELICOPTERS];
HeliBullet heliBullets[MAX_HELI_BULLETS];



int currentLevel = 1;

Bomb bombs[MAX_BOMBS];

GameState gameState = SHOW_LEVEL_TEXT;
float levelStartTime = 0;
float levelTextDuration = 2000;
string currentLevelText = "LEVEL 1";

void drawHUD();
AppScreen currentScreen = SCREEN_COVER;

void resetGame() {

    gameOver = false;
    gameWon  = false;

    soldierLife = soldierMaxLife;
    soldierX = 400;
    soldierY = 0;

    currentLevel = 1;
    planesRemaining = 0;
    helicoptersRemaining = 0;
    soldierLife = 2;

    atomBomb.alive = false;
    atomBombActivated = false;

    initLevel1();

    currentLevelText = "LEVEL 1";
    levelStartTime = glutGet(GLUT_ELAPSED_TIME);
    gameState = SHOW_LEVEL_TEXT;
}

void drawText(float x, float y, const char* text)
{
    glRasterPos2f(x, y);
    for (int i = 0; text[i]; i++)
        glutBitmapCharacter(GLUT_BITMAP_TIMES_ROMAN_24, text[i]);
}

void coverPage()
{
    glColor3f(1,1,1);

    drawText(-0.6f, 0.8f, "AMERICAN INTERNATIONAL UNIVERSITY-BANGLADESH");

    drawText(-0.6f, 0.6f, "Project Title : Air Attack");
    drawText(-0.6f, 0.5f, "Course        : Computer Graphics");
    drawText(-0.6f, 0.4f, "Supervised By : Mahfujur Rahman");

    drawText(-0.6f, 0.2f, "Name");
    drawText(-0.1f, 0.2f, "ID");
    drawText( 0.3f, 0.2f, "Contribution");

    drawText(-0.6f, 0.1f, "Asif Akber");
    drawText(-0.1f, 0.1f, "23-52474-2");
    drawText( 0.3f, 0.1f, "20%");

    drawText(-0.6f, 0.0f, "MD. Shaharia Hossen Shihab");
    drawText(-0.1f, 0.0f, "23-52473-2");
    drawText( 0.3f, 0.0f, "20%");

    drawText(-0.6f, -0.1f, "Rizvi Rahman Sefat");
    drawText(-0.1f, -0.1f, "23-52399-2");
    drawText( 0.3f, -0.1f, "20%");

    drawText(-0.6f, -0.2f, "Mahin Ahmed Emon");
    drawText(-0.1f, -0.2f, "23-52656-2");
    drawText( 0.3f, -0.2f, "20%");

    drawText(-0.6f, -0.3f, "MD. Shahriyar Hasan");
    drawText(-0.1f, -0.3f, "23-52515-2");
    drawText( 0.3f, -0.3f, "20%");

    glBegin(GL_LINES);
        glVertex2f(-0.7f, 0.25f);
        glVertex2f( 0.7f, 0.25f);
        glVertex2f(-0.7f,-0.35f);
        glVertex2f( 0.7f,-0.35f);
    glEnd();

    drawText(-0.2f, -0.6f, "Click to continue");
}

void titleScreen()
{
    glColor3f(1,0,0);
    drawText(-0.2f, 0.3f, "Air Attack");

    glColor3f(1,1,1);
    drawText(-0.35f, 0.1f, "Fight for life, Go beyond");
    drawText(-0.25f,-0.2f, "Click to continue");
}

void instructionScreen()
{
    glColor3f(1,1,1);
    drawText(-0.2f, 0.5f, "Instructions");

    drawText(-0.6f, 0.3f, "A  : Move Left");
    drawText(-0.6f, 0.2f, "D  : Move Right");
    drawText(-0.6f, 0.1f, "W  : Jump");
    drawText(-0.6f, 0.0f, "Left Click : Shoot");

    drawText(-0.6f,-0.2f, "Buildings are your shelter");
    drawText(-0.3f,-0.4f, "Click to start the game");
}




// ===================== DISPLAY =====================
void displayGame() {

    if (gameOver || gameWon) {
        glClear(GL_COLOR_BUFFER_BIT);


        sky();
        tree();
        building();
        ground();

        if (gameOver){
            drawText("GAME OVER", width/2 - 60, height/2);
        }
        else{
            drawText("MISSION COMPLETE", width/2 - 100, height/2);
        }

        drawText("Click to Play Again", width/2 - 110, height/2 - 20);

        glFlush();
        return;
    }

    glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
    glClear(GL_COLOR_BUFFER_BIT);

    glViewport(0, 0, width, height);



    sky();
    tree();
    building();
    ground();

    updateSoldier();
    drawSoldier();
    drawShield();


    if(bullet.active) {
        glPushMatrix();
        glTranslatef(bullet.x, bullet.y, 0);

        float angle = atan2(bullet.vy, bullet.vx) * 180.0f/pi;
        glRotatef(angle, 0, 0, 1);

        glColor3ub(245, 172, 86);
        glBegin(GL_POLYGON);
            glVertex2f(-6,  2);
            glVertex2f( 8,  2);
            glVertex2f( 8, -2);
            glVertex2f(-6, -2);
        glEnd();

        glColor3ub(200, 0, 0);
        glBegin(GL_TRIANGLES);
            glVertex2f(8,  2);
            glVertex2f(12, 0);
            glVertex2f(8, -2);
        glEnd();

        glColor3ub(100, 0, 0);
        glBegin(GL_TRIANGLES);
            glVertex2f(-6, 2);
            glVertex2f(-10, 4);
            glVertex2f(-6, 0);

            glVertex2f(-6, -2);
            glVertex2f(-10, -4);
            glVertex2f(-6, 0);
        glEnd();

        glPopMatrix();
    }

    updateBullet();

    if(currentLevel == 1){
        updateLevel1Planes();
        renderPlanes(level1Planes, LEVEL1_PLANE_COUNT);
        checkLevelPlanesCollision(level1Planes, LEVEL1_PLANE_COUNT);
    }
    else if(currentLevel == 2){
        updateLevel2Planes();
        renderPlanes(level2Planes, LEVEL2_PLANE_COUNT);
        checkLevelPlanesCollision(level2Planes, LEVEL2_PLANE_COUNT);
    }
    else if(currentLevel == 3){
        updateLevel3Planes();
        renderPlanes(level3Planes, LEVEL3_PLANE_COUNT);
        checkLevelPlanesCollision(level3Planes, LEVEL3_PLANE_COUNT);

         drawHeartPickups();
        spawnHeartsLevel3();
        updateHeartPickups();
        drawHeartPickups();
        checkHeartPickupCollision();

    }

    checkLevelCompletion();

    dropBomb(-1, -1);
    drawBombs();
    explosion(-1, -1);

    if(gameState == SHOW_LEVEL_TEXT) {
        glPushMatrix();
        string text = currentLevelText;
        float textWidth = text.length() * 10;
        drawText(text, width/2 - textWidth/2, height/2);
        glPopMatrix();

        checkLevelCompletion();
        updateGame();
    }
    updateHelicopters();
    renderHelicopters();
    updateHeliBullets();
    checkBulletHelicopterCollision();

    if (currentLevel == 5) {

        updateLevel5Planes();
        renderPlanes(level5Planes, LEVEL5_PLANE_COUNT);
        checkLevelPlanesCollision(level5Planes, LEVEL5_PLANE_COUNT);


        updateHelicopters();
        renderHelicopters();

        // ---- ACTIVATE ATOM BOMB ----
        if (!atomBombActivated &&
            planesRemaining == 0 &&
            helicoptersRemaining == 0) {

            atomBomb.alive = true;
            atomBombActivated = true;
        }

        // ---- ATOM BOMB UPDATE ----
        if (atomBomb.alive) {
            updateAtomBomb();
            drawAtomBomb();
            checkAtomBombCollision();
        }
        if (atomExplosionActive) {
            explosion(atomBomb.x, atomBomb.y, 10.0f, 200.0f, 3.0f);
        }

    }
    updateShield();


    drawHUD();


    /*if (button == GLUT_RIGHT_BUTTON && state == GLUT_DOWN) {
        gameOver = false;
        gameWon = false;
        soldierLife = soldierMaxLife;
        currentLevel = 1;
        initLevel1();
        gameState = SHOW_LEVEL_TEXT;
    }
*/


    glFlush();
}

void display()
{
    glClear(GL_COLOR_BUFFER_BIT);

    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();

    // ---- PROJECTION SWITCH ----
    if (currentScreen == SCREEN_GAME)
        gluOrtho2D(0, width, 0, height);
    else
        gluOrtho2D(-1, 1, -1, 1);

    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();

    // -------- MENU SCREENS --------
    if (currentScreen == SCREEN_COVER) {
        coverPage();
    }
    else if (currentScreen == SCREEN_TITLE) {
        titleScreen();
    }
    else if (currentScreen == SCREEN_INSTRUCTION) {
        instructionScreen();
    }
    // -------- GAME --------
    else if (currentScreen == SCREEN_GAME) {
        displayGame();
    }

    glFlush();
}

// ===================== MAIN =====================
int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);

    int screenWidth  = glutGet(GLUT_SCREEN_WIDTH);
    int screenHeight = glutGet(GLUT_SCREEN_HEIGHT);

    int posX = (screenWidth  - width)  / 2;
    int posY = ((screenHeight - height) / 2) - 50;

    glutInitWindowSize(width, height);
    glutInitWindowPosition(posX, posY);
    glutCreateWindow("Air Attack");

    init();

    glutDisplayFunc(display);
    glutIdleFunc(display);
    glutPassiveMotionFunc(mouseMove);
    glutMotionFunc(mouseMove);
    glutMouseFunc(mouseClick);

    srand(time(0));
    initLevel1();
    levelStartTime = glutGet(GLUT_ELAPSED_TIME);
    gameState = SHOW_LEVEL_TEXT;

    for(int i = 0; i < MAX_BOMBS; i++){
        bombs[i].active = false;
    }

    glutMainLoop();
    return 0;
}
