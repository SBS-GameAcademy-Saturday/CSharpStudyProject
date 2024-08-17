using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter3_OOP
{
    /// <summary>
    /// 은닉성
    /// 목표: 클래스 내부의 세부 구현을 숨기고 외부에 
    /// 필요한 부분만을 노출하는 캡슐화의 개념을 이해한다.
    /// 
    /// 은닉성(Encapsulation)은 객체 지향 프로그래밍에서 중요한 개념 중 하나로, 
    /// 클래스의 내부 구현을 숨기고 외부에서는 그 내부 구현에 직접 접근하지 못하게 하는 것을 말합니다. 
    /// 대신, 클래스는 공개된(public) 메서드를 통해 외부와의 인터페이스를 제공하여, 
    /// 객체의 상태를 안전하게 변경하고 조회할 수 있도록 합니다. 
    /// 이러한 방식으로, 객체의 상세 구현을 숨기는 것이 은닉성의 핵심입니다.
    /// 
    /// 은닉성의 장점:
    /// 1, 모듈성(Modularity): 
    /// 객체의 내부 구현이 외부로부터 분리되어 있기 때문에, 
    /// 코드 수정이나 기능 추가 시 다른 부분에 영향을 주지 않고 독립적으로 작업할 수 있습니다.
    /// 
    /// 2, 유지 보수성(Maintainability): 
    /// 내부 구현을 숨기고 통제된 접근 방식을 제공함으로써, 
    /// 객체의 사용법이 명확해지고, 오류가 발생할 가능성이 줄어듭니다.
    /// 
    /// 3, 보안(Security): 
    /// 중요한 데이터를 외부로부터 숨기고, 
    /// 객체의 상태를 잘못된 방식으로 변경할 수 없도록 함으로써, 
    /// 데이터의 안정성과 일관성을 유지할 수 있습니다.
    /// </summary>
    public class Class7
    {
        class BankAccount
        {
            // balance는 BankAccount 클래스의 내부 상태를 나타내며,
            // private 접근 제한자를 사용하여 외부에서 직접 접근할 수 없도록 함.
            private double balance = 0;

            // Deposit 메서드를 통해 외부에서 안전하게 balance를 변경할 수 있음.
            public void Deposit(double amount)
            {
                balance += amount;
            }

            // GetBalance 메서드를 통해 balance의 값을 조회할 수 있음.
            // 이 메서드는 balance의 값을 외부로 노출하지만, balance 자체는 직접 수정할 수 없음.
            public double GetBalance()
            {
                return balance;
            }
        }


    }
}