
#include "globals.h"
#include "utils.h"

void updateBullet() {
    if(!bullet.active) return;

    bullet.x += bullet.vx;
    bullet.y += bullet.vy;

    if(bullet.x < 0 || bullet.x > width || bullet.y < 0 || bullet.y > height) {
        bullet.active = false;
        bulletAvailable = true;
    }
}
