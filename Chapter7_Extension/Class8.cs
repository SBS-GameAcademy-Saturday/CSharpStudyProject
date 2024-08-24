using System;

namespace CSharp_ProgramingStudy.Chapter7_Extension
{
    /// <summary>
    /// Exception (예외 처리)
    /// 예외 처리는 프로그램 실행 중 발생할 수 있는 예외적인 상황이나 오류를 처리하는 프로그래밍 패턴입니다.
    /// C#에서는 try, catch, finally 블록을 사용하여 예외 처리를 구현합니다. 이러한 메커니즘을 통해 프로그램의 안정성을 높이고,
    /// 예기치 않은 오류로부터 프로그램을 보호할 수 있습니다.
    /// 
    /// 주요 구성 요소:
    /// - try 블록: 예외가 발생할 가능성이 있는 코드를 포함합니다. 예외가 발생하면 실행이 try 블록에서 중단되고,
    ///   적절한 catch 블록으로 제어가 전달됩니다.
    /// - catch 블록: 특정 예외 유형을 처리하는 코드를 포함합니다. catch 블록은 하나 이상 있을 수 있으며,
    ///   각각 다른 유형의 예외를 처리할 수 있습니다. catch(Exception e)는 모든 예외의 베이스 타입인 Exception 클래스를
    ///   사용하여 모든 예외를 잡습니다.
    /// - finally 블록: 예외 발생 여부와 관계없이 실행되는 코드를 포함합니다. 주로 리소스 정리나 해제 등의 작업을 수행하는 데 사용됩니다.
    /// 
    /// 목적:
    /// - 로버스트성 향상: 예외 처리를 통해 예기치 않은 오류로부터 프로그램을 보호하고, 프로그램의 안정성과 신뢰성을 높일 수 있습니다.
    /// - 오류 진단: 예외 객체는 발생한 오류에 대한 상세 정보(오류 메시지, 스택 트레이스 등)를 포함하고 있어,
    ///   오류의 원인을 진단하는 데 도움이 됩니다.
    /// - 프로그램 흐름 제어: 예외 처리를 사용하면 오류 발생 시 프로그램의 실행 흐름을 명시적으로 제어할 수 있습니다.
    /// </summary>
    public class Class8
    {
        public void Run()
        {
            try
            {
                // 예외가 발생할 가능성이 있는 코드를 포함하는 try 블록
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]); // 인덱스 범위를 벗어난 접근으로 오류 발생
            }
            catch (IndexOutOfRangeException e)
            {
                // 특정 예외 유형(IndexOutOfRangeException)에 대한 처리
                Console.WriteLine("Index was out of range. Please check the array size.");
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                // 모든 예외를 처리하는 일반적인 catch 블록
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                // 예외 발생 여부와 상관없이 항상 실행되는 finally 블록
                Console.WriteLine("The 'try catch' block has finished executing.");
            }
        }
    }
}
