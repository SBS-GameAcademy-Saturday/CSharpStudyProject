using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// 상수와 열거형
    /// 목표: 상수와 열거형을 사용하여 코드의 가독성과 유지 보수성을 향상시킨다.
    /// 
    /// 먼저, 상수에 대해 알아보겠습니다. 
    /// 상수는 한 번 값이 할당되면 그 값을 변경할 수 없는 변수입니다. 
    /// 상수를 사용하면, 프로그램 전체에서 변경되지 않는 값을 표현할 수 있으며, 
    /// 이는 코드의 안정성을 높여줍니다. 

    /// 예를 들어, 원주율 π의 값은 변하지 않으므로, 
    /// 이를 상수로 선언하여 사용하는 것이 적절합니다.
    /// 
    /// 다음으로, 열거형(Enums) 입니다. 
    /// 열거형은 관련된 상수들의 집합을 정의하는 데 사용됩니다. 
    /// 예를 들어, 요일을 나타내는 Days 열거형을 선언하여, 
    /// 각 요일을 더 명확하고 가독성 높게 표현할 수 있습니다. 
    /// 열거형을 사용하면, 숫자 대신 의미 있는 이름으로 각 옵션을 표현할 수 있어 
    /// 코드의 이해도를 높일 수 있습니다.
    /// 
    /// 이 예제에서, 우리는 π 값을 상수로 선언하여 출력하고, 
    /// 오늘 요일을 열거형 변수로 선언하여 그 값을 출력합니다. 
    /// 이렇게 함으로써, 우리는 코드의 명확성을 높이고, 
    /// 잠재적인 오류의 가능성을 줄일 수 있습니다.
    /// 
    /// 상수와 열거형을 사용하는 것은 프로그램을 더욱 안정적으로 만들고, 
    /// 다른 개발자가 코드를 이해하기 쉽게 만드는 효과적인 방법입니다. 
    /// 따라서, 이러한 기능들을 적절히 활용하여 프로그램의 품질을 향상시켜 보세요.
    /// 
    /// </summary>
    public class Class4
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        public void Run()
        {
            const double Pi = 3.14159;
            Console.WriteLine(Pi);

            Days today = Days.Monday;
            Console.WriteLine(today);

        }
    }
}