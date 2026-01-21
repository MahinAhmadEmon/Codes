
#include "globals.h"
#include "utils.h"

void explosion(float x, float y,
               float startRadius = 2.0f,
               float maxRadius   = 30.0f,
               float growthSpeed = 0.5f){
    static struct {
        float x, y;
        float radius;
        float maxRadius;
        float growthSpeed;
        int frame;
        bool active;
    } explosions[10];


    static bool initialized = false;
    if(!initialized) {
        for(int i = 0; i < 10; i++)
            explosions[i].active = false;
        initialized = true;
    }

    const int maxFrames = 60;

    // ---- SPAWN ONLY ----
    if(x >= 0 && y >= 0) {
        for(int i = 0; i < 10; i++) {
            if(!explosions[i].active) {
                explosions[i].x = x;
                explosions[i].y = y;
                explosions[i].radius = startRadius;
                explosions[i].maxRadius = maxRadius;
                explosions[i].growthSpeed = growthSpeed;
                explosions[i].frame = 0;
                explosions[i].active = true;
                break;
            }
        }
        return;
    }


    // ---- DRAW & UPDATE ONLY ----
    for(int i = 0; i < 10; i++) {
        if(!explosions[i].active) continue;

        glColor3ub(255, 140, 0);
        glBegin(GL_TRIANGLE_FAN);
        glVertex2f(explosions[i].x, explosions[i].y);

        for(int j = 0; j <= 20; j++) {
            float angle = 2.0f * pi * j / 20;
            glVertex2f(
                explosions[i].x + cos(angle) * explosions[i].radius,
                explosions[i].y + sin(angle) * explosions[i].radius
            );
        }
        glEnd();

        explosions[i].radius += explosions[i].growthSpeed;

        if(explosions[i].radius >= explosions[i].maxRadius){
            explosions[i].active = false;
        }

    }
}

void dropBomb(float dropX, float dropY) {

    // helper: returns building TOP at x, or -1 if no building there
    auto getBuildingTopY = [](double x) -> double {
        if(x >= 300 && x <= 400) return 160.0; // building 1 top
        if(x >= 500 && x <= 600) return 280.0; // building 2 top
        if(x >= 800 && x <= 900) return 220.0; // building 3 top
        return -1.0;
    };

    // ---- SPAWN ONLY ----
    if(dropX >= 0 && dropY >= 0) {
        for(int i = 0; i < MAX_BOMBS; i++) {
            if(!bombs[i].active) {
                bombs[i].x = dropX;
                bombs[i].y = dropY;
                bombs[i].vy = 0.0f;
                bombs[i].active = true;
                break;
            }
        }
    }

    // ---- UPDATE ONLY ----
    for(int i = 0; i < MAX_BOMBS; i++) {
        if(!bombs[i].active) continue;

        bombs[i].vy -= 0.001f;
        bombs[i].y += bombs[i].vy;

        double groundY = getGroundY(bombs[i].x);
        double buildingY = getBuildingTopY(bombs[i].x);

        double surfaceY = groundY;
        if(buildingY > surfaceY) surfaceY = buildingY;

        if(bombs[i].y <= surfaceY) {
            bombs[i].y = (float)surfaceY;
            bombs[i].active = false;

            // spawn explosion ONLY
            explosion(bombs[i].x, bombs[i].y);

            // DAMAGE SOLDIER IF CLOSE
            float sx = soldierX;
            float sy = soldierY + 35.0f; // center-ish

            float dx = bombs[i].x - sx;
            float dy = bombs[i].y - sy;


            // Only check if soldier is alive and not already respawning
            if (soldierLife > 0 && !soldierRespawning) {

                float soldierCenterX = soldierX;
                float soldierCenterY = soldierY + 35.0f; // adjust if your sprite is tall

                float explosionX = bombs[i].x;
                float explosionY = bombs[i].y; // use bomb impact Y, not groundY

                float damageRadius = 50.0f; // adjust if needed

                float dx = soldierCenterX - explosionX;
                float dy = soldierCenterY - explosionY;

                if(dx*dx + dy*dy <= damageRadius * damageRadius) {
                    // Soldier hit
                    soldierLife--;

                    if(soldierLife > 0) {
                        // Respawn soldier from sky
                        soldierX = rand() % (width-200) + 100;
                        soldierY = height + 80;
                        soldierRespawning = true;

                        isJumping = false;
                        jumpOffset = 0;
                        jumpVelocity = 0;
                    } else {
                        // Soldier dead
                        soldierRespawning = false;
                        // Optional: game over logic
                    }
                }
            }
        }
    }
}

void drawBombs() {
    for(int i = 0; i < MAX_BOMBS; i++) {
        if(!bombs[i].active) continue;

        glColor3ub(80, 0, 0);
        drawCircle(bombs[i].x, bombs[i].y, 4.0f, 20);
    }
}

