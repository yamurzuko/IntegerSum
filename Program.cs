using System;

namespace IntegerSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfensayılarınızın girin: ");
            string sayilar = Console.ReadLine();
            IkiliToplam(sayilar);
        }
        public static void IkiliToplam(string value)
        {
            int result = 0;
            string[] arr = value.Split(" ");

            for (int i = 0; i < arr.Length; i+=2)
            {   
                if (arr[i] == arr[i+1])
                {
                    result = Convert.ToInt32(arr[i])  * Convert.ToInt32(arr[i+1]);
                    Console.Write("{0} ",result*result);
                }
                else
                {
                    result = Convert.ToInt32(arr[i]) + Convert.ToInt32(arr[i+1]);
                    Console.Write("{0} ",result);
                }
            }
        }
    }
}