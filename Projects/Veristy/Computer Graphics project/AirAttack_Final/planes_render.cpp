
#include "globals.h"
#include "utils.h"

void explosion(float x, float y,
               float startRadius = 2.0f,
               float maxRadius   = 30.0f,
               float growthSpeed = 0.5f);

// ----- Check if soldier is hidden inside a building -----
inline bool isSoldierHidden() {
    for (int i = 0; i < NUM_BUILDINGS; i++) {
        if (soldierX >= buildings[i].xStart && soldierX <= buildings[i].xEnd &&
            soldierY >= buildings[i].yBottom && soldierY <= buildings[i].yTop) {
            return true; // soldier is inside a building
        }
    }
    return false;
}

void drawPlane() {
    glColor3ub(166, 166, 166);
    glBegin(GL_POLYGON);
        glVertex2d(224.67,319.85);
        glVertex2d(225.12,290.41);
        glVertex2d(240,290);
        glVertex2d(232.78,319.32);
        glVertex2d(224.67,319.85);
    glEnd();

    glBegin(GL_POLYGON);
        glVertex2d(235.74,307.49);
        glVertex2d(328.74,317.7);
        glVertex2d(342.7,309.71);
        glVertex2d(362.11,309.34);
        glVertex2d(364,303.08);
        glVertex2d(357.1,295.32);
        glVertex2d(345,290.68);
        glVertex2d(327.9,288.36);
        glVertex2d(239.288,293.21);
        glVertex2d(235.74,307.49);
    glEnd();

    glColor3ub(77, 77, 77);
    glBegin(GL_POLYGON);
        glVertex2d(280.12,295.39);
        glVertex2d(299.55,298);
        glVertex2d(304,295.73);
        glVertex2d(304.21,291.64);
        glVertex2d(300.12,288.55);
        glVertex2d(280,290);
        glVertex2d(280.12,295.39);
    glEnd();

    glColor3ub(0, 0, 0);
    glBegin(GL_POLYGON);
        glVertex2d(304.88,315.08);
        glVertex2d(328.74,317.7);
        glVertex2d(342.7,309.71);
        glVertex2d(306.27,306.58);
        glVertex2d(304.88,315.08);
    glEnd();

    glBegin(GL_POLYGON);
        glVertex2d(243.68,304.03);
        glVertex2d(255.84,305.7);
        glVertex2d(257.17,298.03);
        glVertex2d(244.87,298);
        glVertex2d(243.68,304.03);
    glEnd();

    glBegin(GL_LINES);
        glVertex2d(303.87,302.66);
        glVertex2d(302.66,302.67);
    glEnd();

    glBegin(GL_LINES);
        glVertex2d(364,318.48);
        glVertex2d(364,290.48);
    glEnd();

    glColor3ub(230, 138, 0);
    glBegin(GL_POLYGON);
        glVertex2d(263.68,310.56);
        glVertex2d(269.03,311.15);
        glVertex2d(269.7,291.54);
        glVertex2d(264.145,291.84);
        glVertex2d(263.68,310.56);
    glEnd();
}

void drawHelicopterType1() {
    // Blue body parts
    glColor3ub(0, 68, 204);
    glBegin(GL_POLYGON);
        glVertex2d(91.78, 100);    // scaled from 913.15,599.36
        glVertex2d(33.64, 86.96);  // 876.21,582.88
        glVertex2d(100, 88.17);    // 949.27,584.52
        glVertex2d(91.78, 100);
    glEnd();
    glBegin(GL_POLYGON);
        glVertex2d(36.4, 74.63);   // 877.03,564
        glVertex2d(18.95, 66.3);   // 858.97,554.15
        glVertex2d(105.27, 67.68); // 963.44,557
        glVertex2d(99.12, 76.64);  // 952.79,566.67
        glVertex2d(36.4, 74.63);
    glEnd();

    // Green body parts
    glColor3ub(0, 128, 43);
    glBegin(GL_POLYGON);
        glVertex2d(33.64, 86.96);
        glVertex2d(36.4, 74.63);
        glVertex2d(99.12, 76.64);
        glVertex2d(100, 88.17);
        glVertex2d(33.64, 86.96);
    glEnd();
    glBegin(GL_POLYGON);
        glVertex2d(18.95, 66.3);
        glVertex2d(0, 59.17);      // 840.1,546.72
        glVertex2d(18.42, 49.17);  // 857.33,537.73
        glVertex2d(102.63, 49.15);// 961.58,537.7
        glVertex2d(162.06, 61.48);// 1021.51,551.18
        glVertex2d(177.3, 75.15);  // 1037.5,567.15
        glVertex2d(105.27, 67.68);// 963.44,557
        glVertex2d(18.95, 66.3);
    glEnd();

    // Black details
    glColor3ub(0, 0, 0);
    glBegin(GL_POLYGON);
        glVertex2d(33.64, 86.96);
        glVertex2d(36.4, 74.63);
        glVertex2d(18.95, 66.3);
        glVertex2d(35.66, 66.94);  // 885.77,554.88
        glVertex2d(44.27, 76.76);  // 896.33,565.58
        glVertex2d(42.35, 86.1);   // 894.13,582.7
        glVertex2d(33.64, 86.96);
    glEnd();

    // Rotors / lines
    glLineWidth(8);
    glBegin(GL_LINES);
        glVertex2d(37.65, 100); glVertex2d(100, 100);
        glVertex2d(38.32, 61.9); glVertex2d(39.2, 0);
        glVertex2d(95.3, 63.41); glVertex2d(96, 0);
        glVertex2d(0, 0.95); glVertex2d(106.9, 0);
        glVertex2d(162, 73.17); glVertex2d(200, 44.26);
        glVertex2d(164.09, 41.95); glVertex2d(176.6, 100);
    glEnd();
}


void drawHelicopterType2()
{
    glPushMatrix();

    glTranslatef(10, 20, 0);
    glScalef(0.9f, 0.9f, 1.0f);

    /* ================= MAIN BODY ================= */
    glColor3ub(0, 128, 43);
    glBegin(GL_POLYGON);
        glVertex2i(-18,42);
        glVertex2i(-22,36);
        glVertex2i(-30,32);
        glVertex2i(-55,32);
        glVertex2i(-65,36);
        glVertex2i(-66,44);
        glVertex2i(-60,52);
        glVertex2i(-45,56);
        glVertex2i(-30,56);
        glVertex2i(-22,50);
    glEnd();

    /* ================= COCKPIT ================= */
    glColor3ub(120, 200, 220);
    glBegin(GL_POLYGON);
        glVertex2i(-20,42);
        glVertex2i(-28,54);
        glVertex2i(-46,54);
        glVertex2i(-52,42);
    glEnd();

    /* ================= TAIL BOOM ================= */
    glColor3ub(0, 100, 35);
    glBegin(GL_POLYGON);
        glVertex2i(-66,44);
        glVertex2i(-90,46);
        glVertex2i(-92,44);
        glVertex2i(-66,38);
    glEnd();

    /* ================= TAIL FIN ================= */
    glBegin(GL_POLYGON);
        glVertex2i(-88,46);
        glVertex2i(-92,60);
        glVertex2i(-96,46);
        glVertex2i(-92,44);
    glEnd();

    /* ================= LANDING SKIDS ================= */
    glColor3ub(30,30,30);
    glBegin(GL_QUADS);
        glVertex2i(-25,28);
        glVertex2i(-60,28);
        glVertex2i(-58,26);
        glVertex2i(-27,26);
    glEnd();

    /* ================= SKID SUPPORTS ================= */
    glBegin(GL_QUADS);
        glVertex2i(-30,28);
        glVertex2i(-32,42);
        glVertex2i(-34,42);
        glVertex2i(-34,28);
    glEnd();

    glBegin(GL_QUADS);
        glVertex2i(-50,28);
        glVertex2i(-52,42);
        glVertex2i(-54,42);
        glVertex2i(-54,28);
    glEnd();

    /* ================= ROTOR MAST ================= */
    glBegin(GL_QUADS);
        glVertex2i(-42,56);
        glVertex2i(-44,56);
        glVertex2i(-44,62);
        glVertex2i(-42,62);
    glEnd();

    /* ================= MAIN ROTOR ================= */
    glBegin(GL_QUADS);
        glVertex2i(-10,62);
        glVertex2i(-80,62);
        glVertex2i(-80,64);
        glVertex2i(-10,64);
    glEnd();

    glPopMatrix();
}




void renderPlanes(Plane planeArr[], int planeCount) {
    for(int i = 0; i < planeCount; i++) {
        if(!planeArr[i].alive) continue;

        glPushMatrix();
        glTranslatef(
            planeArr[i].x - PLANE_ORIGIN_X,
            planeArr[i].y - PLANE_ORIGIN_Y,
            0
        );

        if(planeArr[i].dir == -1) {
            glTranslatef(2 * PLANE_ORIGIN_X, 0, 0);
            glScalef(-1, 1, 1);
        }

        drawPlane();
        glPopMatrix();
    }
}

void renderHelicopters() {
    for(int i = 0; i < MAX_HELICOPTERS; i++) {
        if(!helicopters[i].alive) continue;

        glPushMatrix();
        glTranslatef(helicopters[i].x, helicopters[i].y, 0);

        if(helicopters[i].dir == -1)
            glScalef(-1, 1, 1);

       /* if(i % 2 == 0)
            drawHelicopterType1();
        else*/
            drawHelicopterType2();

        glPopMatrix();
    }
}



void checkBulletPlaneCollision(Plane planeArr[], int planeCount, int &planesRemaining){
    if(!bullet.active) return;

    for(int i = 0; i < planeCount; i++)
    {
        if(!planeArr[i].alive) continue;

        float planeX = planeArr[i].x + (224.0f - PLANE_ORIGIN_X);
        float planeY = planeArr[i].y + (290.0f - PLANE_ORIGIN_Y);

        float planeW = 140.0f;
        float planeH = 30.0f;

        if(bullet.x > planeX && bullet.x < planeX + planeW &&
           bullet.y > planeY && bullet.y < planeY + planeH)
        {
            planeArr[i].alive = false;
            planesRemaining--;
            cout<<"plane remaining :" <<planesRemaining<<endl;

            explosion(bullet.x, bullet.y,4.0f,60.0f,0.4f);

            bullet.active = false;
            bulletAvailable = true;
            break;
        }
    }

    if (bullet.active && atomBomb.alive) {
    if (abs(bullet.x - atomBomb.x) < 25 &&
        abs(bullet.y - atomBomb.y) < 40) {

        atomBomb.alive = false;
        bullet.active = false;
        explosion(atomBomb.x, atomBomb.y);
    }
}

}

void updateHelicopters() {
    float minY = 350.0f;
    const float maxY = 500.0f;
    const int fireCooldown = 500; // frames between shots

    for(int i = 0; i < MAX_HELICOPTERS; i++) {
        if(!helicopters[i].alive) continue;

        // Horizontal movement
        helicopters[i].x += helicopters[i].speed * helicopters[i].dir;

        // Reverse direction when leaving screen horizontally
        if(helicopters[i].x > width + 100) helicopters[i].dir = -1;
        if(helicopters[i].x < -100) helicopters[i].dir = 1;

        // Vertical position stay within region
        if(helicopters[i].y < minY) helicopters[i].y = minY;
        if(helicopters[i].y > maxY) helicopters[i].y = maxY;

        // Fire bullets
        helicopters[i].fireTimer--;
        if(helicopters[i].fireTimer <= 0) {
            bool canFire = false;
            for(int b = 0; b < MAX_HELI_BULLETS; b++) {
                if(!heliBullets[b].active) {
                    canFire = true;
                    break;
                }
            }

            if(canFire) {
                fireHelicopterBullet(helicopters[i].x, helicopters[i].y);
                helicopters[i].fireTimer = fireCooldown;
            }
        }
    }
}

void updateHeliBullets() {
    for(int i = 0; i < MAX_HELI_BULLETS; i++) {
        if(!heliBullets[i].active) continue;

        // Move bullet
        heliBullets[i].x += heliBullets[i].vx;
        heliBullets[i].y += heliBullets[i].vy;

        // Draw bullet
        glColor3ub(255,0,0);
        drawCircle(heliBullets[i].x, heliBullets[i].y, 4, 10);

        // Check ground collision
        float groundY = getGroundY(heliBullets[i].x);
        if(heliBullets[i].y <= groundY) {
            explosion(heliBullets[i].x, groundY);
            heliBullets[i].active = false;
            continue; // skip soldier/building collision this frame
        }

        // Check building collision
        for(int b = 0; b < NUM_BUILDINGS; b++) {
            if(heliBullets[i].x >= buildings[b].xStart && heliBullets[i].x <= buildings[b].xEnd &&
               heliBullets[i].y >= buildings[b].yBottom && heliBullets[i].y <= buildings[b].yTop) {
                explosion(heliBullets[i].x, heliBullets[i].y);
                heliBullets[i].active = false;
                break; // bullet destroyed by building
            }
        }

        if(!heliBullets[i].active) continue; // skip soldier check if bullet destroyed

        // Check soldier hit (only if soldier is NOT hidden inside building)
        if(!isSoldierHidden()) {
            float dx = soldierX - heliBullets[i].x;
            float dy = soldierY - heliBullets[i].y;
            float dist = sqrt(dx*dx + dy*dy);

            if(dist < 10.0f) { // hit radius
                soldierLife--;
                heliBullets[i].active = false;
                explosion(heliBullets[i].x, heliBullets[i].y);
            }
        }
    }
}


void fireHelicopterBullet(float hx, float hy) {
    for(int i = 0; i < MAX_HELI_BULLETS; i++) {
        if(!heliBullets[i].active) {

            heliBullets[i].x = hx;
            heliBullets[i].y = hy;

            // Soldier initial position (example)
            float targetX = soldierX;
            float targetY = soldierY;


            float dx = targetX - hx;
            float dy = targetY - hy;

            float len = sqrt(dx*dx + dy*dy);
            if(len == 0) len = 1;

            // normalize direction
            dx /= len;
            dy /= len;

            float speed = 0.5f;

            heliBullets[i].vx = dx * speed;
            heliBullets[i].vy = dy * speed;

            heliBullets[i].active = true;
            break;
        }
    }
}


void checkBulletHelicopterCollision() {
    if(!bullet.active) return;

    for(int i = 0; i < MAX_HELICOPTERS; i++) {
        if(!helicopters[i].alive) continue;

        float heliLeft   = helicopters[i].x - 96; // leftmost vertex
        float heliRight  = helicopters[i].x - 10; // rightmost vertex
        float heliBottom = helicopters[i].y + 26; // bottom vertex
        float heliTop    = helicopters[i].y + 64; // top vertex

        float padding = 2.0f;
        if (bullet.x >= heliLeft - padding && bullet.x <= heliRight + padding &&
            bullet.y >= heliBottom - padding && bullet.y <= heliTop + padding){
            helicopters[i].alive = false;
            explosion(helicopters[i].x, helicopters[i].y);

            helicoptersRemaining--;
            cout<<"Heli remaining : "<<helicoptersRemaining<<endl;
            bullet.active = false;
            bulletAvailable = true;
            break;
        }
    }
}



void checkLevelPlanesCollision(Plane planeArr[], int planeCount) {
    checkBulletPlaneCollision(planeArr, planeCount, planesRemaining);
}
