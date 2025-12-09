using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MisalignedSpace {
    public static class Misaligned {
        static List<(int, string, string)> GetColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            var map = new List<(int, string, string)>();

            int i = 0, j = 0;
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    map.Add((i * 5 + j, majorColors[i], minorColors[i]));
                    Console.WriteLine(PrintColorMap( i * 5 + j, majorColors[i], minorColors[i]));
                }
            }
            return map;
        }

        static string PrintColorMap(int number, string major, string minor)
        {
            return string.Format("{0} | {1} | {2}", number, major, minor);
        }
        static void Main(string[] args)
        {
            var map = Misaligned.GetColorMap();

            Debug.Assert(map.Count == 25);

            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int index = 0;
            for (int i = 0; i < majorColors.Length; i++)
            {
                for (int j = 0; j < minorColors.Length; j++)
                {
                    Debug.Assert(map[index] == (i * majorColors.Length + j, majorColors[i], minorColors[j]),
                        $"Mismatch at index {index}: {map[index]}");
                    index++;
                }
            }

            string formatted = Misaligned.PrintColorMap(0, "White", "Blue");
            Debug.Assert("0  | White  | Blue   " == formatted);
            Console.WriteLine("All is well (maybe!)");
        }

    }
}
