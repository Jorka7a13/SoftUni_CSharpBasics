// Implement the "Falling Rocks" game
using System;
using System.Diagnostics;
using System.Threading;

namespace FallingRocks
{
    class FallingRocks
    {

        static Stone[,] array = new Stone[25, 80];
        static int difficulty = 4;
        static Random rnd = new Random();
        static int x, y;
        static bool playing = true;
        static int score = 0;
        static Stopwatch stopwatch = new Stopwatch();

        static void GenerateLineOfRocks()
        {
            char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
            int sizeOfRocks, posOfRock;
            int numOfRocks = rnd.Next(1, difficulty);

            for (int i = 0; i < numOfRocks; i++)
            {
                Stone stone = new Stone();
                sizeOfRocks = rnd.Next(1, 4);
                stone.color = rnd.Next(0, 4);
                stone.sign = rocks[rnd.Next(0, rocks.GetLength(0) - 1)];
                posOfRock = rnd.Next(0, 77);

                for (int j = 0; j < sizeOfRocks; j++)
                {
                    array[0, posOfRock] = stone;
                    writeStoneAtPos(stone, 0, posOfRock);
                    posOfRock++;
                }
            }
        }

        static void MoveRocksDown()
        {
            Stone[,] temp = new Stone[25, 80];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (i != 24)
                        temp[i + 1, j] = array[i, j];

            array = temp;

            Console.MoveBufferArea(0, 0, y, 24, 0, 1); //Move rocks down a line 
            Console.MoveBufferArea(y + 3, 0, 80 - (y + 3), 24, y + 3, 1);
            Console.MoveBufferArea(y, 0, 3, 23, y, 1);
        }

        static void CollisionDetection()
        {
            if (array[x, y] != null || array[x, y + 1] != null || array[x, y + 2] != null)
                playing = false;
        }

        static void MoveDwarf()
        {
            x = Console.WindowTop + Console.WindowHeight - 1;
            y = Console.WindowLeft + Console.WindowWidth / 2;
            writeStrAtPos("(O)", x, y);

            ConsoleKeyInfo key;

            while (playing)
            {
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (y > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        writeStrAtPos("(O)", x, --y);
                        writeStrAtPos(" ", x, y + 3);
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (y < Console.WindowLeft + Console.WindowWidth - 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        writeStrAtPos("(O)", x, ++y);
                        writeStrAtPos(" ", x, y - 1);
                    }
                }
            }
        }

        static void writeStoneAtPos(Stone stone, int x, int y)
        {
            try
            {
                if (stone.color == 0)
                    Console.ForegroundColor = ConsoleColor.White;
                else if (stone.color == 1)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else if (stone.color == 2)
                    Console.ForegroundColor = ConsoleColor.Gray;
                else if (stone.color == 3)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                else if (stone.color == 4)
                    Console.ForegroundColor = ConsoleColor.Green;

                Console.SetCursorPosition(y, x);
                Console.Write(stone.sign);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        static void writeStrAtPos(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(y, x);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Falling Rocks";
            Console.BufferHeight = 25;
            Console.BufferWidth = 80;

            Thread t = new Thread(MoveDwarf);
            t.Start();

            System.Threading.Thread.Sleep(250);

            stopwatch.Start();

            while (playing)
            {
                GenerateLineOfRocks();

                System.Threading.Thread.Sleep(150);

                MoveRocksDown();

                CollisionDetection();

                score += 10;
            }

            stopwatch.Start();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("Your score was: " + (score - 240));
            Console.WriteLine("Yor time was: " + stopwatch.Elapsed.ToString("mm\\:ss\\.ff"));
            Console.WriteLine("Press ESC to exit");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
                key = Console.ReadKey();

        }
    }
}