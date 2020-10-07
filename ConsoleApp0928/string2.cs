using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp0928
{
    class string2
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); //쓰레기 값이 덜나오고 더 빠르다.
            sb.Clear();  //전체 다 삭제
            sb.Remove(0, sb.Length); //부분 삭제
            string[] days = new string[7] { "일", "월", "화", "수", "목", "금", "토" };

            //일반적인 문자열 연결방법
            //string str = string.Empty;
            //foreach (string temp in days)
            //{
            //    str += temp + ",";
            //}
            //str = str.Substring(0, str.Length - 1); // 마지막 쉼표를 지우기 위해 Length에 -1을 한다.
            //Console.WriteLine(str.TrimEnd(','));//파라미터에 아무것도 안주면 공백을 지워주고 다른 문구가 있으면 그 문구를 지운다.
            //Console.WriteLine(str);
            //다른 방법
            //string result = string.Join(",", days); // 배열에 있는 것을 나열할때 좋다.(static Method) < - > split은 문구를 나눈다.
            //Console.WriteLine(result);
            //다른방법
           
            foreach(string temp in days)
            {
                sb.AppendFormat("{0},",temp);//반복문에 쌓을때,
            }
            //Console.WriteLine(sb.ToString().TrimEnd(','));
            Console.WriteLine(sb.Remove(sb.Length-1,1));



            string fruits = "딸기, 배, 사과, 포도";

            //string[] fruitss = fruits.Split(',');//, 을 기준으로 나누고 그 나눈것을 배열에 저장한다.
            //Console.WriteLine(fruitss.Length);
            //Console.WriteLine(string.Join(",", fruitss));




            //int sum = 0;
            //Console.WriteLine("숫자를 입력해주세요");
            //string input = Console.ReadLine();
            //char[] delimierers = { ',', ' ', '-' };//유저가 무엇으로 나눌 줄 모르기 때문에 여러가지를 넣어준다.
            //string[] nums = input.Split(delimierers);
            //foreach(string num in nums)
            //{
            //    sum += int.Parse(num);
            //}
            //Console.WriteLine(sum);

            fruits = "이것이 JAVA다.";
            Console.WriteLine(fruits.IndexOf("Java"));
            Console.WriteLine(fruits.IndexOf("Java",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(fruits.ToLower().IndexOf("Java".ToLower()));

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"5*{i}={5 * i}");
                //Console.WriteLine("5*{0}={1,2}",i,5*i);
            }

            Console.WriteLine("날짜: {0,-20:D} 판매수량{1,15:N}",DateTime.Now,123456789);

            DateTime Dtstart = DateTime.Now;
            //string txt = "Hello World";
            //for(int i=0; i<3000; i++)
            //{
            //    txt = txt + "1";
            //}
            DateTime dtEnd = DateTime.Now;

            double interval = (dtEnd - Dtstart).TotalMilliseconds;
            Console.WriteLine(interval);
         
        }
    }
}

//숫자-> 오른쪽정렬
//문자열->왼쪽 정렬
//길이가고정->가운데
//길이가 들쑥날쑥->왼쪽