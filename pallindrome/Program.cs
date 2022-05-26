using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pallindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int firstindex =0;
            int lastindex;
            bool feature = true;
           


            Console.WriteLine("enter the word");
            name = Console.ReadLine();
            lastindex = name.Length - 1;
            while (firstindex <= lastindex)
            {
                firstindex++;
                lastindex--;
                if (name[firstindex] == name[lastindex])
                {
                    feature = true;
                }

                if(name[firstindex] != name[lastindex])
                {
                    feature = false;
                }
            }

            if(feature == true)
            {
                Console.WriteLine("the word is  pallindrome");
            }

            if (feature == false)
            {
                Console.WriteLine("the word is not pallindrome");
            }



        }
    }
}
