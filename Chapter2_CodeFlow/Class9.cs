using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// ref, out
    /// 목표: 메서드에 의해 변경될 수 있는 참조에 의한 인수 전달을 이해한다.
    /// ref 키워드는 메서드에 변수를 참조로 전달하여 메서드 내에서 변수의 값을 변경할 수 있게 한다.
    /// out 키워드는 메서드에서 하나 이상의 값을 반환할 때 사용되며, 메서드 내에서 초기화되어야 한다.
    /// 
    /// ref 키워드:
    /// 용도: ref 키워드는 메서드에 변수를 참조로 전달할 때 사용됩니다. 
    /// 이를 통해 메서드 내에서 인수로 전달된 변수의 값을 변경할 수 있습니다.
    /// 사용법: ref 키워드는 메서드 정의와 호출 양쪽에 명시되어야 합니다. 
    /// 변수를 메서드에 전달하기 전에 초기화가 필요합니다.
    /// 
    /// 예제 설명: ModifyValue 메서드는 ref 키워드를 사용하여 
    /// number 변수의 참조를 전달받고, 해당 변수의 값을 변경합니다. 
    /// 결과적으로, 원본 number 변수의 값이 메서드 호출 후 변경된 상태로 반영됩니다.
    /// 
    /// out 키워드:
    /// 용도: out 키워드는 메서드가 변수를 초기화하거나 값을 할당할 목적으로 
    /// 참조에 의해 인수를 전달할 때 사용됩니다. 
    /// 이는 메서드로부터 여러 값을 반환받는 경우에 유용합니다.
    /// 
    /// 사용법: out 키워드 역시 메서드 정의와 호출 양쪽에 명시됩니다. 
    /// 단, 변수를 out으로 전달하기 전에 초기화할 필요는 없습니다.
    /// 
    /// 예제 설명: GetValues 메서드는 out 키워드를 사용하여 
    /// 두 개의 변수 a와 b를 초기화하고 값을 할당합니다. 
    /// 메서드 호출 후, x와 y 변수에 GetValues 메서드로부터 할당된 값이 반영됩니다.
    /// 
    /// ref와 out의 차이점:
    /// 1, 초기화 요구사항: ref를 사용할 때는 변수가 초기화되어 있어야 하지만, 
    /// out을 사용할 때는 초기화되지 않아도 됩니다.
    /// 2, 용도 차이: ref는 기존 변수의 값을 메서드 내에서 변경하기 위해 사용되며, 
    /// out은 메서드에서 값을 할당하고 반환하는 데 주로 사용됩니다.
    /// 
    /// ref와 out 키워드는 메서드와의 상호작용을 통해 프로그램 내에서 
    /// 변수의 값을 효율적으로 관리하고 조작할 수 있는 방법을 제공합니다. 
    /// 이를 통해 프로그램의 유연성과 표현력을 높일 수 있습니다.
    /// </summary>
    public class Class9
    {
        /// <summary>
        /// ref 키워드를 사용한 메서드. 변수의 참조를 전달받아 값을 변경한다.
        /// </summary>
        /// <param name="value">참조에 의해 전달될 변수</param>
        void ModifyValue(ref int value)
        {
            // ref를 사용하여 전달된 변수의 값에 10을 더함
            value += 10;
        }

        /// <summary>
        /// out 키워드를 사용한 메서드. 여러 값을 초기화하여 반환한다.
        /// </summary>
        /// <param name="a">첫 번째 반환 값</param>
        /// <param name="b">두 번째 반환 값</param>
        void GetValues(out int a, out int b)
        {
            // out을 사용하여 메서드 내에서 변수를 초기화
            a = 5;
            b = 10;
        }

        public void Run()
        {
            int number = 5;
            // ref 키워드를 사용하여 number 변수를 ModifyValue 메서드에 전달
            ModifyValue(ref number);
            Console.WriteLine(number); // 출력: 15

            int x, y;
            // out 키워드를 사용하여 GetValues 메서드로부터 두 값을 반환받음
            GetValues(out x, out y);
            Console.WriteLine($"{x}, {y}"); // 출력: 5, 10
        }
    }
}