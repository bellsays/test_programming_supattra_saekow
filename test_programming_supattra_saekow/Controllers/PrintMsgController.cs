using Microsoft.AspNetCore.Mvc;
using System;

public class Numbers
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    public int Number3 { get; set; }
    public int Number4 { get; set; }
}

namespace Numbers
    {
        class Program
        {

            static void Main(string[] args)
            {
                // สร้างวัตถุ Numbers
                Numbers numbers = new Numbers();

                // กำหนดค่าให้แต่ละสมาชิกของวัตถุ Numbers
                numbers.Number1 = 11;
                numbers.Number2 = 2 * 2;
                numbers.Number3 = numbers.Number2;
                numbers.Number4 = numbers.Number1;

                // แสดงข้อมูลตัวเลขในรูปของตาราง
                Console.WriteLine("| ลำดับ | ตัวเลข |");
                Console.WriteLine("|---|---|");
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("| {0} | {1} |", i, numbers.Numbers[i - 1]);
                }

                // เพิ่มรูปแบบให้กับข้อมูล
                Console.WriteLine("\n\n| ลำดับ | ตัวเลข |");
                Console.WriteLine("|---|---|");
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("| {0} | {1,-3} |", i, numbers.Numbers[i - 1]);
                }
            }
        }
}