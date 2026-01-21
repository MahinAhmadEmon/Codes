
#include "globals.h"
#include "utils.h"
#include "levels.h"

void dropBomb(float dropX, float dropY);

void updateLevel2Planes() {
    for(int i = 0; i < LEVEL2_PLANE_COUNT; i++) {
        if(!level2Planes[i].alive) continue;

        level2Planes[i].x += level2Planes[i].speed * level2Planes[i].dir;
        if(level2Planes[i].dir == 1 && level2Planes[i].x > width + 150) level2Planes[i].dir = -1;
        if(level2Planes[i].dir == -1 && level2Planes[i].x < -150) level2Planes[i].dir = 1;

        if(level2Planes[i].bombingTimer >= 0) {
            level2Planes[i].bombingTimer--;
            if(level2Planes[i].bombingTimer <= 0) {
                dropBomb(level2Planes[i].x, level2Planes[i].y);
                level2Planes[i].bombingTimer = randRange(2000, 2500);
            }
        }
    }
}

void initLevel2() {
    planesRemaining = 0;
    planesRemaining = LEVEL2_PLANE_COUNT;

    for(int i = 0; i < LEVEL2_PLANE_COUNT; i++) {
        level2Planes[i].alive = true;
        level2Planes[i].dir = (i % 2 == 0) ? 1 : -1;
        level2Planes[i].y = randRange(500, 700);
        level2Planes[i].speed = levelBaseSpeed[1] + randFloat(-0.01f, 0.03f);

        if(level2Planes[i].dir == 1)
            level2Planes[i].x = -100 - i * 40;
        else
            level2Planes[i].x = width + i * 40;

        level2Planes[i].bombingTimer = randRange(200, 600);
    }
}
