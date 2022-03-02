using System;

namespace _4sem_lb1_darts_
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                score = rand.Next(1,20);
                Singleton.Instance.setScore(score);
                Console.WriteLine("Игрок {0} получил {1} очков!", i%2, score);
            }

            Console.WriteLine("\n\nУ игрока №0 - {0} очков\n У игрока №1 - {1} очков\n",Singleton.Instance.sumUp(0),Singleton.Instance.sumUp(1));
            if (Singleton.Instance.sumUp(0) > Singleton.Instance.sumUp(1))
            {
                Console.WriteLine("Выиграл игрок №0!");
            }
            else if (Singleton.Instance.sumUp(0) == Singleton.Instance.sumUp(1))
            {
                Console.WriteLine("Ничья!");
            }
            else
            {
                Console.WriteLine("Выиграл игрок №1!");
            }
        }
    }
}
