using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"bool: {sizeof(bool)}, values: {true}, of {false}");
            Console.WriteLine($"char: {sizeof(char)}"); // unicode

            Console.WriteLine($"short: {sizeof(short)} байт в памяти, диапазон значений: {short.MinValue} ... {short.MaxValue}");

            Console.WriteLine($"ushort: {sizeof(ushort)} байт в памяти, диапазон значений: {ushort.MinValue} ... {ushort.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(float)} байт в памяти, диапазон значений: {float.MinValue} ... {float.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(double)} байт в памяти, диапазон значений: {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(decimal)} байт в памяти, диапазон значений: {decimal.MinValue} ... {decimal.MaxValue}");

            Console.WriteLine('+'.GetType());
            Console.WriteLine(5.GetType());
            Console.WriteLine(5.5.GetType());
            Console.WriteLine(5.5f.GetType()); // float
            Console.WriteLine(5.5m.GetType());
        }
    }
}
