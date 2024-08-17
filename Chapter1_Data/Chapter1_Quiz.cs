using System;

namespace Chapter1_Data
{
  public class Assessment
  {
    /// <summary>
    /// 문제 1: 정수형 변수 'age'를 선언하고, 25로 초기화하세요.
    /// 출력 결과: age = 25
    /// </summary> 
    public void Quiz_1()
    {
      // 문제 1: 데이터 타입과 변수 선언
      Console.WriteLine("문제 1: 정수형 변수 'age'를 선언하고, 25로 초기화하세요.");
      int age = 25;
      Console.WriteLine($"정답: int age = {age};");
      Console.WriteLine($"출력 결과: age = {age}\n");
      
    }
    /// <summary>
    /// 문제 2: 두 정수형 변수 'x'와 'y'를 선언하고, 각각 10과 3으로 초기화한 후, 나누기 연산의 결과를 'quotient' 변수에 저장하세요.
    /// 출력 결과: quotient = 3.3333333333333335
    /// </summary>
    public void Quiz_2()
    {
      // 문제 2: 산술 연산자
      Console.WriteLine("문제 2: 두 정수형 변수 'x'와 'y'를 선언하고, 각각 10과 3으로 초기화한 후, 나누기 연산의 결과를 'quotient' 변수에 저장하세요.");
      int x = 10;
      int y = 3;
      double quotient = x / (double)y;
      Console.WriteLine($"정답: int x = {x}; int y = {y}; double quotient = x / (double)y;");
      Console.WriteLine($"출력 결과: quotient = {quotient}\n");
    }

    /// <summary>
    /// 문제 3: 두 정수형 변수 'a'와 'b'를 선언하고, 'a'가 'b'보다 크면 true를 반환하는 'isAGreater' 변수를 선언하세요.
    /// 출력 결과: isAGreater = True
    /// </summary>
    public void Quiz_3()
    {
      // 문제 3: 비교 연산자
      Console.WriteLine("문제 3: 두 정수형 변수 'a'와 'b'를 선언하고, 'a'가 'b'보다 크면 true를 반환하는 'isAGreater' 변수를 선언하세요.");
      int a = 7;
      int b = 5;
      bool isAGreater = a > b;
      Console.WriteLine($"정답: int a = {a}; int b = {b}; bool isAGreater = a > b;");
      Console.WriteLine($"출력 결과: isAGreater = {isAGreater}\n");

    }

    /// <summary>
    /// 문제 4: 논리 연산자를 사용하여 'isAdult'가 true이고, 'isStudent'가 false일 때 'canEnter' 변수를 true로 설정하세요.
    /// 출력 결과: canEnter = True
    /// </summary>
    public void Quiz_4()
    {
      // 문제 4: 논리 연산자
      Console.WriteLine("문제 4: 논리 연산자를 사용하여 'isAdult'가 true이고, 'isStudent'가 false일 때 'canEnter' 변수를 true로 설정하세요.");
      bool isAdult = true;
      bool isStudent = false;
      bool canEnter = isAdult && !isStudent;
      Console.WriteLine($"정답: bool isAdult = {isAdult}; bool isStudent = {isStudent}; bool canEnter = isAdult && !isStudent;");
      Console.WriteLine($"출력 결과: canEnter = {canEnter}\n");

    }

    /// <summary>
    /// 문제 5: double형 변수 'height'를 선언하고 175.5로 초기화한 후, 이 값을 int형으로 변환하여 'intHeight' 변수에 저장하세요.
    /// 출력 결과: intHeight = 175
    /// </summary>
    public void Quit_5()
    {
      // 문제 5: 명시적 캐스팅
      Console.WriteLine("문제 5: double형 변수 'height'를 선언하고 175.5로 초기화한 후, 이 값을 int형으로 변환하여 'intHeight' 변수에 저장하세요.");
      double height = 175.5;
      int intHeight = (int)height;
      Console.WriteLine($"정답: double height = {height}; int intHeight = (int)height;");
      Console.WriteLine($"출력 결과: intHeight = {intHeight}\n");
    }
  }
}
