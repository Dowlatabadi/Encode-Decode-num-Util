using System;

namespace Encode_Decode
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                var x = CodeHelper.Encode(i, 4);
                Console.WriteLine($"{i} is encoded to {x} and decode result is {CodeHelper.Decode(x, 4)}");
            }
           
        }
    }
}
