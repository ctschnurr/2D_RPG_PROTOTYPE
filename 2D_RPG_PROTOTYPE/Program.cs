using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG_PROTOTYPE
{
    internal class Program
    {

        static char[,] worldMap = new char[,] // placeholder starting map:
        {
            {'╔','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═',     '═',    '═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','╗'},
            {'║',' ',' ','▄',' ',' ',' ',' ',' ',' ','▄',' ',' ',' ',' ',' ',' ',' ',' ','▄',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ','█','█','█',' ','▄',' ',' ','█','█','█',' ',' ',' ',' ','▄',' ','█','█','█',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ','▄','╨',' ','█','█','█',' ',' ','╨',' ','▄',' ',' ','█','█','█',' ','╨',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║','█','█','█',' ',' ','╨',' ',' ','▄',' ','█','█','█',' ',' ','╨',' ','▄',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ','╨',' ','▄',' ',' ',' ','█','█','█',' ','╨',' ','▄',' ',' ','█','█','█',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ','█','█','█',' ',' ',' ','╨',' ','▄',' ','█','█','█',' ',' ','╨',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    '▄',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ','╨','▄',' ',' ',' ',' ','█','█','█',' ','╨',' ','▄',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▄','█','█',     '█',    '▀','█','▄',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ','▄',' ','█','█','█',' ',' ',' ',' ','╨',' ',' ',' ','█','█','█',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','│',' ','│',     '┌',    '─','┐','│',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║','█','█','█',' ','╨',' ',' ',' ','▄',' ',' ',' ',' ',' ',' ','╨',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','└','─','┴',     '┘',    '▀','└','┘',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ','╨',' ',' ',' ',' ',' ','█','█','█',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ','╨',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    '▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒','▒','▒',     '▒',    '▒','▒','▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','┼','┼','┼',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒','▒','▒','▒','~','~',     '~',    '~',' ','▒','▒','▒','▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','~','~','~','~','┼','┼','┼','~','~','~','~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','~','~','▒','▒','▒','~','~','~','~','~',     '~',    '~',' ',' ',' ',' ','▒','▒','▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ','~','~','~','~','~','~','~','~','~','~','┼','┼','┼','~','~','~','~','~','~','~','~',' ',' ',' ','~','~','~','~','~','~','~','~','~','~','~','~','~',     '~',    '~',' ',' ',' ',' ',' ',' ','▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'╨',' ',' ','~','~','~','~','~','~','~','~','~','~','~','~','~','~','┼','┼','┼','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~',     '~',    '~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','┼','┼','┼','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~',     '~',    '~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'~','~','~','~','~','~','~','~','~','~','~','~','~','~',' ',' ',' ','┼','┼','┼',' ',' ',' ','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~',     '~',    '~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'~','~','~','~','~','~','~','~','~','~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','~','~','~','~',' ',' ',' ','~','~','~','~','~','~','~','~','~','~',     '~',    '~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'~','~','~','~','~','~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒','▒','▒','~','~','~','~','~',     '~',    '~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'╥',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒','▒','▒','▒','~','~',     '~',    '~',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒','▒','▒',     '▒',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'║',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',     ' ',    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','║'},
            {'╚','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═',     '═',    '═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','╝'},
        };

        // 148 176 ░ 177 ▒ 178 ▓
        // 179 │ 180 ┤ 191 ┐ 192 └ 193 ┴ 194 ┬ 195 ├ 196 ─ 197 ┼ 217 ┘ 218 ┌    ╱╲╳
        // 185 ╣ 186 ║ 187 ╗ 188 ╝ 200 ╚ 201 ╔ 202 ╩ 203 ╦ 204 ╠ 205 ═ 206 ╬ ╭╮
        // 219 █ 220 ▄ 223 ▀                                                 ╰╯

        static char[] walkables = new char[3];

        static int mapHeight = worldMap.GetLength(0);
        static int mapWidth = worldMap.GetLength(1);

        static string mapName = "The Observatory";
        static bool gameOver = false;

        static ConsoleKeyInfo choice;

        static char character;
        static int x = 5;
        static int y = 5;
        static void Main(string[] args)
        {
            Console.SetWindowSize(91, 41);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            Console.CursorVisible = false;

            walkables = new char[] { ' ', '▒', '▀', '┼' };

            character = (char)1;

            DisplayMap();
            while (gameOver == false)
            {
                //Console.Clear();
                //DrawMap();
                PlayerDraw(x + 2, y + 1);
                PlayerUpdate();
            }
        }

        static void PlayerDraw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(character);
        }

        static void DisplayMap()
        {

            for (int mapX = 0; mapX < mapHeight; mapX++)
            {
                Console.SetCursorPosition(2, mapX + 1);
                for (int mapY = 0; mapY < mapWidth; mapY++)
                {
                    char tile = worldMap[mapX, mapY];

                    DrawTile(tile);
                                        
                    Console.ResetColor();
                }

            }
            Console.SetCursorPosition(75, 39);
            Console.Write(mapName);

        }

        static void DrawTile(char tile)
        {
            switch (tile)
            {
                case '█':
                case '▄':
                case '▀':
                    //Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(tile);
                    break;

                case '▒':
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    //Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(tile);
                    break;

                case '~':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(tile);
                    break;

                case '┼':
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(tile);
                    break;

                default:
                    Console.Write(tile);
                    break;

            }
            Console.ResetColor();
        }

        static void PlayerUpdate()
        {
            bool isWalkable;
            char destination = ' ';

            choice = Console.ReadKey(true);

            Console.SetCursorPosition(x + 2, y + 1);
            char tile = worldMap[y,x];

            DrawTile(tile);



            switch (choice.Key)
            {
                case ConsoleKey.Escape:
                    gameOver = true;
                    break;

                case ConsoleKey.W:
                    destination = worldMap[y - 1, x];
                    isWalkable = CheckWalkable(destination);

                    if (isWalkable == true)
                    {
                        y--;
                        break;
                    }
                    else
                    {
                        break;
                    }

                case ConsoleKey.S:
                    destination = worldMap[y + 1, x];
                    isWalkable = CheckWalkable(destination);

                    if (isWalkable == true)
                    {
                        y++;
                        break;
                    }
                    else
                    {
                        break;
                    }

                case ConsoleKey.A:
                    destination = worldMap[y, x - 1];
                    isWalkable = CheckWalkable(destination);

                    if (isWalkable == true)
                    {
                        x--;
                        break;
                    }
                    else
                    {
                        break;
                    }

                case ConsoleKey.D:
                    destination = worldMap[y, x + 1];
                    isWalkable = CheckWalkable(destination);

                    if (isWalkable == true)
                    {
                        x++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            // CheckForDoor();
        }

        static bool CheckWalkable(char destination)
        {
            bool goTime = false;

            foreach (char walkable in walkables)
            {
                if (destination == walkable)
                {
                    goTime = true;
                }
            }

            return goTime;
        }
    }
}
