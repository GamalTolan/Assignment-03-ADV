using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_03_ADV.Book;

namespace Assignment_03_ADV
{
    public delegate int StringMethodDelegate(string str);
    public delegate bool ConditionDelegate(int x);

    #region EX01(part 01)
    class stringMethods
    {
        public static int GetCountOfUpperCase(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public static int GetCountOfLowerCase(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
    #endregion

    #region EX03(part 01)
    class MethodCondition
    { 
        public static bool isOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }
    }
    #endregion
    internal class Program
    {
        #region EX03 (part 01)
        public static List<int> FindElement(List<int> numbers, ConditionDelegate condition)
        {
            List<int> result = new List<int>();
            foreach(int number in numbers)
            {
                if (condition(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Part 01

            //EX01
            //StringMethodDelegate stringMethodDelegate;
            // stringMethodDelegate = stringMethods.GetCountOfUpperCase;
            //int result = stringMethodDelegate.Invoke("Gamal TolAn");
            //Console.WriteLine(result);

            //EX02
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //SortingAlgorithm.BubbleSort(arr);
            // Console.WriteLine(string.Join(",",arr));
            //CompareTypesDelegate compare = comparetypes.CompareGraterThan;
            //SortingAlgorithm.BubbleSort(arr, compare);
            //Console.WriteLine(string.Join(",", arr));
            //CompareTypesDelegate _compare = comparetypes.CompareLessThan;
            //SortingAlgorithm.BubbleSort(arr, _compare);
            //Console.WriteLine(string.Join(",", arr));

            //EX03
            //List<int>numbers= Enumerable.Range(1, 100).ToList();
            //List<int> result = FindElement(numbers, MethodCondition.isOdd);
            //Console.WriteLine(string.Join(",", result));


            #endregion


            #region Part 02

            //List<Book> bookList = new List<Book>
            //{
            //    new Book("123456", "C#", new string[] { "Gamal" }, DateTime.Now, 20m),
            //    new Book("7891011", "AI", new string[] { "Mona" }, DateTime.Now, 15m),
            //};

            //LibraryEngine.ProcessBooks(bookList, B => B.ISBN);
            //LibraryEngine.ProcessBooks(bookList, B => B.Title);
            //LibraryEngine.ProcessBooks(bookList, B => string.Join(",", B.Authors));



            //LibraryEngine.ProcessBooks(bookList, B => B.PublicationDate.ToShortDateString());

            #endregion
            #region Part 03

            ListMethods numbers = new ListMethods();
            numbers.Add(1);
            numbers.Add(10);
            numbers.Add(18);
            numbers.Add(20);

            Console.WriteLine(numbers);
            //Exisit
            Console.WriteLine(numbers.exisit(1));
            //Find
            Console.WriteLine(numbers.find(x => x % 5 == 0));
            //FindAll
            List<int> result = numbers.findall(x => x % 5 == 0);
            Console.WriteLine(string.Join(",", result));
            //FindIndex
            Console.WriteLine(numbers.findindex(1));
            //FindLast
            Console.WriteLine(numbers.findlast(x => x % 5 == 0));
            //FindLastIndex
            Console.WriteLine(numbers.findlastindex(x => x % 5 == 0));

            //Forech??

            //TrueForAll
            Console.WriteLine(numbers.TrueForAll(x => x % 5 == 0));


            #endregion
        }
    }
}
