using System;
using MultiToolLib;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MultiTool Console Demo ===");
            Console.Write("Nhap chuoi vao (vi du ten hoac cau): ");
            string input = Console.ReadLine();


            MultiTool mt = new MultiTool();
            mt.InputText = input;
            mt.Signature = "-- by Hoang Thi Xuan Trang (Console)";
            bool ok = mt.Process();


            Console.WriteLine();
            Console.WriteLine("--- Ket qua ---");
            Console.WriteLine(mt.OutputText);


            Console.WriteLine("Nhan Enter đe ket thuc...");
            Console.ReadLine();
        }
    }
}