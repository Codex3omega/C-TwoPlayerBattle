using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;
namespace TwoPlayerBattleGame;

public class Map_Manager
{
    private int cell_size = 16;
    private int screen_width = 1920;
    private int screen_height = 1080;

    private Texture2D atlas;
    
    private List<List<int>> envsList;
        
    
    public Map_Manager()
    {
        try
        {
            using (StreamReader reader = new StreamReader("Environment.txt"))
            {
                int x = 0;
                int y = 0;
                int data;
                while ((data = reader.Read()) != -1 && x < screen_width/cell_size &&  y < screen_height/cell_size)
                {
                    envsList[x][y] = data;
                    x += 1;
                    y += 1;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("File Could Not Be Loaded");
            Console.WriteLine(e);
        }
    }

    public void Draw()
    {
        int cell_x = 0;
        int cell_y = 0;
        
        foreach (var x in envsList)
        {
            foreach (var y in envsList)
            {
                
               // DrawTexturePro(atlas, new Rectangle(y*cell_size, y*cell_size,cell_size, cell_size ));
            }
        }
    }
    
    
}