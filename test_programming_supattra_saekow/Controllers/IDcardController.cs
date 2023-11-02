using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;



namespace test_programming_supattra_saekow.Controllers
{
    public class IDcardController : Controller
    {
        string idCardNumber = "1201541462234";
        public IActionResult Index()
        {
            return View();
        }
        public static bool IsValidIDCard(string idCardNumber)
        {


            // ตรวจสอบรูปแบบของเลขบัตรประจำตัวประชาชน
            if (!Regex.IsMatch(idCardNumber, @"^\d{13}$"))
            {
                return false;
            }

            // แยกเลขบัตรประจำตัวประชาชนออกเป็น 12 หลักแรกและหลักตรวจสอบ
            string idNumber = idCardNumber.Substring(0, 12);
            char checkDigit = idCardNumber[12];

            // คำนวณเลขตรวจสอบ
            int[] weight = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += weight[i] * int(idNumber[i]);
            }

            // ตรวจสอบเลขตรวจสอบ
            int expectedCheckDigit = (11 - sum % 11) % 10;
            if (checkDigit != expectedCheckDigit)
            {
                return false;
            }


          

            if (IsValidIDCard(idCardNumber))
            {
                Console.WriteLine("เลขบัตรประจำตัวประชาชนถูกต้อง");
            }
            else
            {
                Console.WriteLine("เลขบัตรประจำตัวประชาชนไม่ถูกต้อง");
            }
            return true;
        }
    }

}
