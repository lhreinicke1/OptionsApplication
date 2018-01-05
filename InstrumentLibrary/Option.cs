using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.Distributions;

namespace OptionLibrary
{
    public class Option
    {
        public double Premium { get; protected set; }
        public double D1 { get; protected set; }
        public double D2 { get; protected set; }

        public double Spot { get; set; }
        public double Strike { get; set; }
        public double Interest { get; set; }
        public double Volatility { get; set; }
        public double Time { get; set; }

        public Option():
            this(0.0, 0.0, 0.0, 0.0, 0.0)
        {
        }

        public Option(double assetPrice, double strike, double volatility, 
            double interest, double time)
        {
            Spot = assetPrice;
            Strike = strike;
            Volatility = volatility;
            Interest = interest;
            Time = time;
        }

        public void CalculateD1()
        {
            if (Time <= 0 || Volatility <= 0 || Strike <= 0 || Spot <= 0)
            {
                D1 = 0;
            }
            else
            {
                D1 = (Math.Log(Spot / Strike) + (Interest + Volatility * Volatility / 2.0) * Time) /
                    (Volatility * Math.Sqrt(Time));
            }
        }

        public void CalculateD2()
        {
            if (Time <= 0 || Volatility <= 0 || Strike <= 0 || Spot <= 0)
            {
                D2 = 0;
            }
            else
            {
                D2 = (Math.Log(Spot / Strike) + (Interest - Volatility * Volatility / 2.0) * Time) /
                    (Volatility * Math.Sqrt(Time));
            }
        }

        public void CalculatePremium()
        {
            CalculateD1();
            CalculateD2();

            if (D1 == 0 || D2 == 0)
            {
                Premium = Math.Max(Strike - Spot, 0);
            }
            else
            {
                Premium = Spot * Normal.CDF(0, 1, D1) -
                        Math.Exp(-Interest * Time) * Strike * Normal.CDF(0, 1, D2);
            }
        }
    }
}
