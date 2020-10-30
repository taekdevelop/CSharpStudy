using static System.Console;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4번.

            WriteLine("사각형의 너비를 입력하세요.");
            string width = ReadLine();

            WriteLine("사각형의 높이를 입력하세요.");
            string height = ReadLine();

            double area = double.Parse(width) * double.Parse(height);
            WriteLine("사각형의 넓이는 : " + area);
        }
    }
}
