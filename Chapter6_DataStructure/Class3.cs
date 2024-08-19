using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
    /// <summary>
    /// List
    /// 목표: List를 사용하여 동적으로 크기가 조정되는 배열을 생성하고 관리하는 방법을 학습한다.
    /// 
    /// List<T>는 C#에서 제공하는 제네릭 컬렉션의 일종으로, 
    /// 동적으로 크기가 조정되는 배열을 생성하고 관리할 수 있습니다. 
    /// System.Collections.Generic 네임스페이스에 정의되어 있으며, 
    /// 배열과 유사하게 인덱스를 통해 각 요소에 접근할 수 있지만, 
    /// 크기가 고정되어 있지 않아 요소를 추가하거나 제거할 때 자동으로 크기가 조절됩니다.
    /// 
    /// List의 주요 특징:
    /// 1. 동적 크기 조정: List<T>는 요소를 추가하거나 제거할 때 내부 배열의 크기를 자동으로 조정합니다. 
    ///    이로 인해 사용자는 컬렉션의 크기를 걱정하지 않고 요소를 관리할 수 있습니다.
    /// 
    /// 2. 제네릭: List<T>는 제네릭을 사용하여 다양한 타입의 객체를 저장할 수 있습니다. 
    ///    여기서 T는 리스트에 저장될 요소의 타입을 나타냅니다.
    /// 
    /// 3. 인덱스 접근: 배열과 마찬가지로 List<T>의 요소에는 인덱스를 통해 접근할 수 있으며, 인덱스는 0부터 시작합니다.
    /// 
    /// 4. 다양한 메서드 지원: List<T> 클래스는 요소를 추가, 삭제, 검색, 정렬하는 등 다양한 메서드를 제공합니다.
    /// 
    /// 주요 메서드 및 속성:
    /// - Add(T item): 리스트의 끝에 새 요소를 추가합니다.
    /// - Remove(T item): 리스트에서 첫 번째로 일치하는 요소를 제거합니다.
    /// - RemoveAt(int index): 지정된 인덱스에 있는 요소를 제거합니다.
    /// - Insert(int index, T item): 지정된 인덱스에 요소를 삽입합니다.
    /// - Clear(): 리스트의 모든 요소를 제거합니다.
    /// - Count: 리스트에 있는 요소의 수를 반환합니다.
    /// - Contains(T item): 리스트에 특정 요소가 포함되어 있는지 확인합니다.
    /// - Sort(): 리스트의 요소를 정렬합니다.
    /// </summary>
    public class Class3
    {
        public void Run()
        {
            // 문자열 리스트 생성
            List<string> fruits = new List<string>();

            // 요소 추가
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");

            // 인덱스를 통한 요소 접근
            Console.WriteLine($"Second fruit: {fruits[1]}"); // 출력: Banana

            // 리스트의 요소 순회
            Console.WriteLine("Listing all fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // 요소 제거
            fruits.Remove("Banana"); // "Banana" 요소 제거
            Console.WriteLine("After removing 'Banana':");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // 요소 삽입
            fruits.Insert(1, "Mango"); // 인덱스 1에 "Mango" 삽입
            Console.WriteLine("After inserting 'Mango':");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // 리스트 크기 확인
            Console.WriteLine($"Number of fruits: {fruits.Count}"); // 출력: 현재 리스트의 요소 수

            // 리스트의 특정 요소 포함 여부 확인
            Console.WriteLine($"Contains 'Apple': {fruits.Contains("Apple")}"); // "Apple"이 리스트에 있는지 확인

            // 리스트 정렬
            fruits.Sort();
            Console.WriteLine("Fruits after sorting:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // 리스트의 모든 요소 제거
            fruits.Clear();
            Console.WriteLine($"Number of fruits after clearing: {fruits.Count}"); // 출력: 0
        }
    }
}
