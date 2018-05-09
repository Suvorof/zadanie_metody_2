using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_metody_2
{
    class Program
    {
        static decimal MoneyConverter(decimal a, decimal b, decimal result)
        {
            result = a * b;
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Введите валюту которую хотите поменять на рубли: Доллар США, Евро, Английский фунт, Казахский тенге ");
            string currency = Console.ReadLine();



            switch (currency)
            {
                case "Доллар США":
                    Console.WriteLine("Введите сумму долларов США, которые хотите поменять");
                    string x = Console.ReadLine();
                    decimal sumCurrency = Convert.ToDecimal(x);

                    Console.WriteLine("Введите курс доллара США по которому произойдёт обмен");
                    string y = Console.ReadLine();
                    decimal curExchangeRate = Convert.ToDecimal(y);

                    decimal result = sumCurrency * curExchangeRate;
                    MoneyConverter(sumCurrency, curExchangeRate, result);
                    Console.WriteLine("Сумма рублей полученных полсе операции обмена " + result);
                    Console.ReadKey();
                    break;

            }

            switch (currency)
            {
                case "Английский фунт":
                    Console.WriteLine("Введите сумму английских фунтов, которые хотите поменять");
                    string x = Console.ReadLine();
                    decimal sumCurrency = Convert.ToDecimal(x);

                    Console.WriteLine("Введите курс английских фунтов по которому произойдёт обмен");
                    string y = Console.ReadLine();
                    decimal curExchangeRate = Convert.ToDecimal(y);

                    decimal result = sumCurrency * curExchangeRate;
                    MoneyConverter(sumCurrency, curExchangeRate, result);
                    Console.WriteLine("Сумма рублей полученных полсе операции обмена " + result);
                    Console.ReadKey();
                    break;
            }

            switch (currency)
            {
                case "Евро":
                Console.WriteLine("Введите сумму евро, которые хотите поменять");
                string x = Console.ReadLine();
                decimal sumCurrency = Convert.ToDecimal(x);

                Console.WriteLine("Введите курс евро по которому произойдёт обмен");
                string y = Console.ReadLine();
                decimal curExchangeRate = Convert.ToDecimal(y);

                decimal result = sumCurrency * curExchangeRate;
                MoneyConverter(sumCurrency, curExchangeRate, result);
                Console.WriteLine("Сумма рублей полученных полсе операции обмена " + result);
                Console.ReadKey();
                break;
            }

            switch (currency)
            {
                case "Казахский тенге":
                    Console.WriteLine("Введите сумму казахских тенге, которые хотите поменять");
                    string x = Console.ReadLine();
                    decimal sumCurrency = Convert.ToDecimal(x);

                    Console.WriteLine("Введите курс казахского тенге по которому произойдёт обмен");
                    string y = Console.ReadLine();
                    decimal curExchangeRate = Convert.ToDecimal(y);

                    decimal result = sumCurrency * curExchangeRate;
                    MoneyConverter(sumCurrency, curExchangeRate, result);
                    Console.WriteLine("Сумма рублей полученных полсе операции обмена " + result);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
