using System;

namespace Chapter1_Data
{
    /// <summary>
    /// AND, OR, NOT과 같은 논리 연산자의 사용과 조건문에서의 응용을 이해한다.
    /// 목표: 논리 AND (&&), 논리 OR (||), 논리 NOT (!) 연산자를 사용하여 복잡한 조건을 평가하는 방법을 학습한다.
    /// 내용:
    /// - 논리 AND (&&): 모든 조건이 참일 때 참을 반환한다.
    /// - 논리 OR (||): 하나 이상의 조건이 참일 때 참을 반환한다.
    /// - 논리 NOT (!): 조건의 결과를 반전시킨다. 참이면 거짓을, 거짓이면 참을 반환한다.
    /// 이 클래스는 논리 연산자를 사용한 기본적인 예제를 제공하며, 이를 통해 조건 평가 방법을 보여준다.
    /// 
    /// 논리 연산 설명:
    /// 논리 AND (&&): 모든 조건이 true일 때만 결과가 true가 됩니다. 
    /// 예를 들어, 사용자가 성인이면서 동시에 학생이 아니어야 할 경우를 평가할 때 사용할 수 있습니다. 
    /// 이 연산은 "그리고"의 의미를 가집니다.
    /// 
    /// 논리 OR (||): 조건 중 하나라도 true이면 결과가 true가 됩니다. 
    /// 이 연산은 "또는"의 의미를 가지며, 여러 조건 중 하나만 만족해도 되는 경우에 사용됩니다.
    /// 
    /// 논리 NOT (!): 주어진 조건의 결과를 반대로 바꿉니다. 
    /// 즉, true를 false로, false를 true로 변경합니다. 조건이 만족하지 않아야 할 때 사용됩니다.
    /// 
    /// 논리 연산자는 조건문과 함께 사용되어 프로그램의 흐름을 제어하는 데 중요한 역할을 합니다. 
    /// 복잡한 조건을 효과적으로 평가하고, 프로그램의 로직을 명확하게 구현하는 데 도움을 줍니다.
    /// </summary>
    public class Class_11
    {
        public void Run()
        {
            // 논리 연산자 사용 예제
            bool isAdult = true;
            bool isStudent = false;
            bool canPurchase = isAdult && !isStudent; // 성인이면서 학생이 아닐 경우 true

            bool isWeekend = true;
            bool hasDiscount = isStudent || isWeekend; // 학생이거나 주말일 경우 true

            Console.WriteLine($"Can Purchase: {canPurchase}");
            Console.WriteLine($"Has Discount: {hasDiscount}");
        }

        // static void Main(string[] args)
        // {
        //     new Class_12().Run();
        // }
    }
}
