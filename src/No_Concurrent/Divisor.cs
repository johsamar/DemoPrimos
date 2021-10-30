using System;
public class Divisor
{

    long numero;
    int divisors;

    long ini;
    long end;

    bool isPrime;

    public Divisor(long num, long ini, long end)
    {
        this.numero = num;
        this.ini = ini;
        this.end = end;
        this.divisors = 2;
        this.isPrime = true;
    }
    public bool getIsPrime()
    {
        if (this.divisors != 2)
        {
            this.isPrime = false;
            return this.isPrime;
        }
        return this.isPrime;
    }
    public int getDivisores()
    {
        return divisors;
    }
    public void numOfPosDivisors()
    {   
        long numReal = (long)Math.Sqrt(this.numero);
        
        long end = numReal;
        Console.WriteLine(end);
        
        if(this.numero % 2 == 0 && this.numero!=2){
            isPrime = false;
            return;
            Console.WriteLine("return?");
        }

        long start = 3;
        for(long i = start;i<=end; i += 2){
            //Console.WriteLine(i);
            if(this.numero%i==0){
                isPrime = false;
                Console.WriteLine(i);
            }
            if(!isPrime){
                Console.WriteLine(isPrime);
                break;
                Console.WriteLine("return?");
            }
        }

    }
}