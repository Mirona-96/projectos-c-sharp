﻿using System;

class raizQuadradaExec
{
    public static void Main(string[] args)
    {
     Console.WriteLine("Insira um numero");
     double num = Convert.ToDouble(Console.ReadLine());

    double rq = Math.Sqrt(num);
    Console.WriteLine("A raiz quadrada de " + num + " eh " + rq);

    }
}
