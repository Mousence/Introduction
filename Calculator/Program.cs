using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("Введите выражение: ");
            string expression = "22+33*4-5/2+3";
            expression = expression.Replace(".",",");
            String[] number = expression.Split('+', '-', '/', '*');

            //double a = Convert.ToDouble(number[0]);
            //double b = Convert.ToDouble(number[1]);
            //if (expression.Contains("+")) Console.WriteLine($"{a} + {b} = {a + b}");
            //else if (expression.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
            //else if (expression.Contains("/")) Console.WriteLine($"{a} / {b} = {a / b}");
            //else if (expression.Contains("*")) Console.WriteLine($"{a} * {b} = {a * b}");

            String[] operations = expression.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', ',');
            operations = operations.Where(val => val != "").ToArray();
            //foreach (string i in number)Console.Write(i+'\t'); Console.WriteLine();
            //foreach (string i in operations) Console.Write(i+"\t"); Console.WriteLine();
            double[] values = new double[number.Length];
            for(int i = 0;i<number.Length;i++)
            {
                values[i] = Convert.ToDouble(number[i]);
            }
             foreach (double i in values) Console.Write(i+'\t'); Console.WriteLine();
             foreach (string i in operations) Console.Write(i+"\t"); Console.WriteLine();
            do
            {
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operations[i] == "*") values[i] *= values[i + 1];
                    if (operations[i] == "/") values[i] /= values[i + 1];
                    if (operations[i] == "*" || operations[i] == "/") {
                        for (int j = i + 1; j < operations.Length; j++)
                        {
                            values[j] = values[j + 1];
                            operations[j - 1] = operations[j];
                        }
                        values[values.Length - 1] = 0;
                        operations[operations.Length - 1] = null;
                        i--;
                    }
                }
                
            } while (operations.Contains("*") || operations.Contains("/"));
            do {
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operations[i] == "-") values[i] -= values[i + 1];
                    if (operations[i] == "+") values[i] += values[i + 1];
                    if (operations[i] == "+" || operations[i] == "-")
                        for (int j = i + 1; j < operations.Length; j++)
                        {
                            values[j] = values[j + 1];
                            operations[j - 1] = operations[j];
                        }
                    values[values.Length - 1] = 0;
                    operations[operations.Length - 1] = null;
                    i--;
                }
                //if (operations[1] == null) operations[0] = null;
            } while (operations.Contains("+") || operations.Contains("-"));

            foreach (double i in values) Console.Write(i + '\t'); Console.WriteLine();
            foreach (string i in operations) Console.Write(i + "\t"); Console.WriteLine();

        }
    }
}
