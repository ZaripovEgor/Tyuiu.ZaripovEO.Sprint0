﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZaripovEO.Sprint0.Task2.Lib;
namespace Tyuiu.ZaripovEO.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Егор"));
            Console.ReadKey();
        }
    }
}
