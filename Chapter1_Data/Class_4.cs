using System;

namespace Chapter1_Data
{
    /// <summary>
    /// 정수 범위의 비밀
    /// 목표: 각 정수형의 최소값과 최대값을 이해하고, 정수 범위를 넘어설 때 발생하는 현상을 설명한다.
    /// 내용:
    /// - int, long 등의 범위: 
    /// C#에서 int 데이터 타입은 32비트 정수를 저장하며, 
    /// -2,147,483,648에서 2,147,483,647까지의 범위를 가진다.
    /// 
    /// long 데이터 타입은 64비트 정수를 저장할 수 있으며, 
    /// 더 넓은 범위를 가진다.
    /// 
    /// - 오버플로우와 언더플로우: 변수가 저장할 수 있는 범위를 초과하는 값을 할당하려 할 때 발생한다. 
    /// 오버플로우는 변수의 최대값을 초과할 때, 언더플로우는 최소값보다 작은 값을 할당할 때 발생한다. 
    /// 이 현상을 이해하는 것은 프로그램에서 예상치 못한 오류를 방지하는 데 중요하다.
    /// 이 클래스는 정수형 데이터 타입의 최대값과 최소값을 실험하여 오버플로우와 언더플로우 현상을 실제로 보여준다.
    /// </summary>
    public class Class_4
    {
        public void Run()
        {
            // int형의 최대값 저장
            int maxInt = int.MaxValue;
            // 최대값에 1을 더하면 오버플로우 발생
            int overflow = maxInt + 1;
            // int형의 최소값 저장
            int minInt = int.MinValue;
            // 최소값에 1을 빼면 언더플로우 발생
            int underflow = minInt - 1;

            Console.WriteLine($"int의 최대값: {maxInt}");
            Console.WriteLine($"오버플로우 발생 후: {overflow}");
            Console.WriteLine($"int의 최소값: {minInt}");
            Console.WriteLine($"언더플로우 발생 후: {underflow}");
        }

        // static void Main(string[] args)
        // {
        //     new Class_4().Run();
        // }
    }
}
