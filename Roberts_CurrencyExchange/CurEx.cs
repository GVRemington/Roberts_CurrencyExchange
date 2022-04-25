using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_CurrencyExchange
{
  public static class CurEx
    {
        public static double _USD;
        public static double GBP;
        public static double CAN;
        public static double EURO;


        public static double USD_GBP(double USD) 
        {
            GBP = USD * 0.72523;
            
            return Math.Round(GBP,2);
        }
        public static double USD_CAN(double USD)
        {
            CAN = USD * 1.25472;
            return Math.Round(CAN,2);
        }
        public static double USD_EURO(double USD)
        {
            EURO = USD * 0.83572;
            return Math.Round(EURO,2);
        }
       public static double GBP_USD(double GBP)
        {
            _USD = GBP * 1.37887;
            return Math.Round(_USD,2);
        }
       public static double GBP_CAN(double GBP)
        {
            CAN = GBP * 1.72947;
            return Math.Round(CAN,2);
        }
        public static double GBP_EURO(double GBP)
        {
            EURO = GBP * 1.15195;
            return Math.Round(EURO,2);
        }
        public static double CAN_USD(double CAN)
        {
            _USD = CAN * 0.79728;
            return Math.Round(_USD,2);
        }
        public static double CAN_GBP(double CAN)
        {
            GBP = CAN * 0.57848;
            return Math.Round(GBP,2);
        }
        public static double CAN_EURO(double CAN)
        {
            EURO = CAN * 0.66645;
            return Math.Round(EURO,2);
        }
        public static double EURO_USD(double EURO)
        {
            double _USD = EURO * 1.19648;
           
            return Math.Round(_USD,2);
        }
       public static double EURO_GBP(double EURO)
        {
            double GBP = EURO * 0.86826;
            return Math.Round(GBP,2);
        }
       public static double EURO_CAN(double EURO)
        {
            double CAN = EURO * 1.50040;
            return Math.Round(CAN,2);
        }
    }
}
