using System;
using System.Collections.Generic;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
  /// <summary>
  /// foreach
  /// 목표: 컬렉션 또는 배열의 모든 요소를 순회하면서 작업을 수행한다.
  /// 
  /// foreach 반복문의 기본 구조는 다음과 같습니다:
  /// 
  /// 1. foreach 키워드 다음에 소괄호 () 안에 '변수 in 컬렉션' 형식으로 작성됩니다.
  ///    예제에서는 `foreach (string fruit in fruits)`가 해당됩니다.
  ///
  /// 2. 중괄호 {} 안에는 컬렉션의 각 요소에 대해 반복적으로 실행될 코드를 작성합니다.
  ///    이 블록은 컬렉션의 모든 요소가 한 번씩 처리될 때까지 반복 실행됩니다.
  /// 
  /// 3. foreach 문은 주로 배열이나 리스트 같은 컬렉션의 모든 요소를 
  ///    하나씩 처리할 때 사용됩니다. 
  ///    반복문 내에서 컬렉션의 요소를 수정할 수 없으므로, 
  ///    읽기 전용 작업에 적합합니다.
  ///
  /// foreach 반복문은 다음과 같은 상황에서 특히 유용합니다:
  /// - 배열이나 리스트의 모든 요소를 순회할 때
  /// - 컬렉션의 요소를 읽기 전용으로 처리할 때
  /// 
  /// foreach 반복문을 사용하면 코드가 간결하고 명확해지며,
  /// 특정 컬렉션의 요소를 처리하는 작업을 매우 효율적으로 수행할 수 있습니다.
  /// 이 예제를 직접 실행해보고, 다양한 컬렉션에 foreach 문을 적용해 보세요.
  /// </summary>
  public class Class2
  {
    public void Run()
    {
      // 배열 순회 예제
      string[] fruits = { "Apple", "Banana", "Cherry" };
      Console.WriteLine("Iterating over an array:");
      foreach (string fruit in fruits)
      {
        Console.WriteLine($"Fruit: {fruit}");
      }

      // 리스트 순회 예제
      List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
      Console.WriteLine("\nIterating over a list:");
      foreach (int number in numbers)
      {
        Console.WriteLine($"Number: {number}");
      }

      // 딕셔너리 순회 예제
      Dictionary<string, int> nameAges = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };
      Console.WriteLine("\nIterating over a dictionary:");
      foreach (KeyValuePair<string, int> entry in nameAges)
      {
        Console.WriteLine($"{entry.Key} is {entry.Value} years old.");
      }
    }
  }
}

