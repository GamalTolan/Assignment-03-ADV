using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_ADV
{
    public class ListMethods
    {
        List<int> numbers = new List<int>();

        public void Add(int number)
        {
            numbers.Add(number);
        }
        public override string ToString()
        {
            return string.Join(",", numbers);
        }
        public bool exisit(int number)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        public int find(Predicate<int> match)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (match(numbers[i]))
                {
                    return numbers[i];
                }
            }
            return -1;
        }

        public List<int> findall(Predicate<int> match)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (match(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }


        public int findindex(int number)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        public int findlast(Predicate<int> match)
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (match(numbers[i]))
                {
                    return numbers[i];
                }
            }
            return -1;
        }

        public int findlastindex(Predicate<int> match)
        {
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (match(numbers[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TrueForAll(Predicate<int> match)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!match(numbers[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }

}
