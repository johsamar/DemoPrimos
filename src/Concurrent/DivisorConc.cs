using System;
using System.Threading;

public class DivisorConc
{
    long numero;
    int threads;
    Thread[] trs;
    bool isPrime;
    int divisors;
    (long,long)[] datas;
    
    public DivisorConc(long numero, int threads)
    {
        this.numero = numero;
        this.threads = threads;
        this.trs = new Thread[threads];
        this.isPrime = true;
        //this.listdates = new long[threads, 2];
        datas = new (long,long)[threads];
        this.divisors = 0;
    }

    public long getDivisores()
    {
        return this.divisors;
    }

    public bool getIsPrime()
    {
        return isPrime;
    }

    public void startProccesConcurrent()
    {
        long numReal = (long)Math.Sqrt(this.numero);
        Console.WriteLine(numReal);
        long start = 3;
        long end = numReal / this.threads;

        for (int i = 0; i < this.threads; i++)
        {
            if (i == this.threads - 1)
            {
                end = numReal;
            }
            this.trs[i] = new Thread(new ParameterizedThreadStart(numOfPosDivisors));
            datas[i] = (start,end);
            start = end + 1;
            end = (start + (numReal / this.threads) - 1);

        }

        for (int i = 0; i < this.threads; i++)
        {
            this.trs[i].Start(datas[i]);
        }
        
    }
    
    public void numOfPosDivisors(object newData)
    {
        //listaDates = [[2, 4969135984], [4969135985, 9938271968]]
        (long,long) recDatas = ((long,long)) newData;
        Console.WriteLine(recDatas);
        
        long from = recDatas.Item1;
        long end = recDatas.Item2;
        
        if(this.numero % 2 == 0 && this.numero!=2){
            isPrime = false;
            return;
        }
        for(long i = from;i<=end; i += 2){
            if(this.numero%i==0){
                isPrime = false;
            }
            if(!isPrime){
                break;
            }
        }
        
        //Console.WriteLine("div "+divisor.getDivisores());
        //Console.WriteLine("condiv: "+ this.divisors);
    }
}