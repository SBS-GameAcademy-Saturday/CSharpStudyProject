using System;
using System.Collections.Generic;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
    /// <summary>
    /// Stack (스택)
    /// 목표: 스택을 사용하여 후입선출(LIFO) 방식으로 데이터를 처리하는 방법을 이해한다.
    /// 
    /// 스택(Stack) 이란?
    /// 스택은 후입선출(LIFO, Last-In-First-Out) 방식으로 데이터를 처리하는 자료구조입니다.
    /// 이는 나중에 들어온 데이터가 먼저 처리되는 구조를 의미합니다.
    /// 스택은 주로 재귀 알고리즘, 함수 호출 관리, 문자열 역순 처리와 같은 작업에서 사용됩니다.
    /// 
    /// 스택의 주요 특징:
    /// 1. **후입선출(LIFO)**: 스택에 나중에 들어간 데이터가 먼저 나옵니다.
    ///    이는 큐(Queue)의 선입선출(FIFO)과는 반대되는 개념입니다.
    /// 
    /// 2. **동적 크기 조정**: `Stack<T>`는 동적 크기 조정을 지원하여,
    ///    데이터가 추가되거나 제거될 때 크기가 자동으로 조정됩니다.
    /// 
    /// 3. **단일 접근점**: 스택의 요소는 한쪽 끝(맨 위)에서만 추가하거나 제거할 수 있습니다.
    /// 
    /// 주요 메서드 및 속성:
    /// - `Push(T item)`: 스택의 맨 위에 새로운 요소를 추가합니다.
    /// - `Pop()`: 스택의 맨 위에서 요소를 제거하고 반환합니다.
    /// - `Peek()`: 스택의 맨 위에 있는 요소를 제거하지 않고 반환합니다.
    /// - `Count`: 스택에 있는 요소의 수를 반환합니다.
    /// - `Clear()`: 스택의 모든 요소를 제거합니다.
    /// </summary>
    public class Class5
    {
        public void Run()
        {
            // 정수를 저장하는 스택 생성
            Stack<int> stack = new Stack<int>();

            // 요소 추가
            stack.Push(1); // 스택에 1 추가
            stack.Push(2); // 스택에 2 추가
            stack.Push(3); // 스택에 3 추가

            // 스택의 맨 위 요소를 제거하고 반환
            int topItem = stack.Pop();
            Console.WriteLine($"Popped item: {topItem}"); // 출력: Popped item: 3

            // 스택의 현재 맨 위 요소 확인 (제거하지 않음)
            int nextItem = stack.Peek();
            Console.WriteLine($"Next item: {nextItem}"); // 출력: Next item: 2

            // 스택의 모든 요소를 순회
            Console.WriteLine("Remaining items in stack:");
            foreach (int item in stack)
            {
                Console.WriteLine(item); // 출력: 2, 1
            }

            // 스택의 요소 수 출력
            Console.WriteLine($"Stack count: {stack.Count}"); // 출력: 2

            // 스택 비우기
            stack.Clear();
            Console.WriteLine($"Stack count after clearing: {stack.Count}"); // 출력: 0
        }
    }
}
