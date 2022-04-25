using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CurrencyExchange
{
    class ExMon    
    {
        private int i;
        private double USD;
       
        public int setExCount(int newI)
        {
           i = i+newI;  
            return i;
        }
        public double fcToUSD(double newUSD)
        { 
            USD = USD + newUSD;
            return USD;
        }
        public int ExCount
            { 
                get { return i; }
            }
        public double GetUSD
            { 
                get { return Math.Round(USD,2); } 
            }
    }
}
