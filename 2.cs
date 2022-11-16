//برنامه ای بنویسید که موجودی حساب بانکی به همراه بهره سالانه را دریافت کرده و تعیین کند پس از چند سال موجودی حساب به مبلغ موردنظر خواهد رسید
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your balance:");
            int current_balance =
                Convert.ToInt32(Console.ReadLine());
            Console.Write("enter interest(percenr):");
            int Interest = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter feature balance:");
            int feature_balance =
                Convert.ToInt32(Console.ReadLine());

            int years = 0;
            int balance = current_balance;
            while(balance<feature_balance)
            { balance += (balance * Interest) / 100;
                years++;
            }
            Console.WriteLine("years:" + years.ToString());

        }
    }
}
