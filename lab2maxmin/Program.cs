using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            maxmin();
        }
        static void maxmin()
        {
            FileStream fs = new FileStream(@"D:\PT2016\int.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);//we wrote the path where out txt is located
            StreamReader sr = new StreamReader(fs);//reads the inputs on int.txt
            string line = sr.ReadLine();//reads as a string
            string[] arr = line.Split(',');//identifying the number, when sees the comma understand that it is the one input
            int max, min;//initilizing the max and min
            max = int.Parse(arr[0]);//converting string to int
            min = int.Parse(arr[0]); 
            int x;
            for (int i = 0; i < arr.Length; ++i)//runs from the start to the end
            {
                x = int.Parse(arr[i]);//converting or changing the type
                if (min >x) min = x;
                if (max <x) max = x;
            }
            Console.WriteLine("The minimum is: {0}", min);//outputs result
            Console.WriteLine("The maximum is: {0}", max);
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
