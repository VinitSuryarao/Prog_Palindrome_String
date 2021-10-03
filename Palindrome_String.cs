using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Palindrome String
        //   Civic, Noon
        static void Main(string[] args)
        {

            string str = "Noon", revstr = null;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstr = revstr + str[i];
            }

            if( str.ToLower() == revstr.ToLower())
            Console.WriteLine(" Palindrome String");
            Console.ReadLine();
        }
    }


