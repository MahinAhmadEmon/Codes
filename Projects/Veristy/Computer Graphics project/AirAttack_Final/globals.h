
#pragma once
#include <windows.h>
#include <GL/glut.h>
#include <bits/stdc++.h>
using namespace std;

extern const float pi;
extern const int width;
extern const int height;

extern double groundArr[28][2];

// ---- Soldier State ---- //
extern float soldierX;
extern float soldierY;
extern float soldierSpeed;
extern int soldierFacing; // +1 = right, -1 = left
extern float aimAngle;

// ---- Soldier Life ---- //
extern int soldierLife;
extern const int soldierMaxLife;
extern bool soldierRespawning;
extern float soldierFallSpeed;


// ---- Jump State ---- //
extern bool isJumping;
extern float jumpVelocity;
extern float gravity;
extern float maxJumpVelocity;
extern float jumpOffset;
extern float jumpBaseY;
extern bool jumpKeyHeld;

// --- bullet ---- //
struct Bullet {
    float x, y;
    float vx, vy;
    bool active;
};
extern Bullet bullet;
extern bool bulletAvailable;

// ---- Plane ---- //
struct Plane {
    float x, y;
    float speed;
    int dir;
    bool alive;
    int bombingTimer;
};

extern const float PLANE_ORIGIN_X;
extern const float PLANE_ORIGIN_Y;

extern float levelBaseSpeed[5];

#define LEVEL1_PLANE_COUNT 1
#define LEVEL2_PLANE_COUNT 1
#define LEVEL3_PLANE_COUNT 1
#define LEVEL5_PLANE_COUNT 1

extern Plane level1Planes[LEVEL1_PLANE_COUNT];
extern Plane level2Planes[LEVEL2_PLANE_COUNT];
extern Plane level3Planes[LEVEL3_PLANE_COUNT];
extern Plane level5Planes[LEVEL5_PLANE_COUNT];

void updateLevel5Planes();

extern int planesRemaining;

// ================= HELICOPTER =================

#define MAX_HELICOPTERS 3
#define MAX_HELI_BULLETS 1

struct Helicopter {
    float x, y;
    float speed;
    int dir;
    bool alive;
    int fireTimer;
};

struct HeliBullet {
    float x, y;
    float vx, vy;
    bool active;
};

// Helicopter data
extern Helicopter helicopters[MAX_HELICOPTERS];
extern HeliBullet heliBullets[MAX_HELI_BULLETS];

// Helicopter functions
void initHelicopters();
void updateHelicopters();
void renderHelicopters();
void updateHeliBullets();
void checkBulletHelicopterCollision();
void fireHelicopterBullet(float hx, float hy);

// Draw types
void drawHelicopterType1();
void drawHelicopterType2();

extern int helicoptersRemaining;



extern int currentLevel;
extern bool levelCompleted;

// ---- Bomb ---- //
struct Bomb {
    float x, y;
    float vy;
    bool active;
};
#define MAX_BOMBS 5
extern Bomb bombs[MAX_BOMBS];



// ---- Game State ---- //
enum GameState {
    WAIT_BEFORE_TEXT,   // 2s before showing text
    SHOW_LEVEL_TEXT,    // 3s showing text
    WAIT_AFTER_TEXT,    // 2s after text
    PLAYING
};

extern GameState gameState;
extern float levelStartTime;
extern string currentLevelText;
extern bool levelTransitionStarted;
extern int nextLevel;


const float WAIT_BEFORE_TEXT_DURATION = 2000;  // milliseconds
const float SHOW_LEVEL_TEXT_DURATION  = 3000;
const float WAIT_AFTER_TEXT_DURATION  = 2000;

// ---- Building ---- //
struct Building {
    float xStart, xEnd;
    float yTop, yBottom;
};

const int NUM_BUILDINGS = 3;
const Building buildings[NUM_BUILDINGS] = {
    {300, 400, 160, 80},
    {500, 600, 280, 80},
    {800, 900, 220, 80}
};

// ===== LEVEL 5 =====

struct AtomBomb {
    float x, y;
    float vy;
    bool alive;
};

extern AtomBomb atomBomb;

extern bool gameOver;
extern bool gameWon;

// ===== LEVEL 5 / ATOM BOMB =====
void drawAtomBomb();
void checkAtomBombCollision();
void updateAtomBomb();
extern bool atomBombActivated;
// ---------- ATOM BOMB EXPLOSION ----------
extern bool  atomExplosionActive;
extern float atomExplosionX;
extern float atomExplosionY;

// -------- APP SCREENS --------
enum AppScreen {
    SCREEN_COVER = 0,
    SCREEN_TITLE,
    SCREEN_INSTRUCTION,
    SCREEN_GAME
};

extern AppScreen currentScreen;

#define MAX_HEART_PICKUPS 2

struct HeartPickup {
    float x, y;
    float vy;
    bool active;
};

extern HeartPickup heartPickups[MAX_HEART_PICKUPS];
extern bool heartsSpawned;


// ---- SHIELD ----
extern bool shieldActive;
extern float shieldStartTime;
const float SHIELD_DURATION = 5000.0f; // 5 seconds (ms)
