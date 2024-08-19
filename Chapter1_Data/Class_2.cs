using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
    /// <summary>
    /// 정수 형식
    /// 목표: C#의 정수형 데이터 타입과 그 사용법을 이해한다.
    /// 내용:
    /// int, long, short, byte 등의 정수형 타입 설명
    /// 각 데이터 타입의 용도와 범위
    /// 
    /// 정수형 데이터 타입 설명:
    /// int: 가장 일반적으로 사용되는 32비트 정수형 타입입니다. 
    /// -2,147,483,648에서 2,147,483,647 범위의 값을 저장할 수 있습니다. 
    /// 대부분의 정수 계산에 사용됩니다.
    /// 
    /// long: 더 큰 범위의 정수 값을 저장하기 위한 64비트 정수형 타입입니다. 
    /// -9,223,372,036,854,775,808에서 9,223,372,036,854,775,807 범위의 
    /// 값을 저장할 수 있습니다. 
    /// 매우 큰 수를 다룰 때 사용됩니다.
    /// 
    /// short: 작은 범위의 정수 값을 저장하기 위한 16비트 정수형 타입입니다. 
    /// -32,768에서 32,767 범위의 값을 저장할 수 있습니다. 
    /// 메모리를 절약해야 하지만 큰 수가 필요하지 않은 경우에 사용됩니다.
    /// 
    /// byte: 가장 작은 범위의 정수 값을 저장하기 위한 8비트 정수형 타입입니다. 
    /// 0에서 255 범위의 값을 저장할 수 있습니다. 
    /// 매우 작은 숫자를 다루거나 바이트 단위 데이터를 처리할 때 사용됩니다.
    ///
    /// 각 정수형 타입은 특정 용도에 맞게 설계되었으며, 
    /// 개발자는 변수를 선언할 때 저장해야 하는 값의 크기와 범위를 고려하여 
    /// 적절한 타입을 선택해야 합니다. 
    /// 이를 통해 메모리 사용량을 최적화하고, 
    /// 의도하지 않은 오버플로우 또는 데이터 손실을 방지할 수 있습니다.
    /// </summary>
    public class Class_2
    {
        // int형 변수 선언과 초기화
        int myInt = 10000;
        // long형 변수 선언과 초기화
        long myLong = 100000L;
        // short형 변수 선언과 초기화
        short myShort = 5000;
        // byte형 변수 선언과 초기화
        byte myByte = 255;

        public void ShowIntegerTypes()
        {
            Console.WriteLine($"int 형식 값: {myInt}");
            Console.WriteLine($"long 형식 값: {myLong}");
            Console.WriteLine($"short 형식 값: {myShort}");
            Console.WriteLine($"byte 형식 값: {myByte}");
        }
    }
}