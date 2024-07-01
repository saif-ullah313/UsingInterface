using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UsingInterface
{
public class OperationOnStrings : IOperationOnStrings
    {
        //public void FindMaximumInThree()
        //{
        //    int[] numArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    var findMax = from number in numArr where number > 3 select number;
        //    foreach(int num in findMax)
        //    {
        //        Console.Write(num);
        //    }

        //}


        //public void ConvertStringArrayIntoNumber()
        //{
        //    string[] numbersAsString = new string[] { "3", "1", "2", "4" };

        //    int[] intArray = numbersAsString.Select(int.Parse).ToArray();
        //int[] ints = Array.ConvertAll(strings, int.Parse);

        //    Console.WriteLine(String.Join("," ,intArray));

        //}


        public void FindFactorial()
        {
              Console.WriteLine("Enter the number");
            var numbers = int.Parse(Console.ReadLine());
          
            IEnumerable<int> num = Enumerable.Range(1, numbers);
            int factorial = num.Aggregate((f, s) => f * s);  //((1,2)=>1*2)*((2,3)=>2*3)
           // int result = Enumerable.Range(1, numbers).Aggregate(1, (fact, item) => fact * item);

            Console.WriteLine($"Factorial of {numbers}! = {factorial}");
        }
    }
}
