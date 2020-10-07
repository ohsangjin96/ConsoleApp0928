using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp0928
{
    class encoding1
    {
        static void Main()
        {
            string str = "Hello 안녕";
            Console.WriteLine("기본문중: " + str);

            //UTF8 형식으로 인코딩한 배열로 변환
            byte[] result1 = Encoding.UTF8.GetBytes(str);
            PrintByteArray(result1);
            Console.WriteLine(Encoding.UTF8.GetString(result1));

            byte[] result2 = Encoding.Unicode.GetBytes(str);
            PrintByteArray(result2);
            Console.WriteLine(Encoding.Unicode.GetString(result2));
          

        }

        private static void PrintByteArray(byte[] result2)
        {
            foreach (byte b in result2)
            {
                Console.Write($" {b}, ");

            }
            Console.WriteLine();
        }
    }
}
