using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// 오버로딩
    /// </summary>
    public class Class11
    {
        public void Run()
        {
            // 배열 예제
            string[] fruitsArray = { "Apple", "Banana", "Cherry" };
            Console.WriteLine("Fruits in the array:");
            foreach (string fruit in fruitsArray)
            {
                Console.WriteLine(fruit);
            }

            // 리스트 예제
            List<string> fruitsList = new List<string> { "Mango", "Orange", "Grapes" };
            Console.WriteLine("\nFruits in the list:");
            foreach (string fruit in fruitsList)
            {
                Console.WriteLine(fruit);
            }

            // 딕셔너리 예제
            Dictionary<string, string> fruitsDict = new Dictionary<string, string>
            {
                { "red", "Apple" },
                { "yellow", "Banana" },
                { "purple", "Grapes" }
            };
            Console.WriteLine("\nFruits in the dictionary:");
            foreach (KeyValuePair<string, string> entry in fruitsDict)
            {
                Console.WriteLine($"Color: {entry.Key}, Fruit: {entry.Value}");
            }
        }
    }
}