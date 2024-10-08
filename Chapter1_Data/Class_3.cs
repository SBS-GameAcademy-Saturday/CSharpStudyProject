using System;

namespace CSharp_ProgramingStudy.Chapter1_Data
{
    /// <summary>
    /// 2진수, 10진수, 16진수
    /// 목표: 2진수, 10진수, 16진수를 표현하고 이들 사이의 변환을 이해한다.
    /// 내용: 
    /// - 리터럴 접두사의 사용 (0b for binary, 0x for hexadecimal)
    /// - 2진수(Binary): 2진수는 0과 1로만 구성된 숫자 시스템이다. 
    /// 컴퓨터는 정보를 비트(bit) 단위로 처리하기 때문에, 
    /// 프로그래밍에서 2진수는 매우 중요한 역할을 한다. 
    /// C#에서는 2진수 리터럴을 표현하기 위해 '0b' 접두사를 사용한다.
    /// 
    /// - 10진수(Decimal): 일상생활에서 사용하는 숫자 시스템이다. 
    /// 0부터 9까지의 숫자를 사용하여 값을 표현한다. 
    /// 프로그래밍에서 숫자를 기본적으로 입력하면 10진수로 인식된다.
    /// 
    /// - 16진수(Hexadecimal): 16진수는 0부터 9까지의 숫자와 A부터 
    /// F까지의 문자를 사용하여 16개의 값을 표현하는 숫자 시스템이다. 
    /// 컴퓨터 메모리 주소나 색상 코드를 표현할 때 자주 사용된다. 
    /// C#에서는 16진수 리터럴을 표현하기 위해 '0x' 접두사를 사용한다.
    /// 
    /// 이러한 진법들은 프로그래밍에서 데이터를 표현하고 처리하는 데 있어 필수적인 개념이다. 
    /// 특히, 2진수와 16진수는 메모리 주소, 색상 코드, 데이터 암호화 등 
    /// 다양한 분야에서 널리 사용된다.
    /// </summary>
    public class Class_3
    {
        // 2진수 리터럴로 10 표현
        int binary = 0b1010;
        // 16진수 리터럴로 10 표현
        int hex = 0xA;

        public void ShowNumericRepresentations()
        {
            Console.WriteLine($"2진수로 표현된 10: {binary}");
            Console.WriteLine($"16진수로 표현된 10: {hex}");
        }
    }

    // // 연습문제: 10진수 45를 2진수와 16진수로 표현한 변수를 각각 선언하고 초기화
    // class Exercise
    // {
    //     static void Main(string[] args)
    //     {
    //         // 10진수 45를 2진수로 표현
    //         int binary45 = 0b101101;
    //         // 10진수 45를 16진수로 표현
    //         int hex45 = 0x2D;
    //         Console.WriteLine($"10진수 45를 2진수로 표현: {binary45}");
    //         Console.WriteLine($"10진수 45를 16진수로 표현: {hex45}");
    //     }
    // }
}
