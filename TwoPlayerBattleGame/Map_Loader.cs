using System.Numerics;
namespace TwoPlayerBattleGame;

public class Map_Loader
{
    public Map_Loader(ref int[,] envsList)
    {
        try
        {
            using (StreamReader reader = new StreamReader("Environment.txt"))
            {
                if (!reader.EndOfStream)
                {
                    int x = 0;
                    int y = 0;
                   // while(x < envsList.)


                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("File Could Not Be Loaded");
            Console.WriteLine(e);
        }
    }
    
    
}