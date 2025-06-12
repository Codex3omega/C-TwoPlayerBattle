// See https://aka.ms/new-console-template for more information

using Raylib_cs;
using TwoPlayerBattleGame;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game(1280, 720);
        while (game.running)
        {
            float dt = Raylib.GetFrameTime();
            game.Run(dt);
        }
    }
}