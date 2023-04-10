using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> listx = new List<double>();
        List<double> listy = new List<double>();

        int n = int.Parse(Console.ReadLine());
        var inputx = Console.ReadLine().Split(' ');
        var inputy = Console.ReadLine().Split(' ');

        for(int i = 0; i < inputx.Length; i++)
        {
            listx.Add(double.Parse(inputx[i]));
            listy.Add(double.Parse(inputy[i]));
        }

        //p = 1
        List<double> anslist = new List<double>();
        for(int i = 0; i < listx.Count; i++)
        {
            anslist.Add(Math.Abs(listx[i] - listy[i]));
        }
        var ans1 = anslist.Sum();

        //p = 2
        anslist.Clear();
        for (int i = 0; i < listx.Count; i++)
        {
            anslist.Add(Math.Pow(listx[i] - listy[i],2));
        }
        var ans2 = Math.Sqrt(anslist.Sum());

        //p = 3
        anslist.Clear();
        for (int i = 0; i < listx.Count; i++)
        {
            anslist.Add(Math.Pow(Math.Abs(listx[i] - listy[i]), 3));
        }
        var ans3 = Math.Pow(anslist.Sum(),1.0/3.0);

        //p = infinity
        anslist.Clear();
        for (int i = 0; i < listx.Count; i++)
        {
            anslist.Add(Math.Abs(listx[i] - listy[i]));
        }
        var ans4 = anslist.Max();

        Console.WriteLine(ans1);
        Console.WriteLine(ans2);
        Console.WriteLine(ans3);
        Console.WriteLine(ans4);
    }
}