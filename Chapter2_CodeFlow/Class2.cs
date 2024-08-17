using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// switch
    /// 목표: 여러 조건 중 하나를 선택하여 실행하는 방법을 학습한다.
    /// switch 문을 사용하여 변수의 값에 따라 다양한 코드 블록을 선택적으로 실행한다.
    /// 이 예제에서는 요일을 나타내는 정수에 따라 해당 요일의 이름을 출력한다.
    /// 
    /// switch 문 설명:
    /// 기본 구조: switch 문은 괄호 안에 평가하고자 하는 변수나 표현식을 지정합니다. 
    /// 그 후에 중괄호 {} 안에 여러 case 라벨을 정의하여 각각의 경우에 
    /// 실행할 코드 블록을 작성합니다.
    /// 
    /// case 라벨: 각 case는 특정 값과 일치할 때 실행될 코드를 정의합니다. 
    /// case 뒤에는 콜론(:)이 오고, 해당 case에 해당하는 코드 블록이 이어집니다. 
    /// case 블록의 끝에는 break 문을 사용하여 switch 문에서 빠져나오게 합니다.
    /// 
    /// default: switch 문에서 어떤 case도 일치하지 않을 때 
    /// 실행될 기본 코드 블록을 정의합니다. default 블록은 선택적이며, 
    /// 있을 경우 switch 문의 마지막에 위치해야 합니다.
    /// 
    /// switch 문은 단순한 조건부 로직뿐만 아니라, 
    /// 복잡한 분기를 필요로 하는 상황에서 코드의 가독성을 높이고, 
    /// if-else if 문보다 효율적인 방법을 제공할 수 있습니다. 
    /// C# 8.0 이상에서는 switch 표현식을 통해 더 간결하고 
    /// 강력한 패턴 매칭 기능을 사용할 수도 있습니다.
    /// </summary>
    public class Class2
    {
        public void Run()
        {
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

        }
    }
}
