
#include "globals.h"
#include "utils.h"

void init() {
    glMatrixMode(GL_PROJECTION);
    glLoadIdentity();
    gluOrtho2D(0.0, width, 0.0, height);
}

///------GROUND------///
void ground() {
    glColor3f(0.0f, 0.6f, 0.0f);
    glBegin(GL_POLYGON);
        for(int x=0;x<28;x++){
            glVertex2d(groundArr[x][0],groundArr[x][1]+5);
        }
    glEnd();

    glColor3ub(74, 54, 30);
    glBegin(GL_POLYGON);
        for(int x=0;x<28;x++){
            glVertex2d(groundArr[x][0],groundArr[x][1]);
        }
    glEnd();
}

///------Tree-------///
void tree(){
    glColor3ub(0, 65, 0);
        glBegin(GL_POLYGON);
            glVertex2d(710,190);
            glVertex2d(688,161);
            glVertex2d(702,163);
            glVertex2d(718,162);
            glVertex2d(732,160);
            glVertex2d(710,190);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(702,163);
            glVertex2d(683,141);
            glVertex2d(700,145);
            glVertex2d(720,145);
            glVertex2d(720,146);
            glVertex2d(735,141);
            glVertex2d(718,162);
            glVertex2d(702,163);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(700,145);
            glVertex2d(677,119);
            glVertex2d(699,123);
            glVertex2d(720,123);
            glVertex2d(739,118);
            glVertex2d(720,145);
            glVertex2d(700,145);
        glEnd();

        glBegin(GL_POLYGON);
            glVertex2d(149,211);
            glVertex2d(117,180);
            glVertex2d(159,180);
            glVertex2d(179,181);
            glVertex2d(149,211);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(139,180);
            glVertex2d(100,150);
            glVertex2d(136,149);
            glVertex2d(162,149);
            glVertex2d(192,149);
            glVertex2d(159,180);
            glVertex2d(139,180);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(136,149);
            glVertex2d(89,115);
            glVertex2d(136,115);
            glVertex2d(160,116);
            glVertex2d(205,114);
            glVertex2d(162,149);
            glVertex2d(136,149);
        glEnd();

        glColor3ub(102, 51, 0);
        glBegin(GL_POLYGON);
            glVertex2d(699,123);
            glVertex2d(700,94);
            glVertex2d(720,98);
            glVertex2d(720,123);
            glVertex2d(699,123);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(136,115);
            glVertex2d(131,85);
            glVertex2d(162,77);
            glVertex2d(160,116);
            glVertex2d(136,115);
        glEnd();
}

///----SKY----///
void sky(){
    double mnt1[28][2]={
        {0  ,0},{0  ,314},{50 ,332},{100,364},{200,398},{250,426},{300,415},
        {350,396},{400,373},{450,360},{500,352},{550,358},{600,378},{650,377},
        {700,364},{750,352},{800,346},{850,331},{900,321},{950,329},{1000,355},
        {1050,374},{1100,383},{1150,375},{1200,362},{1250,339},{1280,320},{1280,0}
    };

    double mnt2[28][2]={
        {0  ,0},{0  ,345},{50 ,353},{100,346},{200,358},{250,379},{300,377},
        {350,388},{400,412},{450,403},{500,387},{550,373},{600,350},{650,363},
        {700,373},{750,377},{800,367},{850,358},{900,336},{950,326},{1000,342},
        {1050,346},{1100,346},{1150,346},{1200,355},{1250,375},{1280,376},{1280,0}
    };

    glBegin(GL_QUADS);
        glColor3ub(216, 224, 238);
        glVertex2i(0, 720);
        glVertex2i(width, 720);

        glColor3ub(196, 209, 235);
        glVertex2i(width, 680);
        glVertex2i(0, 680);

        glColor3ub(196, 209, 235);
        glVertex2i(0, 680);
        glVertex2i(width, 680);

        glColor3ub(92, 144, 184);
        glVertex2i(width, 250);
        glVertex2i(0, 250);
    glEnd();

    glColor3ub(169, 206, 235);
    glBegin(GL_POLYGON);
        for(int x=0;x<28;x++){
            glVertex2d(mnt2[x][0],mnt2[x][1]-10);
        }
    glEnd();

    glColor3ub(64, 93, 115);
    glBegin(GL_POLYGON);
        for(int x=0;x<28;x++){
            glVertex2d(mnt1[x][0],mnt1[x][1]-10);
        }
    glEnd();
}

///-----Building-----///
void building(){
    glColor3ub(198, 140, 83);
        glBegin(GL_POLYGON);
            glVertex2d(300, 160);
            glVertex2d(400, 160);
            glVertex2d(400, 80);
            glVertex2d(300, 80);
            glVertex2d(300, 160);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(500, 280);
            glVertex2d(600, 280);
            glVertex2d(600, 80);
            glVertex2d(500, 80);
            glVertex2d(500, 280);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(800, 220);
            glVertex2d(900, 220);
            glVertex2d(900, 80);
            glVertex2d(800, 80);
            glVertex2d(800, 220);
        glEnd();

    glColor3ub(96, 64, 32);
    glLineWidth(8);

    glBegin(GL_LINES);
        glVertex2f(485, 280); glVertex2f(615, 280);
        glVertex2f(485, 220); glVertex2f(615, 220);
        glVertex2f(485, 160); glVertex2f(615, 160);
        glVertex2f(280, 160); glVertex2f(420, 160);
        glVertex2f(780, 220); glVertex2f(920, 220);
        glVertex2f(780, 160); glVertex2f(920, 160);
    glEnd();


    glColor3ub(0, 0, 0);
        glBegin(GL_POLYGON);
            glVertex2d(320, 140);
            glVertex2d(340, 140);
            glVertex2d(340, 120);
            glVertex2d(320, 120);
            glVertex2d(320, 140);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(360, 140);
            glVertex2d(380, 140);
            glVertex2d(380, 120);
            glVertex2d(360, 120);
            glVertex2d(360, 140);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(520, 260);
            glVertex2d(540, 260);
            glVertex2d(540, 240);
            glVertex2d(520, 240);
            glVertex2d(520, 260);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(560, 260);
            glVertex2d(580, 260);
            glVertex2d(580, 240);
            glVertex2d(560, 240);
            glVertex2d(560, 260);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(520, 200);
            glVertex2d(540, 200);
            glVertex2d(540, 180);
            glVertex2d(520, 180);
            glVertex2d(520, 200);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(560, 200);
            glVertex2d(580, 200);
            glVertex2d(580, 180);
            glVertex2d(560, 180);
            glVertex2d(560, 200);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(520, 140);
            glVertex2d(540, 140);
            glVertex2d(540, 120);
            glVertex2d(520, 120);
            glVertex2d(520, 140);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(560, 140);
            glVertex2d(580, 140);
            glVertex2d(580, 120);
            glVertex2d(560, 120);
            glVertex2d(560, 140);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(820, 200);
            glVertex2d(840, 200);
            glVertex2d(840, 180);
            glVertex2d(820, 180);
            glVertex2d(820, 200);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(860, 200);
            glVertex2d(880, 200);
            glVertex2d(880, 180);
            glVertex2d(860, 180);
            glVertex2d(860, 200);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(820, 140);
            glVertex2d(840, 140);
            glVertex2d(840, 120);
            glVertex2d(820, 120);
            glVertex2d(820, 140);
        glEnd();
        glBegin(GL_POLYGON);
            glVertex2d(860, 140);
            glVertex2d(880, 140);
            glVertex2d(880, 120);
            glVertex2d(860, 120);
            glVertex2d(860, 140);
        glEnd();

}
