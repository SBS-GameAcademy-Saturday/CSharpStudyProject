using System;
using System.Collections.Generic;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
    /// <summary>
    /// SortedDictionary
    /// 목표: 키-값 쌍을 키에 따라 자동으로 정렬된 상태로 관리하는 SortedDictionary를 이해하고 활용하는 방법을 학습한다.
    /// 
    /// SortedDictionary<TKey, TValue>란?
    /// `SortedDictionary<TKey, TValue>`는 `Dictionary`와 유사한 방식으로 키-값 쌍을 관리하지만, 
    /// 자동으로 키를 기준으로 정렬하는 특성을 가지고 있습니다.
    /// 
    /// SortedDictionary의 주요 특징:
    /// 1. **자동 정렬**: `SortedDictionary`는 키를 기준으로 자동으로 정렬합니다. 
    ///    기본적으로 오름차순으로 정렬되며, 키가 중복될 수 없습니다.
    /// 
    /// 2. **키-값 쌍 구조**: `SortedDictionary`는 키와 값의 쌍으로 데이터를 저장하며, 
    ///    `Dictionary`와 유사하게 키를 통해 값을 빠르게 검색할 수 있습니다.
    /// 
    /// 3. **효율적인 데이터 관리**: 
    ///    `SortedDictionary`는 요소 삽입, 삭제, 검색에 대해 비교적 빠른 성능을 제공합니다. 
    ///    특히 대규모 데이터 집합에서의 사용에 적합합니다.
    /// 
    /// 주요 메서드 및 속성:
    /// - `Add(TKey key, TValue value)`: 딕셔너리에 새로운 키-값 쌍을 추가합니다.
    /// - `Remove(TKey key)`: 특정 키에 해당하는 키-값 쌍을 제거합니다.
    /// - `ContainsKey(TKey key)`: 특정 키가 딕셔너리에 존재하는지 확인합니다.
    /// - `TryGetValue(TKey key, out TValue value)`: 특정 키에 해당하는 값을 안전하게 검색합니다.
    /// - `Keys`: 딕셔너리의 모든 키를 반환합니다.
    /// - `Values`: 딕셔너리의 모든 값을 반환합니다.
    /// - `Count`: 딕셔너리에 있는 키-값 쌍의 수를 반환합니다.
    /// </summary>
    public class Class10
    {
        public void Run()
        {
            // SortedDictionary 생성
            SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();

            // 키-값 쌍 추가
            sortedDict.Add(2, "Two");
            sortedDict.Add(1, "One");
            sortedDict.Add(3, "Three");

            // 자동으로 정렬된 키-값 쌍 출력
            Console.WriteLine("SortedDictionary elements:");
            foreach (KeyValuePair<int, string> kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                // 출력 순서: Key: 1, Value: One
                //            Key: 2, Value: Two
                //            Key: 3, Value: Three
            }

            // 특정 키를 사용하여 값에 접근
            if (sortedDict.TryGetValue(2, out string value))
            {
                Console.WriteLine($"Value for key 2: {value}"); // 출력: Value for key 2: Two
            }

            // 키를 사용하여 요소 제거
            sortedDict.Remove(3);

            // 요소 제거 후 SortedDictionary 출력
            Console.WriteLine("After removing key 3:");
            foreach (KeyValuePair<int, string> kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                // 출력 순서: Key: 1, Value: One
                //            Key: 2, Value: Two
            }

            // 특정 키가 포함되어 있는지 확인
            Console.WriteLine($"Contains key 3: {sortedDict.ContainsKey(3)}"); // 출력: Contains key 3: False
        }
    }
}
