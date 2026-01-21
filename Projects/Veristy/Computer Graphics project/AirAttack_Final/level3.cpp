
#include "globals.h"
#include "utils.h"
#include "levels.h"

void dropBomb(float dropX, float dropY);

void updateLevel3Planes() {
    for(int i = 0; i < LEVEL3_PLANE_COUNT; i++) {
        if(!level3Planes[i].alive) continue;

        level3Planes[i].x += level3Planes[i].speed * level3Planes[i].dir;
        if(level3Planes[i].dir == 1 && level3Planes[i].x > width + 150) level3Planes[i].dir = -1;
        if(level3Planes[i].dir == -1 && level3Planes[i].x < -150) level3Planes[i].dir = 1;

        if(level3Planes[i].bombingTimer >= 0) {
            level3Planes[i].bombingTimer--;
            if(level3Planes[i].bombingTimer <= 0) {
                dropBomb(level3Planes[i].x, level3Planes[i].y);
                level3Planes[i].bombingTimer = randRange(100, 300);
            }
        }
    }
}

void initLevel3() {
    heartsSpawned = false;

    for (int i = 0; i < MAX_HEART_PICKUPS; i++) {
        heartPickups[i].active = false;
    }

    planesRemaining = 0;
    planesRemaining = LEVEL3_PLANE_COUNT;

    for(int i = 0; i < LEVEL3_PLANE_COUNT; i++) {
        level3Planes[i].alive = true;
        level3Planes[i].dir = (i % 2 == 0) ? 1 : -1;
        level3Planes[i].y = randRange(420, 600);
        level3Planes[i].speed = levelBaseSpeed[2] + randFloat(-0.01f, 0.03f);

        if(level3Planes[i].dir == 1)
            level3Planes[i].x = -100 - i * 20;
        else
            level3Planes[i].x = width + i * 20;

        level3Planes[i].bombingTimer = randRange(50, 150);
    }
    for (int i = 0; i < MAX_HEART_PICKUPS; i++) {
        heartPickups[i].x = 300 + i * 350;
        heartPickups[i].y = height + i * 50;
        heartPickups[i].vy = -0.2f;   // slow fall
        heartPickups[i].active = true;
    }
}
