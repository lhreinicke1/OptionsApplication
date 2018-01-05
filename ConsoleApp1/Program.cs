using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OptionLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Option option = new Option(100, 120, 0.1, 0.1, 1);
            option.CalculatePremium();

            System.Console.WriteLine("The option with spot {0}, strike {1} " +
                "interest rate {2}, volatility {3} and time to expiry {4} years has " +
                "a premium of {5}.", option.Spot, option.Strike, option.Interest,
                option.Volatility, option.Interest, option.Premium);

            option = new Option(100, 80, 0.1, 0.1, 1);
            option.CalculatePremium();

            System.Console.WriteLine("The option with spot {0}, strike {1} " +
                "interest rate {2}, volatility {3} and time to expiry {4} years has " +
                "a premium of {5}.", option.Spot, option.Strike, option.Interest,
                option.Volatility, option.Interest, option.Premium);

            option = new Option(100, -50, 0.1, 0.1, 1);
            option.CalculatePremium();

            System.Console.WriteLine("The option with spot {0}, strike {1} " +
                "interest rate {2}, volatility {3} and time to expiry {4} years has " +
                "a premium of {5}.", option.Spot, option.Strike, option.Interest,
                option.Volatility, option.Interest, option.Premium);

            return;
        }
    }
}
