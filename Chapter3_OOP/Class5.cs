using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter3_OOP
{
    /// <summary>
    /// static의 정체
    /// 목표: static 키워드의 의미와 정적 멤버 및 메소드가 어떻게 사용되는지 이해한다.
    /// 
    /// static 키워드는 C# 프로그래밍 언어에서 정적 멤버(속성, 메서드, 필드, 이벤트 등) 또는 정적 클래스를 선언하는 데 사용됩니다. 
    /// static으로 선언된 멤버들은 해당 클래스의 인스턴스가 아니라 클래스 자체에 속하며, 
    /// 클래스의 모든 인스턴스에서 공유됩니다. 즉, static 멤버는 클래스 이름을 통해 직접 액세스할 수 있으며, 
    /// 객체 인스턴스를 생성하지 않아도 사용할 수 있습니다.
    /// 
    /// static 멤버의 특징:
    /// 1, 클래스 레벨에서 공유: 
    /// static 멤버는 클래스의 모든 인스턴스 간에 공유되며, 클래스 레벨에서 관리됩니다. 
    /// 따라서, 하나의 static 멤버의 값이 변경되면, 해당 클래스의 모든 인스턴스에 반영됩니다.
    /// 
    /// 2, 인스턴스 생성 없이 액세스 가능: 
    /// static 멤버는 클래스의 인스턴스를 생성하지 않고도 클래스 이름을 통해 직접 액세스할 수 있습니다.
    /// 
    /// 3, 메모리 효율성: 
    /// static 멤버는 프로그램 실행 중에 단 하나만 생성되고 관리되므로, 메모리 사용 측면에서 효율적입니다.
    /// 
    /// static 클래스의 특징:
    /// 1, 인스턴스화할 수 없음: 
    /// static 클래스는 인스턴스를 생성할 수 없으며, 오직 static 멤버만을 포함할 수 있습니다.
    /// 2, 유틸리티 및 헬퍼 메서드 제공에 적합: 
    /// static 클래스는 종종 유틸리티 함수나 헬퍼 메서드를 그룹화하는 데 사용됩니다. 
    /// 예를 들어, 수학 연산을 수행하는 메서드를 포함하는 Math 클래스와 같은 경우가 있습니다.
    /// </summary>
    public class Class5
    {
        /// <summary>
        /// MathUtility: 정적 메서드 Add를 포함하는 정적 클래스 예제
        /// </summary>
        class MathUtility
        {
            /// <summary>
            /// Add: 두 정수의 합을 반환하는 정적 메서드
            /// </summary>
            /// <param name="a">첫 번째 정수</param>
            /// <param name="b">두 번째 정수</param>
            /// <returns>두 정수의 합</returns>
            public static int Add(int a, int b)
            {
                return a + b;
            }
        }

        public void Run()
        {
            // MathUtility 클래스의 Add 메서드 호출
            int result = MathUtility.Add(5, 10);
            Console.WriteLine(result); // 출력: 15
        }
    }
}