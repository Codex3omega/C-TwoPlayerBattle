using Raylib_cs;

namespace TwoPlayerBattleGame;

using static Raylib_cs.Raylib;

public class Game
{

    private int SCREEN_W;
    private int SCREEN_H;

    public bool running;
    
    
    public Game(int screen_w, int screen_h)
    {
        running = true;
        
        SCREEN_W = screen_w;
        SCREEN_H = screen_h;
        
        InitWindow(SCREEN_W, SCREEN_H, "Game");
        SetTargetFPS(60);
        
        
    }

    public void Update(float dt)
    {
        if (WindowShouldClose() && running)
            running = false;
    }

    public void Draw()
    {
        BeginDrawing();
        
        ClearBackground(Color.Green);
        
        EndDrawing();
    }

    public void Run(float dt)
    {
        if (running)
        {
            Update(dt);
            Draw();
            
        }
        else if (!running)
        {
            Terminate();
        }
    }

    public void Terminate()
    {
        CloseWindow();
    }
}