using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    internal class CenturyConversion
    {
        
        public static int CenturyToYear(int cent)
        {
            return cent * 100;
        }

        public static int CenturyToDays(int cent)
        {
            return cent * 36524;
        }

        public static int CenturyToHours(int cent)
        {
            return cent * 876576;
        }

        public static int CenturyToMins(int cent)
        {
            return cent * 52594560;
        }

        public static long CenturyToSeconds(int cent)
        {
            return cent * 3155673600;
        }

        public static long CenturyToMilliSeconds(int cent)
        {
            return cent * 3155673600000;
        }

        public static long CenturyToMicroSeconds(int cent)
        {
            return cent * 3155673600000000;
        }

        public static long CenturyToNanoSeconds(int cent)
        {
            
            return cent * 3155673600000000000;
        }

        public static int GetCent(int cent)
        {
            return cent;
        }

        public static void GetAllConversion(int cent)
        {

            Console.WriteLine(
                @$"{cent} centuries 
            = {CenturyToYear(cent)} years 
            = { CenturyToDays(cent)} Days 
            = { CenturyToHours(cent)} Hours
            = { CenturyToMins(cent)} Minutes 
            = { CenturyToSeconds(cent)} Seconds 
            = { CenturyToMilliSeconds(cent)} Milliseconds 
            = { CenturyToMicroSeconds(cent)} MicroSeconds
            = { (ulong) CenturyToNanoSeconds(cent)} NanoSeconds
            ");
        }
    }
}
