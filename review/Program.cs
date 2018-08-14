using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    class Program
    {

        static void Main(string[] args)
        {
            float[] numbers = new float[10];
            
            Console.WriteLine("Welcome to the C# practice program");
            numbers = GetData();
            ProcessData(numbers);
        }
        public static float[] GetData()
        {
            float[] numbers = new float[10];
            string again, input;
            int count = 0;
            
            do
            {
                Console.Write("Enter a floating point value: ");
                input = Console.ReadLine();
                numbers[count] = float.Parse(input);
                count++;
                Console.WriteLine("Would you like to enter another Value (Y or N)?");
                again = Console.ReadLine();

            } while ((again.Equals("y") || again.Equals("Y"))); 
           
            return numbers;
        }

        public static void ProcessData(float[] numbers)
        {
            float[] myArray = numbers;
            
            float total = 0;
            float average, min=float.MaxValue, max=float.MinValue;

            //total
            for (int i = 0; i < myArray.Length; i++)
            {
                total += myArray[i];

            }

            //average
            float count = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != 0)
                {
                    count++;
                }
            }
            average = (total / count);
            
            //min
            for(int i=0; i<myArray.Length;i++)
            {
                if (myArray[i] != 0)
                {
                    if (myArray[i] < min)
                    {
                        min = myArray[i];
                    }
                }
            }

            //max
            for(int i=0; i<myArray.Length;i++)
            {
                if(myArray[i]>max)
                {
                    max=myArray[i];
                }

            }

            displayResults(total, average, max, min);

        }

        public static void displayResults(float total, float average, float max, float min)
        {
 	   for(int i=0; i<myArray.Length;i++)
           {
		int count=1;
                if(myArray[i]!=0)
                {
                    Console.WriteLine("Value "+count+ " = "+myArray[i];
		    count++;
                }

            }
            Console.WriteLine("Sum of all values = " + total);
            Console.WriteLine("Average of all values = " + average);
            Console.WriteLine("Largest value = " + max);
            Console.WriteLine("Lowest value = " + min);
        }
    }
}