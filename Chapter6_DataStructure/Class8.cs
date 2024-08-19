using System;
using System.Collections.Generic;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
    /// <summary>
    /// LinkedList
    /// 목표: LinkedList를 사용하여 데이터를 연결된 노드 구조로 관리하는 방법을 학습한다.
    /// 
    /// LinkedList란?
    /// LinkedList는 각 요소가 노드(Node)로 구성되어 있으며, 
    /// 각 노드는 데이터와 다음 노드에 대한 참조를 가지고 있는 데이터 구조입니다.
    /// `LinkedList<T>`는 이 노드들이 연결되어 있는 구조로, 
    /// 동적으로 크기를 조정할 수 있으며, 리스트의 중간에 요소를 삽입하거나 제거하는 데 적합합니다.
    /// 
    /// LinkedList의 주요 특징:
    /// 1. **이중 연결 리스트**: C#의 `LinkedList<T>`는 이중 연결 리스트(Doubly Linked List)로 구현되어 있습니다. 
    ///    각 노드는 이전 노드와 다음 노드를 가리키는 참조를 가지고 있습니다.
    /// 
    /// 2. **동적 크기 조정**: `LinkedList`는 요소를 추가하거나 제거할 때, 자동으로 크기가 조정되며, 
    ///    요소의 개수에 따라 메모리 크기를 조절할 필요가 없습니다.
    /// 
    /// 3. **순차 접근**: `LinkedList`는 순차적으로 요소에 접근해야 하며, 
    ///    인덱스를 통한 임의 접근(Random Access)이 불가능합니다. 
    ///    이는 배열이나 `List<T>`와의 주요 차이점입니다.
    /// 
    /// 4. **삽입/삭제 효율성**: `LinkedList`는 중간에 요소를 삽입하거나 제거하는 작업이 매우 효율적입니다. 
    ///    이러한 작업의 시간 복잡도는 O(1)입니다.
    /// 
    /// 주요 메서드 및 속성:
    /// - `AddFirst(T item)`: 리스트의 처음에 요소를 추가합니다.
    /// - `AddLast(T item)`: 리스트의 끝에 요소를 추가합니다.
    /// - `AddBefore(LinkedListNode<T> node, T item)`: 특정 노드 앞에 요소를 삽입합니다.
    /// - `AddAfter(LinkedListNode<T> node, T item)`: 특정 노드 뒤에 요소를 삽입합니다.
    /// - `Remove(T item)`: 리스트에서 첫 번째로 일치하는 요소를 제거합니다.
    /// - `RemoveFirst()`: 리스트의 첫 번째 요소를 제거합니다.
    /// - `RemoveLast()`: 리스트의 마지막 요소를 제거합니다.
    /// - `First`: 리스트의 첫 번째 노드를 반환합니다.
    /// - `Last`: 리스트의 마지막 노드를 반환합니다.
    /// - `Count`: 리스트에 있는 요소의 수를 반환합니다.
    /// </summary>
    public class Class8
    {
        public void Run()
        {
            // 정수를 저장하는 LinkedList 생성
            LinkedList<int> numbers = new LinkedList<int>();

            // 리스트에 요소 추가
            numbers.AddLast(1); // 마지막에 1 추가
            numbers.AddLast(2); // 마지막에 2 추가
            numbers.AddFirst(0); // 처음에 0 추가

            // LinkedList의 첫 번째 노드에 접근
            LinkedListNode<int> firstNode = numbers.First;
            Console.WriteLine($"First element: {firstNode.Value}"); // 출력: First element: 0

            // 특정 노드 뒤에 요소 추가
            numbers.AddAfter(firstNode, 5); // 첫 번째 노드(0) 뒤에 5를 삽입

            // LinkedList의 모든 요소 출력
            Console.WriteLine("LinkedList elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // 출력: 0, 5, 1, 2
            }

            // 요소 제거
            numbers.Remove(5); // 값이 5인 첫 번째 요소를 제거

            // 첫 번째 요소 제거
            numbers.RemoveFirst();

            // 마지막 요소 제거
            numbers.RemoveLast();

            // 요소 제거 후 LinkedList 출력
            Console.WriteLine("After removing elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // 출력: 1
            }

            // LinkedList의 크기 확인
            Console.WriteLine($"Number of elements: {numbers.Count}"); // 출력: Number of elements: 1
        }
    }
}
