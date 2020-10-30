using System;
using static System.Console;

namespace Chapter05
{
    class Program
    {
        const char STAR = '*';

        static void Main(string[] args)
        {
            Print("5장 연습문제");
            Print("");

            Print("1번");
            One();
            Print("");

            Print("2번");
            Two();
            Print("");

            Print("3번");
            Three();
            Print("");

            Print("4번");
            Four();
            Print("");
        }

        static void Print(string message)
        {
            WriteLine(message);
        }

        static void One()
        {
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Write(STAR);
                }
                WriteLine();
            }
        }

        static void Two()
        {
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 5 - i; ++j)
                {
                    Write(STAR);
                }
                WriteLine();
            }
        }

        static void Three()
        {
            Print("1번 while문");
            int i = 0, j = 0;

            while (i < 5)
            {
                j = 0;
                while (j <= i)
                {
                    Write(STAR);
                    j++;
                }
                WriteLine();
                i++;
            }

            Print("1번 do while문");
            i = 0;
            do
            {
                j = 0;
                do
                {
                    Write(STAR);
                    j++;
                }
                while (j <= i);
                WriteLine();
                i++;
            }
            while (i < 5);

            Print("2번 while문");
            i = 0;
            while (i < 5)
            {
                j = 0;
                int jCount = 5 - i;
                while (j < jCount)
                {
                    Write(STAR);
                    j++;
                }
                WriteLine();
                i++;
            }

            Print("2번 do while문");
            i = 0;
            do
            {
                j = 0;
                do
                {
                    Write(STAR);
                    j++;
                }
                while (j < 5 - i);
                WriteLine();
                i++;
            }
            while (i < 5);
        }

        static void Four()
        {
            while (true)
            {
                Write("반복 횟수를 입력하세요 : ");
                int limit = int.Parse(ReadLine());
                if (limit <= 0)
                {
                    Write("0보다 작거나 같은 수는 입력할 수 없습니다.");
                    return;
                }

                for (int i = 0; i < limit; ++i)
                {
                    for (int j = 0; j <= i; ++j)
                    {
                        Write(STAR);
                    }
                    WriteLine();
                }
            }
        }
    }
}
