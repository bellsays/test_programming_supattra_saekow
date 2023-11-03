using Microsoft.AspNetCore.Mvc;
using System;

namespace Numbers
    {
    class Program
        {

            static void Main(string[] args)
            {
                
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("| {0} | {1} |", i,"11");
                    Console.WriteLine("| {0} | {1} |", i,"2**2");
                    Console.WriteLine("| {0} | {1} |", i,"3****3");
                    Console.WriteLine("| {0} | {1} |", i,"4*******");
                    Console.WriteLine("| {0} | {1} |", i,"3****3");
                    Console.WriteLine("| {0} | {1} |", i, "2**2");
                    Console.WriteLine("| {0} | {1} |", i, "11");
                }
            }
        }
}