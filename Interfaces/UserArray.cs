using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class UserArray : ICalc, ICalc2
    {
        public List<int> Arr { get; set; }

        public UserArray()
        {
            Arr = new List<int>();
        }

        public void fillRand(int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                Arr.Add(random.Next(0, 20));
            }
        }

        public int NumberOfLess(int value)
        {
            int count = 0;
            foreach(int numbers in Arr)
            {
                if(numbers < value)
                {
                    count++;
                }
            }
            return count;
        }

        public int NumberOfGreater(int value)
        {
            int count = 0;
            foreach (int numbers in Arr)
            {
                if (numbers > value)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(int numbers in Arr)
            {
                stringBuilder.Append($"{numbers} ");
            }
            return $"[ {stringBuilder}]";
        }

        public int CountDistinct()
        {
            List<int> temp = new List<int>();
            foreach(int numbers in Arr)
            {
                if (!(temp.Contains(numbers)))
                {
                    temp.Add(numbers);
                }
            }
            return temp.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach(int numbers in Arr)
            {
                if(numbers == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
