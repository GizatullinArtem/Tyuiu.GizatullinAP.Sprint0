﻿using System;

using Tyuiu.GizatullinAP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GizatullinAP.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Артём"));
            Console.ReadKey();
        }
    }
}
