using System;

namespace methodOverloadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Add(1, 2);
                Add(2,3,5);
            Add(1,2,k);
        }
        public static void Add(int FN,int SN)
        {
            Console.WriteLine("sum is {0}", FN+SN);
        }
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("sum is {0}", FN + SN +TN);
        }

        public static void Add(int FN, int SN, out int sum)
        {
            sum = FN + SN ;
            Console.WriteLine("sum is {0}",sum );
        }
    }
}
