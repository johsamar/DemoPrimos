﻿using System;
using System.Diagnostics;
//using System.Threading;

namespace Demo_Divisores
{
    class Program
    {
        static void Main(string[] args)
        {
            //long num = 20;
            //long num = 19_876_543_937L; // par que pirmo
            //long num = 19_876_543_934L; // par que no es primo
            long num = 19_876_543_935L; // impar que no es primo
            //long num = 19_876_543_937L; //impar que es primo
            int threads = 2;
            
            Console.WriteLine("Number: " + num);
            Console.WriteLine("[Main process]");
            Stopwatch mainTime = new Stopwatch();//obj to take the time no concurrent
            mainTime.Start();
            Divisor divisor = new Divisor(num, 2, (long)Math.Sqrt(num));
            divisor.numOfPosDivisors();
            
            Console.WriteLine("Is Prime: " + divisor.getIsPrime());
            mainTime.Stop();
            Console.WriteLine($"Time: {mainTime.Elapsed.TotalSeconds} s");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("[Concurrent process] Threads: {0}", threads);
            Stopwatch concurretTime = new Stopwatch();//obj to take the time concurrent
            concurretTime.Start();
            DivisorConc divisorConc = new DivisorConc(num, threads);
            divisorConc.startProccesConcurrent();
            //Console.WriteLine("divs: " + divisorConc.getDivisores());
            //Console.WriteLine(divisorConc.getListadates());
            Console.WriteLine("Is Prime: " + divisorConc.getIsPrime());
            concurretTime.Stop();
            Console.WriteLine($"Time: {concurretTime.Elapsed.TotalSeconds} s");
            
        }
    }
}
