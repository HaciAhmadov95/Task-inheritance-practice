//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;





//namespace ConsoleApp1
//{
//    internal class CustomMath
//    {
//        public int SumOfOddNumbers(int[] array)
//        {

//            return array.Where(m => m % 2 == 1).Sum(m=>m);


//        }


//        public string CheckNumberOddOrEven(int number)
//        {
//            //if (number % 2 == 0)

//            //    return "Even";

//            //return "Odd";

//            return number % 2 == 0 ? "Even" : "Odd";
//        }


//        public double FindEvenNumbersPow(int[] numbers, int pow) => Math.Pow(numbers.Where(m => m % 2 == 0).Sum(m => m),pow);
        
            
             
//        public int Factorial (int num)
//        {
//            int result = 1;
//            for (int i = 1; i <= num; i++)
//            {
//                result *= i;
//            }
//            return result;
//        }


//    }
//}
