using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class File1
    {
        static void Main()
        {
            string from = "ConsoleApp0928.exe.config";
            string to = "myConfig.txt";
            if (File.Exists(from))//존재여부 확인
            {
                File.Copy(from, to, true); //to 파일이 이미 있는 경우, 오류가 발생할 수 있다.(true는 파일 덮어쓰기을 수락하는 것)

                string to2222 = "C:/Temp2/MyFolder/myConfig_3333.txt";
                if (Directory.Exists("C:/Temp2/MyFolder"))
                {
                    Directory.Delete("C:/Temp2/MyFolder",true);//안에 파일있어도 지워라
                }
                
            }
            foreach(string item in Directory.GetFiles("./"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
