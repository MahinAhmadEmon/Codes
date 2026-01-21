#include "globals.h"
#include "utils.h"

void resetGame();
///---- BAZOOKA -----///
void bazooka(float x, float y) {
    glColor3ub(50, 50, 50);
    glBegin(GL_POLYGON);
        glVertex2f(x, y + 4);
        glVertex2f(x + 50, y + 4);
        glVertex2f(x + 50, y - 4);
        glVertex2f(x, y - 4);
    glEnd();

    glColor3ub(80, 80, 80);
    glBegin(GL_POLYGON);
        glVertex2f(x + 50, y + 5);
        glVertex2f(x + 60, y + 5);
        glVertex2f(x + 60, y - 5);
        glVertex2f(x + 50, y - 5);
    glEnd();

    glColor3ub(30, 30, 30);
    glBegin(GL_POLYGON);
        glVertex2f(x + 20, y - 4);
        glVertex2f(x + 26, y - 4);
        glVertex2f(x + 26, y - 16);
        glVertex2f(x + 20, y - 16);
    glEnd();
}

///------- Solider with bazzoka ------///
void soldier(double x, double y) {
    glColor3ub(255, 220, 177);
    glBegin(GL_POLYGON);
    for(int i = 0; i < 40; i++) {
        double theta = 2.0 * pi * i / 40;
        double dx = 5 * cos(theta);
        double dy = 5 * sin(theta);
        glVertex2d(x + 5 + dx, y + 65 + dy);
    }
    glEnd();

    glColor3ub(34, 85, 28);
    glBegin(GL_POLYGON);
    for(int i = 0; i < 40; i++) {
        double theta = 2.0 * pi * i / 40;
        double dx = 6 * cos(theta);
        double dy = 6 * sin(theta);
        glVertex2d(x + 5 + dx, y + 70 + dy);
    }
    glEnd();

    glColor3ub(60, 120, 60);
    glBegin(GL_POLYGON);
        glVertex2d(x, y + 40);
        glVertex2d(x + 15, y + 40);
        glVertex2d(x + 15, y + 65);
        glVertex2d(x, y + 65);
    glEnd();

    glColor3ub(90, 60, 30);
    glBegin(GL_LINES);
        glVertex2d(x, y + 50);
        glVertex2d(x + 15, y + 52);
    glEnd();

    glColor3ub(0, 0, 0);
    glBegin(GL_LINES);
        glVertex2d(x, y + 58);
        glVertex2d(x + 15, y + 60);
    glEnd();

    glColor3ub(255, 220, 177);
    glBegin(GL_POLYGON);
        glVertex2d(x + 10, y + 50);
        glVertex2d(x + 14, y + 50);
        glVertex2d(x + 14, y + 62);
        glVertex2d(x + 10, y + 62);
    glEnd();

    glColor3ub(40, 80, 40);
    glBegin(GL_POLYGON);
        glVertex2d(x + 2, y);
        glVertex2d(x + 8, y);
        glVertex2d(x + 8, y + 40);
        glVertex2d(x + 2, y + 40);
    glEnd();

    glColor3ub(30, 30, 30);
    glBegin(GL_POLYGON);
        glVertex2d(x + 2, y);
        glVertex2d(x + 10, y);
        glVertex2d(x + 10, y + 5);
        glVertex2d(x + 2, y + 5);
    glEnd();
}

/// ----- Solder -------///
void drawSoldier() {
    glPushMatrix();
    glTranslatef(soldierX, soldierY, 0);
    glScalef(soldierFacing, 1, 1);

    soldier(0, 0);

    glPushMatrix();
    glTranslatef(5, 60, 0);
    glRotatef(aimAngle * 180.0 / pi, 0, 0, 1);
    bazooka(-20, 0);
    glPopMatrix();

    glPopMatrix();
}

/// ----- Solder -------///
void updateSoldier() {

     if (soldierLife <= 0) {
        soldierLife = 0;
        gameOver = true;
        gameWon = false;
        return;   // ⛔ STOP soldier logic forever
    }

    if(soldierRespawning) {
        // Fall from sky
        soldierY -= 1.0f;  // falling speed per frame

        float groundY = getGroundY(soldierX);
        if(soldierY <= groundY) {
            soldierY = groundY;
            soldierRespawning = false; // landed
        }

        return;  // skip normal controls while falling
    }

    // =========================
    // TIME STEP
    // =========================
    static int lastTime = glutGet(GLUT_ELAPSED_TIME);
    int now = glutGet(GLUT_ELAPSED_TIME);

    float dt = (now - lastTime) / 1000.0f;
    lastTime = now;

    if(dt > 0.03f) dt = 0.03f;
    if(dt < 0.001f) dt = 0.001f;

    // =========================================================
    // ✅ returns highest "support surface" at x:
    // ground OR any wooden plank/roof you drew
    // =========================================================
    auto getSupportY = [&](float x, float currentY) -> float {
        float best = (float)getGroundY(x);

        // ----- small building wood: x 280..420 at y=160 -----
        if(x >= 280 && x <= 420) {
            float y = 160.0f;
            if(y <= currentY + 3.0f && y > best) best = y;
        }

        // ----- middle building wood: x 485..615 at y=280,220,160 -----
        if(x >= 485 && x <= 615) {
            float y1 = 280.0f;
            float y2 = 220.0f;
            float y3 = 160.0f;

            if(y1 <= currentY + 3.0f && y1 > best) best = y1;
            if(y2 <= currentY + 3.0f && y2 > best) best = y2;
            if(y3 <= currentY + 3.0f && y3 > best) best = y3;
        }

        // ----- right building wood: x 780..920 at y=220,160 -----
        if(x >= 780 && x <= 920) {
            float y1 = 220.0f;
            float y2 = 160.0f;

            if(y1 <= currentY + 3.0f && y1 > best) best = y1;
            if(y2 <= currentY + 3.0f && y2 > best) best = y2;
        }

        return best;
    };

    // =========================
    // MOVE LEFT/RIGHT (time-based)
    // =========================
    if(GetAsyncKeyState('A')) {
        soldierX -= soldierSpeed * dt;
        soldierFacing = -1;
    }
    if(GetAsyncKeyState('D')) {
        soldierX += soldierSpeed * dt;
        soldierFacing = 1;
    }

    // Clamp X
    soldierX = max(0.0f, min((float)width, soldierX));

    // =========================
    // JUMP START
    // =========================
    if(GetAsyncKeyState('W')) {
        if(!jumpKeyHeld && !isJumping) {
            isJumping = true;
            jumpVelocity = maxJumpVelocity;

            // base from the surface you're currently standing on
            jumpBaseY = getSupportY(soldierX, soldierY);
        }
        jumpKeyHeld = true;
    } else {
        jumpKeyHeld = false;
    }

    // JUMP UPDATE

    if(isJumping) {
        jumpOffset += jumpVelocity * dt;
        jumpVelocity -= gravity * dt;

        // max jump height cap
        float maxJumpHeight = 120.0f;
        if(jumpOffset > maxJumpHeight) {
            jumpOffset = maxJumpHeight;
            if(jumpVelocity > 0) jumpVelocity = 0;
        }

        float feetY = jumpBaseY + jumpOffset;

        // land on the best surface under you (only when falling)
        float supportY = getSupportY(soldierX, feetY);

        if(jumpVelocity <= 0 && feetY <= supportY) {
            jumpOffset = 0;
            isJumping = false;
            jumpVelocity = 0;
            jumpBaseY = supportY;
            soldierY = supportY;
        } else {
            soldierY = feetY;
        }
    } else {
        // =========================
        // NOT JUMPING: stick to surface
        // =========================
        float supportY = getSupportY(soldierX, soldierY);
        soldierY = supportY;
        jumpBaseY = supportY;
    }
}

void mouseMove(int mx, int my) {
    float worldY = height - my;

    float dx = mx - soldierX;
    float dy = worldY - (soldierY + 60);

    soldierFacing = (dx >= 0) ? 1 : -1;

    float localDx = abs(dx);
    float angle = atan2(dy, localDx);

    aimAngle = clamp(angle, -pi / 2, pi / 2);
}

void mouseClick(int button, int state, int mx, int my) {

    if (state != GLUT_DOWN) return;

    // ---- RESTART GAME ----
    if (currentScreen == SCREEN_GAME && (gameOver || gameWon)) {
        resetGame();
        glutPostRedisplay();
        return;
    }

        // ---- MENU FLOW ----
    if (button == GLUT_LEFT_BUTTON && state == GLUT_DOWN) {
        if (currentScreen == SCREEN_COVER)
            currentScreen = SCREEN_TITLE;
        else if (currentScreen == SCREEN_TITLE)
            currentScreen = SCREEN_INSTRUCTION;
        else if (currentScreen == SCREEN_INSTRUCTION)
            currentScreen = SCREEN_GAME;

        glutPostRedisplay();
    }



    if(!bulletAvailable){
        return;
    }

    if(button == GLUT_LEFT_BUTTON && state == GLUT_DOWN) {

        if(!bulletAvailable) return;

        float targetX = mx;
        float targetY = height - my;

        float shoulderX = soldierX + soldierFacing * 5;
        float shoulderY = soldierY + 60;

        float dirX = cos(aimAngle) * soldierFacing;
        float dirY = sin(aimAngle);

        float muzzleOffset = 60.0f;

        float startX = shoulderX + dirX * muzzleOffset;
        float startY = shoulderY + dirY * muzzleOffset;

        float dx = targetX - startX;
        float dy = targetY - startY;

        float len = sqrt(dx*dx + dy*dy);
        if(len == 0) len = 1;

        float speed = 0.5f;
        bullet.x = startX;
        bullet.y = startY;
        bullet.vx = (dx / len) * speed;
        bullet.vy = (dy / len) * speed;
        bullet.active = true;
        bulletAvailable = false;
    }
}

void updateShield() {
    if (!shieldActive) return;

    float now = glutGet(GLUT_ELAPSED_TIME);
    if (now - shieldStartTime >= SHIELD_DURATION) {
        shieldActive = false;
    }
}


void drawShield() {
    if (!shieldActive) return;

    glPushMatrix();
    glTranslatef(soldierX, soldierY + 35, 0);

    glColor4f(0.2f, 0.6f, 1.0f, 0.3f); // blue transparent
    drawCircle(0, 0, 45, 40);

    glPopMatrix();
}
