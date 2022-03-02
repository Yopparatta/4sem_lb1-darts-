using System;
using System.Collections.Generic;

namespace _4sem_lb1_darts_
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instanceHolder =
            new Lazy<Singleton>(() => new Singleton());

        private List<int> score = new List<int>();

        private Singleton()
        {}

        public void setScore(int points)
        {
            score.Add(points);
        }

        public int sumUp(int user)
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