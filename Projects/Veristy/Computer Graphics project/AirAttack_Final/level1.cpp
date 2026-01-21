
#include "globals.h"
#include "utils.h"
#include "levels.h"

void updateLevel1Planes() {
    for(int i = 0; i < LEVEL1_PLANE_COUNT; i++) {
        if(!level1Planes[i].alive) continue;
        level1Planes[i].x += level1Planes[i].speed * level1Planes[i].dir;
        if(level1Planes[i].dir == 1 && level1Planes[i].x > width + 150) level1Planes[i].dir = -1;
        if(level1Planes[i].dir == -1 && level1Planes[i].x < -150) level1Planes[i].dir = 1;
    }
}

void initLevel1() {
    planesRemaining = 0;
    planesRemaining = LEVEL1_PLANE_COUNT;

    for(int i = 0; i < LEVEL1_PLANE_COUNT; i++) {
        level1Planes[i].alive = true;
        level1Planes[i].dir = (i % 2 == 0) ? 1 : -1;
        level1Planes[i].y = randRange(450, 680);
        level1Planes[i].speed = levelBaseSpeed[0] + randFloat(-0.01f, 0.03f);

        if(level1Planes[i].dir == 1)
            level1Planes[i].x = -100 - i * 50;
        else
            level1Planes[i].x = width + i * 50;

        level1Planes[i].bombingTimer = -1;
    }
}
