using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_GameLoop_SpencerChapman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            int xLine = 0; // x 0 to 119
            int yLine = 0; // 0 to infinite

            void PlayerDraw(int x, int y)
            {
                Console.SetCursorPosition(xLine, yLine);
                
            }
            
            void PlayerUpdate()
            {
                
                ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
                
                if (readKeyInput.Key == ConsoleKey.W)
                {
                    yLine = yLine - 1;
                }
                if (readKeyInput.Key == ConsoleKey.A)
                {
                    xLine = xLine - 1;
                }
                if (readKeyInput.Key == ConsoleKey.S)
                {
                    yLine = yLine + 1;
                }
                if (readKeyInput.Key == ConsoleKey.D)
                {
                    xLine = xLine + 1;
                }
                if (yLine >= 30)                 // start of range checking
                {
                    yLine = 30;
                }
                if (xLine <= 0)
                {
                    xLine = 0;
                }
                if (xLine >= 119)
                {
                    xLine = 119;
                }
                if (yLine <= 0)
                {
                    yLine = 0;
                }
                if (readKeyInput.Key == ConsoleKey.Escape)
                {
                    gameOver = true; // ends the game
                }
            }

            while (gameOver == false) // the loop
            {
                PlayerDraw(xLine, yLine);
                PlayerUpdate();
            }
        }
    }
}
