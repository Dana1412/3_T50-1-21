using System;
using System.Collections.Generic;

namespace homework
{
    class Program
    {
        static int ActiveListFrequency = 0;
        static List<int[]> ListFrequency = new List<int[]> {
            new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 },
            new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 },
            new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 },
        };

        static void Main(string[] args) {
            Open();
        }
        static void Open()
        {
            Console.Clear();
            Console.WriteLine($"Переключение между октавами - F1, F2, F3");
            Console.WriteLine($"Откава: {ActiveListFrequency}");
            InputKey(Console.ReadKey());
        }
        static void InputKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Escape) Open();
            else
            {
                if (key.Key == ConsoleKey.F1) ActiveListFrequency = 0;
                if (key.Key == ConsoleKey.F2) ActiveListFrequency = 1;
                if (key.Key == ConsoleKey.F3) ActiveListFrequency = 2;
                PlaySoud(key);
            }
        }
        static void PlaySoud(ConsoleKeyInfo key, int duration = 100)
        {
            if (key.Key == ConsoleKey.Q) Console.Beep(ListFrequency[ActiveListFrequency][0], duration);
            if (key.Key == ConsoleKey.W) Console.Beep(ListFrequency[ActiveListFrequency][1], duration);
            if (key.Key == ConsoleKey.E) Console.Beep(ListFrequency[ActiveListFrequency][2], duration);
            if (key.Key == ConsoleKey.R) Console.Beep(ListFrequency[ActiveListFrequency][3], duration);
            if (key.Key == ConsoleKey.T) Console.Beep(ListFrequency[ActiveListFrequency][4], duration);
            if (key.Key == ConsoleKey.Y) Console.Beep(ListFrequency[ActiveListFrequency][5], duration);
            if (key.Key == ConsoleKey.U) Console.Beep(ListFrequency[ActiveListFrequency][6], duration);
            if (key.Key == ConsoleKey.I) Console.Beep(ListFrequency[ActiveListFrequency][7], duration);
            if (key.Key == ConsoleKey.O) Console.Beep(ListFrequency[ActiveListFrequency][8], duration);
            if (key.Key == ConsoleKey.P) Console.Beep(ListFrequency[ActiveListFrequency][9], duration);
            if (key.Key == ConsoleKey.A) Console.Beep(ListFrequency[ActiveListFrequency][10], duration);
            if (key.Key == ConsoleKey.S) Console.Beep(ListFrequency[ActiveListFrequency][11], duration);
            Open();
        }
    }
}
