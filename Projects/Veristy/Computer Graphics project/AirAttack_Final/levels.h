
#pragma once
#include "globals.h"

// Level init/update
void initLevel1();
void updateLevel1Planes();

void initLevel2();
void updateLevel2Planes();

void initLevel3();
void updateLevel3Planes();

void initHelicopters();

void initLevel5();
void updateLevel5Planes();

//void updatePlanes(Plane planeArr[], int planeCount);


// Completion manager
void checkLevelCompletion();
