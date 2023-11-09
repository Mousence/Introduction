//#define CONVERSION
//#define COUNT_SHOP
//#define COUNT_SHOP2
#define COUNT_TRAVEL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CONVERSION
            decimal money;
            Console.WriteLine("Преобразование числа в денежный формат.");
            Console.Write("Введите число(грн.) -> "); money = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"{money} грн, это {(int)money} грн, {(money - (int)money) * 100 } коп");
#endif
#if COUNT_SHOP
            Console.WriteLine("Вычисление стоймости покупки.");
            Console.WriteLine("Введите исходные данные:");
            Console.Write("Цена тетради(грн.) -> "); decimal TextBookPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Количество тетрадей -> "); int TextBookCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена карандаша(грн.) -> "); decimal PencelPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Количество карандашей -> "); int PencelCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {TextBookCount*TextBookPrice + PencelPrice*PencelCount}");
#endif
#if COUNT_SHOP2
            Console.WriteLine("Вычисление стоймости покупки.");
            Console.WriteLine("Введите исходные данные:");
            Console.Write("Цена тетради(грн.) -> "); decimal TextBookPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Цена обложки(грн.) -> "); decimal BlanketPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Количество наборов -> "); int Count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {Count * TextBookPrice + BlanketPrice * Count}");
#endif
#if COUNT_TRAVEL
            Console.WriteLine("Вычисление поездки на дачу и обратно.");
            Console.Write("Растояние до дачи(км.) -> "); float KM = Convert.ToSingle(Console.ReadLine());
            Console.Write("Расход бензина (л. на 100 км пробега) -> "); float consumption = Convert.ToSingle(Console.ReadLine());
            Console.Write("Цена бензина за л.(грн.): "); float Price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Поездка на дачу обойдется в {consumption/100*KM*Price} грн."); 
#endif
        }
    }
}
