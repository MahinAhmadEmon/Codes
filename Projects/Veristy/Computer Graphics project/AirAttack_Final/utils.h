
#pragma once
#include "globals.h"

inline float clamp(float v, float lo, float hi) {
    return max(lo, min(v, hi));
}


inline float randFloat(float minVal, float maxVal) {
    return minVal + (float(rand()) / float(RAND_MAX)) * (maxVal - minVal);
}

inline int randRange(int a, int b) {
    return a + rand() % (b - a + 1);
}

// --- ground for soldier ---
inline double getGroundY(double x) {
    if(x <= 0) return  groundArr[1][1];
    if(x >= 1280) return groundArr[26][1];

    for(int i=0; i<27; i++){
        double x1 = groundArr[i][0];
        double x2 = groundArr[i+1][0];
        if(x >= x1 && x <= x2){
            double t = (x - x1)/(x2 - x1);
            return groundArr[i][1] * (1-t) + groundArr[i+1][1]*t;
        }
    }
    return 0;
}

// Utility function to draw a circle
inline void drawCircle(float cx, float cy, float r, int num_segments) {
    glBegin(GL_TRIANGLE_FAN);
    for(int i = 0; i < num_segments; i++) {
        float theta = 2.0f * pi * float(i) / float(num_segments);
        float dx = r * cosf(theta);
        float dy = r * sinf(theta);
        glVertex2f(cx + dx, cy + dy);
    }
    glEnd();
}
void spawnHeartsLevel3();
void updateHeartPickups();
void drawHeartPickups();
void checkHeartPickupCollision();

// ---- SHIELD ----
void drawShield();
void updateShield();

