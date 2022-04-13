using System;
using System.Collections.Generic;

namespace _4sem_lb1_darts_
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instanceHolder =
            new Lazy<Singleton>(() => new Singleton());

        private Random rand = new Random();

        private List<int> score = new List<int>(); //List с результатами всех раундов

        private Singleton()
        {}

        public void gameField()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Игрок {0} получил {1} очков!", i%2 +1, hit());
            }
            Console.WriteLine("\n\nУ игрока №1 - {0} очков\n У игрока №2 - {1} очков\n",sumUp(0),sumUp(1));
            if (sumUp(0) > sumUp(1)) //Проверка, кто победил
            {
                Console.WriteLine("Выиграл игрок №1!");
            }
            else if (sumUp(0) == Singleton.Instance.sumUp(1))
            {
                Console.WriteLine("Ничья!");
            }
            else
            {
                Console.WriteLine("Выиграл игрок №2!");
            }
        }

        private int hit()
        {
            int score;
            score = rand.Next(1,20);
            this.score.Add(score);
            return score;
        }

        private int sumUp(int user) //Суммирование результатов игрока
        {
            int sum=0;
            for (int i = user; i < score.Count; i+=2)
            {
                sum += score[i];
            }

            return sum;
        }

        public static Singleton Instance
        {
            get { return instanceHolder.Value; }
        }
    }
}



