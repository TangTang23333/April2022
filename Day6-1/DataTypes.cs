using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_1
{
    public static class DataTypes
    {

        public static void PrintMessage()
        {

            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "sbyte", sizeof(sbyte), sbyte.MaxValue, sbyte.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "byte", sizeof(byte), byte.MaxValue, byte.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "short", sizeof(short), short.MaxValue, short.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "ushort", sizeof(ushort), short.MaxValue, ushort.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "int", sizeof(int), int.MaxValue, int.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "uint", sizeof(uint), uint.MaxValue, uint.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "long", sizeof(long), long.MaxValue, long.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "ulong", sizeof(ulong), ulong.MaxValue, ulong.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "float", sizeof(float), float.MaxValue, float.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "double", sizeof(double), double.MaxValue, double.MinValue));
            Console.WriteLine(String.Format("name : {0,-10}, byte size: {1,-6},  Max value : {2, -35}, Min Value : {3, -35}", "decimal", sizeof(decimal), decimal.MaxValue, decimal.MinValue));


        }
    }
}
