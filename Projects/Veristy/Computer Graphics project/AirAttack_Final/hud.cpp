#include "globals.h"

// heart icon
void drawHeart(float x, float y, float s, bool filled) {
    if(filled) glColor3ub(220, 0, 0);
    else       glColor3ub(80, 80, 80);

    // left circle
    glBegin(GL_TRIANGLE_FAN);
    glVertex2f(x - s*0.25f, y);
    for(int i=0;i<=20;i++){
        float a = 2.0f * pi * i / 20.0f;
        glVertex2f(x - s*0.25f + cos(a)*s*0.25f,
                   y + sin(a)*s*0.25f);
    }
    glEnd();

    // right circle
    glBegin(GL_TRIANGLE_FAN);
    glVertex2f(x + s*0.25f, y);
    for(int i=0;i<=20;i++){
        float a = 2.0f * pi * i / 20.0f;
        glVertex2f(x + s*0.25f + cos(a)*s*0.25f,
                   y + sin(a)*s*0.25f);
    }
    glEnd();

    // bottom triangle
    glBegin(GL_TRIANGLES);
        glVertex2f(x - s*0.5f, y);
        glVertex2f(x + s*0.5f, y);
        glVertex2f(x, y - s*0.75f);
    glEnd();
}

void drawHUD() {
    float size = 20.0f;    // icon size
    float gap  = 28.0f;    // space between hearts
    float margin = 25.0f;  // distance from screen edge

    // Top-right position
    float startX = width - margin - (soldierMaxLife - 1) * gap;
    float y = height - margin;

    for(int i = 0; i < soldierMaxLife; i++) {
        bool filled = (i < soldierLife);
        drawHeart(startX + i * gap, y, size, filled);
    }
}

