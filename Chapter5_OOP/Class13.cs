using System;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
    /// <summary>
    /// Boxing과 Unboxing
    /// 목표: C#에서 Boxing과 Unboxing이 어떻게 작동하며, 성능 및 메모리 관리에 어떤 영향을 미치는지 이해한다.
    /// 설명: Boxing은 값 타입을 참조 타입으로 변환하는 과정이고, Unboxing은 참조 타입을 다시 값 타입으로 변환하는 과정이다.
    /// Boxing: 값 타입의 데이터를 참조 타입으로 변환하여 힙 메모리에 저장하는 과정입니다. 이 변환은 자동으로 일어나며, 값 타입을 object 타입에 할당할 때 발생합니다.
    /// Unboxing: 참조 타입에서 값을 추출하여 다시 값 타입으로 변환하는 과정입니다. 이 변환은 명시적으로 캐스팅이 필요하며, 형식이 일치하지 않으면 예외가 발생할 수 있습니다.
    /// </summary>
    public class Class13
    {
        /// <summary>
        /// Boxing 예제: 값 타입을 참조 타입으로 변환
        /// </summary>
        private void BoxingExample()
        {
            int value = 123; // 값 타입인 int
            object boxedValue = value; // Boxing: int 값이 object 타입으로 변환되어 힙에 저장됨
            Console.WriteLine($"Boxing: value = {value}, boxedValue = {boxedValue}");
        }

        /// <summary>
        /// Unboxing 예제: 참조 타입에서 값을 추출하여 다시 값 타입으로 변환
        /// </summary>
        private void UnboxingExample()
        {
            object boxedValue = 123; // Boxing된 값
            int unboxedValue = (int)boxedValue; // Unboxing: 참조 타입에서 값을 꺼내어 다시 int 값으로 변환
            Console.WriteLine($"Unboxing: boxedValue = {boxedValue}, unboxedValue = {unboxedValue}");
        }

        /// <summary>
        /// Boxing/Unboxing 성능 문제 예시: 반복적인 Boxing/Unboxing 발생으로 인한 성능 저하
        /// </summary>
        private void PerformanceExample()
        {
            int sum = 0;
            object boxedNum;
            for (int i = 0; i < 1000000; i++)
            {
                boxedNum = i; // Boxing 발생
                sum += (int)boxedNum; // Unboxing 발생
            }
            Console.WriteLine($"Performance Test Final sum: {sum}");
        }

        /// <summary>
        /// Boxing과 Unboxing이 어떻게 발생하는지 보여주는 메서드
        /// </summary>
        public void Run()
        {
            // Boxing 예제 실행
            BoxingExample();

            // Unboxing 예제 실행
            UnboxingExample();

            // 성능 문제 예제 실행
            PerformanceExample();
        }
    }
}
