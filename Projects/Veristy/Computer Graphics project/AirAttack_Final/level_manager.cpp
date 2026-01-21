#include "globals.h"
#include "levels.h"

/*void checkLevelCompletion() {
    if (planesRemaining > 0) return;

    // If already in transition, don't retrigger
    if (gameState == SHOW_LEVEL_TEXT) return;

    levelStartTime = glutGet(GLUT_ELAPSED_TIME);
    gameState = SHOW_LEVEL_TEXT;

    if(currentLevel == 1) {
        currentLevelText = "LEVEL 2";
        currentLevel = 2;
        initLevel2();
    }
    else if(currentLevel == 2) {
        currentLevelText = "LEVEL 3";
        currentLevel = 3;
        initLevel3();
    }
    else if(currentLevel == 3) {
        currentLevelText = "LEVEL 4";
        currentLevel = 4;
        initHelicopters();
    }
    else if(currentLevel == 4) {
        currentLevelText = "CONGRATULATIONS! YOU WIN!";
        //gameState = GAME_END;
    }
}*/

bool levelCompleted = false;
int helicoptersRemaining = 0;


void checkLevelCompletion() {
    if (soldierLife <= 0) return;
    if (planesRemaining > 0) return;
    if (currentLevel == 4) {
        if (helicoptersRemaining > 0) return;
    }

    if (gameState == SHOW_LEVEL_TEXT) return;

    levelCompleted = true;
    levelStartTime = glutGet(GLUT_ELAPSED_TIME);
    gameState = SHOW_LEVEL_TEXT;

    if (currentLevel == 1){
        currentLevelText = "LEVEL 2";
    }
    else if (currentLevel == 2) {
        currentLevelText = "LEVEL 3";
    }
    else if (currentLevel == 3) {
        currentLevelText = "LEVEL 4";
    }
    else if (currentLevel == 4){
        currentLevelText = "LEVEL 5 - FINAL WAVE";
    }
    else if (currentLevel == 5) {

        if (!atomBomb.alive && !gameOver) {
            gameWon = true;
        }
        if (planesRemaining > 0) return;
        if (helicoptersRemaining > 0) return;
        if (soldierLife <= 0) return;


        return;
    }
}

void updateGame() {
    if (gameState != SHOW_LEVEL_TEXT) return;

    int now = glutGet(GLUT_ELAPSED_TIME);
    if (now - levelStartTime < 2000) return;

    if (gameOver || gameWon) return;

    if (!levelCompleted) {
        gameState = PLAYING;
        return;
    }

    levelCompleted = false;
    currentLevel++;

    if (currentLevel == 2) initLevel2();
    else if (currentLevel == 3) initLevel3();
    else if (currentLevel == 4) initHelicopters();
    else if (currentLevel == 5) initLevel5();

    gameState = PLAYING;
}

