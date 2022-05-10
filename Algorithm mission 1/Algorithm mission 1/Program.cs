﻿using System;

namespace Algorithm_mission_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FOR y FROM -10 to 10 DO
             FOR x FROM 1 to 80 DO
              SET REAL r TO 0
             SET REAL i TO 0
             SET INTEGER k TO -1

           WHILE r² + i² < 11 AND k < 112
            SET REAL t TO r
            SET r TO t² - i² - 2.3 + x / 24.5
            SET i TO 2 * t * i + y / 8.5
            INCREMENT k
           END WHILE

             SET INTEGER c TO k MOD 16
             SET Console.BackgroundColor TO (ConsoleColor)c
             SEND ' ' TO DISPLAY
            END FOR

            SEND NEW LINE TO DISPLAY
          END FOR
            */

            for (int y = -10; y <= 10; y++)
            {
                for (int x = 1; x <= 80; x++)
                {
                    double r = 0;
                    double i = 0;
                    int k = -1;

                    while (r * r + i * i < 11 && k < 112)
                    {
                        double t = r;
                        r = t * t - i * i - 2.3 + x / 24.5;
                        i = 2 * t * i + y / 8.5;
                        k++;
                    }

                    int c = k % 16;
                    Console.BackgroundColor = (ConsoleColor)c;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }



        }
    }
}
