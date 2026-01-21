#include "globals.h"
#include "utils.h"

void drawHeart(float x, float y, float s, bool filled);


void updateHeartPickups() {
    for (int i = 0; i < MAX_HEART_PICKUPS; i++) {
        if (!heartPickups[i].active) continue;

        heartPickups[i].y += heartPickups[i].vy;

        if (heartPickups[i].y < 80) {
            heartPickups[i].active = false;
        }
    }
}

void drawHeartPickups() {
    for (int i = 0; i < MAX_HEART_PICKUPS; i++) {
        if (!heartPickups[i].active) continue;

        drawHeart(
            heartPickups[i].x,
            heartPickups[i].y,
            18.0f,
            true
        );
    }
}

void checkHeartPickupCollision() {
    for (int i = 0; i < MAX_HEART_PICKUPS; i++) {
        if (!heartPickups[i].active) continue;

        if (abs(soldierX - heartPickups[i].x) < 25 &&
            abs(soldierY - heartPickups[i].y) < 40) {

            heartPickups[i].active = false;

            if (soldierLife < soldierMaxLife) {
                soldierLife++;
            }
        }
    }
}

void spawnHeartsLevel3() {
    if (heartsSpawned) return;

    for (int i = 0; i < MAX_HEART_PICKUPS; i++) {
        heartPickups[i].x = randFloat(100, width - 100);
        heartPickups[i].y = height + i * 200;   // staggered fall
        heartPickups[i].vy = -0.1f;              // falling speed
        heartPickups[i].active = true;
    }

    heartsSpawned = true;
}

