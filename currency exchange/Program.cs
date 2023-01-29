using System;

namespace currency_exchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float buyUSD = 2.6465f;
            float sellUSD = 2.6372f;
            float buyEUR = 2.8887f;
            float sellEUR = 2.8372f;

            float balanceBYN = 1000;
            float balanceUSD = 100;
            float balanceEUR = 100;

            string operation;
            float amount;

            Console.WriteLine($"Здравствуйте, на вашем счету:\n" + $"BYN - {balanceBYN}\n" + $"USD - {balanceUSD}\n" + $"EUR - {balanceEUR}");
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine($"1 - купить доллары,  курс: {buyUSD}");
            Console.WriteLine($"2 - продать доллары, курс: {sellUSD}");
            Console.WriteLine($"3 - купить евро,     курс: {buyEUR}");
            Console.WriteLine($"4 - продать евро,    курс: {sellEUR}");
            Console.WriteLine($"0 - отмена");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.WriteLine("Введите сумму покупки:");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (balanceBYN >= amount * buyUSD)
                    {
                        balanceUSD += amount;
                        balanceBYN -= amount * buyUSD;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите сумму продажи:");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (balanceUSD >= amount)
                    {
                        balanceUSD -= amount;
                        balanceBYN += amount * sellUSD;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "3":
                    Console.WriteLine("Введите сумму покупки:");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (balanceBYN >= amount * buyEUR)
                    {
                        balanceEUR += amount;
                        balanceBYN -= amount * buyEUR;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "4":
                    Console.WriteLine("Введите сумму продажи:");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (balanceEUR >= amount)
                    {
                        balanceEUR -= amount;
                        balanceBYN += amount * sellEUR;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Вы допустили ошибку при вводе");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("На вашем счету: \n" + $"BYN - {balanceBYN}\n" + $"USD - {balanceUSD}\n" + $"EUR - {balanceEUR}");

        }

    }

}
