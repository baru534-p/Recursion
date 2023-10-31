using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();

        }
        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "Bhargavi";
            students[1] = "Vasu";
            students[2] = "pushpa";
            students[3] = "Srilekha";
            students[4] = "Salma";
            students[5] = "lalasa";
            students[6] = "Asifa";
            students[7] = "priya";
            students[8] = "Durga";
            students[9] = "padma";

            int currElem = 0;
            printViaRecursion(students, currElem);
        }

        public static void printViaRecursion(string[] arr, int currElem)
        {
            Console.WriteLine(arr[currElem]);
            if (currElem < arr.Length - 1)
                printViaRecursion(arr, currElem + 1);
        }
    }
}

    




    

