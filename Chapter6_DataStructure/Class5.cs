using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter4_DataStructure
{
    /// <summary>
    /// Dictionary
    /// 목표: Dictionary를 사용하여 키-값 쌍을 저장하는 방법을 이해한다.
    /// 
    /// Dictionary<TKey, TValue>는 C#의 System.Collections.Generic 네임스페이스에 있는 제네릭 컬렉션의 일종으로, 
    /// 키와 값의 쌍으로 데이터를 저장합니다. 각 키는 컬렉션 내에서 유일해야 하며, 
    /// 이를 통해 효율적인 데이터 검색, 추가, 수정, 삭제 작업을 수행할 수 있습니다.
    /// 
    /// Dictionary의 주요 특징:
    /// 1, 키-값 쌍: 데이터는 키(Key)와 값(Value)의 쌍으로 저장됩니다. 키를 통해 빠르게 값을 검색할 수 있습니다.
    /// 2, 제네릭: Dictionary<TKey, TValue>는 제네릭을 사용하여 다양한 타입의 키와 값을 저장할 수 있습니다.
    /// 3, 고유한 키: 키는 컬렉션 내에서 고유해야 하며, 중복된 키를 추가하려고 하면 예외가 발생합니다.
    /// 4, 동적 크기 조정: 요소를 추가하거나 제거할 때 컬렉션의 크기가 동적으로 조정됩니다.
    /// 
    /// 주요 메서드 및 속성:
    /// Add(TKey key, TValue value): 새 키-값 쌍을 딕셔너리에 추가합니다.
    /// Remove(TKey key): 지정된 키를 가진 요소를 제거합니다.
    /// ContainsKey(TKey key): 딕셔너리에 특정 키가 있는지 확인합니다.
    /// TryGetValue(TKey key, out TValue value): 특정 키에 해당하는 값을 가져오려고 시도하며, 성공 여부를 반환합니다.
    /// Count: 딕셔너리에 있는 키-값 쌍의 수를 반환합니다.
    /// </summary>
    public class Class5
    {
        public void Run()
        {
            // 문자열 키와 문자열 값을 가지는 Dictionary 생성
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            // 키-값 쌍 추가
            capitals.Add("South Korea", "Seoul");
            capitals.Add("United States", "Washington D.C.");
            capitals.Add("United Kingdom", "London");

            // 키를 통한 값 접근
            Console.WriteLine($"The capital of South Korea is {capitals["South Korea"]}"); // 출력: Seoul

            // 딕셔너리 순회
            foreach (var kvp in capitals)
            {
                Console.WriteLine($"Country: {kvp.Key}, Capital: {kvp.Value}");
            }

            // 키 존재 여부 확인
            if (capitals.ContainsKey("France"))
            {
                Console.WriteLine($"The capital of France is {capitals["France"]}");
            }
            else
            {
                Console.WriteLine("France is not in the dictionary.");
            }

            // 키에 해당하는 값 가져오기
            string capital;
            if (capitals.TryGetValue("United Kingdom", out capital))
            {
                Console.WriteLine($"The capital of the United Kingdom is {capital}");
            }
        }
    }
}