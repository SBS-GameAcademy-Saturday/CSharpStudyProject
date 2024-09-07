using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter2_CodeFlow
{
    /// <summary>
    /// 가위-바위-보 게임
    /// 목표: if와 switch를 활용하여 간단한 가위-바위-보 게임을 구현한다.
    /// 
    /// 먼저, 게임의 기본 규칙을 설정합니다. 
    /// 가위는 보를 이기고, 바위는 가위를 이기며, 보는 바위를 이깁니다. 
    /// 우리는 사용자의 선택과 컴퓨터의 선택을 문자열 변수로 표현하고, 
    /// 이 두 선택을 비교하여 게임의 결과를 결정합니다.
    /// 
    /// 게임 로직은 다음과 같습니다:
    /// 사용자와 컴퓨터의 선택이 같으면, 게임은 무승부입니다.
    /// 사용자가 가위를 선택하고 컴퓨터가 보를 선택했거나,
    /// 사용자가 바위를 선택하고 컴퓨터가 가위를 선택했거나, 
    /// 사용자가 보를 선택하고 컴퓨터가 바위를 선택한 경우, 사용자가 승리합니다.
    /// 
    /// 그 외의 모든 경우에는 컴퓨터가 승리합니다.
    /// 
    /// 이 간단한 예제를 통해, 우리는 if 조건문과 논리 연산자를 사용하여 
    /// 여러 조건을 효과적으로 평가하는 방법을 배울 수 있습니다. 
    /// 이러한 기초적인 구조는 프로그래밍에서 다양한 결정을 내리고, 
    /// 조건에 따라 다른 동작을 수행하도록 할 때 매우 유용하게 사용됩니다.
    /// 
    /// 여러분도 이 코드를 직접 실행해보고, 
    /// 다양한 경우를 테스트하여 프로그램이 올바르게 동작하는지 확인해보세요. 
    /// 또한, 사용자로부터 실제 입력을 받아 게임을 더 동적으로 만들어보는 것도 
    /// 좋은 연습이 될 것입니다.
    /// 
    /// </summary>
    public class Class3
    {


        // 가위 바위 보 게임 만들기 
        // (가위, 바위 , 보)중에서 특정 값을 입력하면 
        // 컴퓨터가 낸 값이랑 비교해서 결과를 출력한다.
        // => 1, 플레이어가 (가위, 바위 , 보)중에서 하나의 값을 입력하게 만들어야 한다.
        // => 2, 컴퓨터가 랜덤으로 (가위, 바위 , 보)주에서 하나의 값을 가지게 한다.
        // => 3, 플레이어가 입력한 값이랑 컴퓨터가 입력한 값이랑 결과를 비교한다.
        // => 4, 결과를 출력한다.
        static void Main(string[] args)
        {
            Console.WriteLine("가위 바위 보 게임을 시작합니다.");
            Console.WriteLine("가위, 바위 , 보 중에서 하나를 선택하여 값을 입력해주세요");
            // 1, 플레이어가 (가위, 바위 , 보)중에서 하나의 값을 입력하게 만들어야 한다.
            string inputValue = Console.ReadLine();
            if(inputValue == "가위" || inputValue == "바위" || inputValue == "보")
            {
                Console.WriteLine("입력한 값은 : " + inputValue);
                // 2, 컴퓨터가 랜덤으로 (가위, 바위 , 보)주에서 하나의 값을 가지게 한다.
                Random random = new Random();
                int randomInt = random.Next(0,3);
                string computerResult = "";
                switch (randomInt)
                {
                    case 0:
                        computerResult = "가위";
                        break;
                    case 1:
                        computerResult = "바위";
                        break;
                    case 2:
                        computerResult = "보";
                        break;
                    default :
                        computerResult = "가위";
                        break;
                }
                Console.WriteLine("컴퓨터가 반환한 값은 " + computerResult);
                string result = "";
                if (inputValue == computerResult)
                {
                    result = "Draw";
                }
                else if (inputValue == "가위" && computerResult == "보")
                {
                    result = "Player Win !";
                }
                else if (inputValue == "바위" && computerResult == "가위")
                {
                    result = "Player Win !";
                }
                else if (inputValue == "보" && computerResult == "바위")
                {
                    result = "Player Win !";
                }
                else
                {
                    result = "Computer Win !";
                }
                Console.WriteLine("결과는 : " + result);
            }
            else
            {
                Console.WriteLine("입력한 값은 : " + inputValue);
                Console.WriteLine("잘못된 값을 입력해서 프로그램을 종료합니다.");
            }
        
        }
    }
}
