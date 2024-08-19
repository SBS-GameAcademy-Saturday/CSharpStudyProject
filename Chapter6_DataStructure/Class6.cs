using System;
using System.Collections.Generic;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
    /// <summary>
    /// Queue (큐)
    /// 목표: 큐를 사용하여 선입선출(FIFO) 방식으로 데이터를 처리하는 방법을 이해한다.
    /// 
    /// 큐(Queue)란?
    /// 큐는 선입선출(FIFO, First-In-First-Out) 방식으로 데이터를 처리하는 자료구조입니다.
    /// 이는 먼저 들어온 데이터가 먼저 처리되는 구조를 의미합니다. 
    /// 큐는 주로 순서가 중요한 작업에서 사용되며, 대표적인 예로는 프린터 작업 대기열, 
    /// 메시지 처리 시스템, 너비 우선 탐색(BFS) 알고리즘 등이 있습니다.
    /// 
    /// 큐의 주요 특징:
    /// 1. **선입선출(FIFO)**: 큐에 먼저 들어간 데이터가 먼저 나옵니다. 
    ///    이는 스택(Stack)의 후입선출(LIFO)과는 반대되는 개념입니다.
    /// 
    /// 2. **동적 크기 조정**: `Queue<T>`는 동적 크기 조정을 지원하여, 
    ///    데이터가 추가되거나 제거될 때 크기가 자동으로 조정됩니다.
    /// 
    /// 3. **단일 접근점**: 큐의 요소는 한쪽 끝(앞)에서 제거되고, 다른 쪽 끝(뒤)에서 추가됩니다.
    /// 
    /// 주요 메서드 및 속성:
    /// - `Enqueue(T item)`: 큐의 끝에 새로운 요소를 추가합니다.
    /// - `Dequeue()`: 큐의 앞에서 요소를 제거하고 반환합니다.
    /// - `Peek()`: 큐의 앞에 있는 요소를 제거하지 않고 반환합니다.
    /// - `Count`: 큐에 있는 요소의 수를 반환합니다.
    /// - `Clear()`: 큐의 모든 요소를 제거합니다.
    /// </summary>
    public class Class6
    {
        public void Run()
        {
            // 정수를 저장하는 큐 생성
            Queue<int> queue = new Queue<int>();

            // 요소 추가
            queue.Enqueue(1); // 큐에 1 추가
            queue.Enqueue(2); // 큐에 2 추가
            queue.Enqueue(3); // 큐에 3 추가

            // 큐의 첫 번째 요소를 제거하고 반환
            int firstItem = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {firstItem}"); // 출력: Dequeued item: 1

            // 큐의 현재 첫 번째 요소 확인 (제거하지 않음)
            int nextItem = queue.Peek();
            Console.WriteLine($"Next item: {nextItem}"); // 출력: Next item: 2

            // 큐의 모든 요소를 순회
            Console.WriteLine("Remaining items in queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item); // 출력: 2, 3
            }

            // 큐의 요소 수 출력
            Console.WriteLine($"Queue count: {queue.Count}"); // 출력: 2

            // 큐 비우기
            queue.Clear();
            Console.WriteLine($"Queue count after clearing: {queue.Count}"); // 출력: 0
        }
    }
}
