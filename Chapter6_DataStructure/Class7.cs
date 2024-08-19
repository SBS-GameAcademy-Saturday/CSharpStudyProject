using System;
using System.Collections.Generic;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
    /// <summary>
    /// HashSet
    /// 목표: HashSet을 사용하여 중복을 허용하지 않는 데이터 컬렉션을 관리하는 방법을 학습한다.
    /// 
    /// HashSet이란?
    /// HashSet은 중복을 허용하지 않는 고유한 값들의 집합을 관리하는 자료구조입니다.
    /// `HashSet<T>`는 해시 알고리즘을 사용하여 데이터를 관리하므로, 
    /// 데이터의 삽입, 삭제, 검색 작업을 매우 빠르게 수행할 수 있습니다.
    /// 
    /// HashSet의 주요 특징:
    /// 1. **중복 허용 안 함**: HashSet은 동일한 값을 여러 번 저장하지 않습니다. 
    ///    값이 이미 존재하는 경우, 새로 추가되지 않습니다.
    /// 
    /// 2. **빠른 데이터 접근**: HashSet은 해시 알고리즘을 사용하여 데이터를 관리하므로, 
    ///    일반적으로 삽입, 삭제, 검색 작업이 O(1) 시간 복잡도를 가집니다.
    /// 
    /// 3. **순서가 없음**: HashSet에 저장된 데이터는 특정 순서를 보장하지 않으며, 
    ///    데이터의 삽입 순서와는 무관하게 저장됩니다.
    /// 
    /// 주요 메서드 및 속성:
    /// - `Add(T item)`: HashSet에 새로운 요소를 추가합니다. 
    ///    요소가 이미 존재하는 경우 추가되지 않습니다.
    /// - `Remove(T item)`: HashSet에서 특정 요소를 제거합니다.
    /// - `Contains(T item)`: HashSet에 특정 요소가 포함되어 있는지 확인합니다.
    /// - `Count`: HashSet에 있는 요소의 수를 반환합니다.
    /// - `Clear()`: HashSet의 모든 요소를 제거합니다.
    /// - `UnionWith(IEnumerable<T> other)`: 현재 HashSet과 다른 컬렉션의 합집합을 만듭니다.
    /// - `IntersectWith(IEnumerable<T> other)`: 현재 HashSet과 다른 컬렉션의 교집합을 만듭니다.
    /// - `ExceptWith(IEnumerable<T> other)`: 현재 HashSet에서 다른 컬렉션에 포함된 요소를 제거합니다.
    /// - `SymmetricExceptWith(IEnumerable<T> other)`: 현재 HashSet과 다른 컬렉션 간의 차집합을 만듭니다.
    /// </summary>
    public class Class7
    {
        public void Run()
        {
            // 정수를 저장하는 HashSet 생성
            HashSet<int> numbers = new HashSet<int>();

            // 요소 추가
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // 중복 요소 추가 시도 (추가되지 않음)
            bool added = numbers.Add(3);
            Console.WriteLine($"Was 3 added? {added}"); // 출력: Was 3 added? False

            // 요소 포함 여부 확인
            bool contains = numbers.Contains(2);
            Console.WriteLine($"Contains 2? {contains}"); // 출력: Contains 2? True

            // 요소 제거
            bool removed = numbers.Remove(2);
            Console.WriteLine($"Was 2 removed? {removed}"); // 출력: Was 2 removed? True

            // HashSet의 모든 요소 출력
            Console.WriteLine("Current elements in HashSet:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // 출력: 1, 3 (순서는 보장되지 않음)
            }

            // 다른 컬렉션과의 연산 예시
            HashSet<int> otherNumbers = new HashSet<int> { 3, 4, 5 };

            // 합집합
            numbers.UnionWith(otherNumbers);
            Console.WriteLine("UnionWith result:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // 출력: 1, 3, 4, 5 (순서는 보장되지 않음)
            }

            // 교집합
            numbers.IntersectWith(otherNumbers);
            Console.WriteLine("IntersectWith result:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // 출력: 3, 4, 5 (순서는 보장되지 않음)
            }

            // 차집합
            numbers.ExceptWith(otherNumbers);
            Console.WriteLine("ExceptWith result:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // 출력: 빈 출력
            }
        }
    }
}
