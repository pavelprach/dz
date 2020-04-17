using System;
using static System.Console;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mark = new int[10];
            var rand = new Random();
            int variant;
            for (int i = 0; i < 10; i++)
            {
                mark[i] = rand.Next(1, 13);
            }
        link1:
            WriteLine("нажмите 1 чтобы вывести оценки \n нажмите 2 чтобы править оценку \n нажмите 3 чтобы узнать можете ли вы получить стипендию");
            variant = Convert.ToInt32(ReadLine());
            
            switch (variant)
            {
                case 1:
                    for (int i = 0; i < 10; i++)
                    {
                        WriteLine($"mark № {i + 1} " + mark[i]);
                    }
                    break;
                case 2:
                    WriteLine("введите номер оценки");
                    int tempidmark;
                    tempidmark = Convert.ToInt32(ReadLine());
                    tempidmark -=1;
                    WriteLine("введите новую оценку");
                    int tempmark;
                    tempmark = Convert.ToInt32(ReadLine());
                    mark[tempidmark] = tempmark;
                    break;
                case 3:
                   
                    int summmark = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        summmark = summmark + mark[i];
                    }
                    bool grand = false;
                    double srball = summmark / 10.0;
                    if (srball > 10.7)
                    {
                        grand = true;
                    }
                    if (grand == true)
                        WriteLine("вы можете получить стипендию");
                    else
                        WriteLine("вы не можете получить стипендию");
                    break;
            }
            goto link1;
        }
    }
}