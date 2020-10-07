using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0928
{
    class FileInfo1
    {
        static void Main()
        {
            string from = "ConsoleApp0928.exe.config";
            string to = "myConfig.txt";

            FileInfo fromFile = new FileInfo(from);

            if (fromFile.Exists)//존재여부 확인
            {

                FileInfo toFile = fromFile.CopyTo(to, true);//to 파일이 이미 있는 경우, 오류가 발생할 수 있다.(true는 파일 덮어쓰기을 수락하는 것)

                string to2222 = "C:/Temp2/MyFolder/myConfig_3333.txt";
              
                fromFile.MoveTo(to);
            }

        }
    }
}
