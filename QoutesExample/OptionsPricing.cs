using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics;

namespace QuotesExample
{
    class OptionsPricing
    {
        OptionsPricing()
        {
            this.normDist = new Accord.Statistics.Distributions.Univariate.NormalDistribution(0, 1);
        }

        OptionsPricing(double sigma, double r, double yield)
        {
            this.sigma = sigma;
            this.r = r;
            this.yield = yield;
        }

        static private double Ln(double x)
        {
            return Math.Log(x, Math.E);
        }

        static private double D1(double S, double K, double T, double sigma, double r)
        {
            return (Ln(S / K) + (r + sigma * sigma / 2) * T) / (sigma * Math.Sqrt(T));
        }

        static private double D2(double S, double K, double T, double sigma, double r)
        {
            return (Ln(S / K) + (r - sigma * sigma / 2) * T) / (sigma * Math.Sqrt(T));
        }

       static public decimal GetBlsCallPrice(double S, double K, double T, double sigma, double r)
        {
            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist = new Accord.Statistics.Distributions.Univariate.NormalDistribution();
            return decimal.Round((decimal)(S * normDist.DistributionFunction(D1(S, K, T, sigma, r)) - K * Math.Exp(-r * T) * normDist.DistributionFunction(D2(S, K, T, sigma, r)))+0.01m, 2, MidpointRounding.AwayFromZero);
        }

        static public decimal GetBlsPutPrice(double S, double K, double T, double sigma, double r)
        {
            Accord.Statistics.Distributions.Univariate.NormalDistribution normDist = new Accord.Statistics.Distributions.Univariate.NormalDistribution();
            return decimal.Round((decimal)(-S * normDist.DistributionFunction(-D1(S, K, T, sigma, r)) + K * Math.Exp(-r * T) * normDist.DistributionFunction(-D2(S, K, T, sigma, r)))+0.01m, 2, MidpointRounding.AwayFromZero);
        }

        private double D1(double S, double K, double T)
        {
            return (Ln(S / K) + (r + sigma * sigma / 2)*T)/(sigma* Math.Sqrt(T));
        }

        private double D2(double S, double K, double T)
        {
            return (Ln(S / K) + (r - sigma * sigma / 2) * T) / (sigma * Math.Sqrt(T));
        }

        private decimal GetBlsCallPrice(double S, double K, double T)
        {
            return (decimal)(S * normDist.DistributionFunction(D1(S, K, T)) - K * Math.Exp(-this.r * T) * normDist.DistributionFunction(D2(S, K, T)));
        }

        private decimal GetBlsPutPrice(double S, double K, double T)
        {
            return (decimal)(-S * normDist.DistributionFunction(-D1(S, K, T)) + K * Math.Exp(-this.r * T) * normDist.DistributionFunction(-D2(S, K, T)));
        }


        private double sigma;
        private double r;
        private double yield;
        private Accord.Statistics.Distributions.Univariate.NormalDistribution normDist;

    }
}
