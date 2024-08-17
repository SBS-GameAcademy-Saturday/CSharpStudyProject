using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

class Program
{
    // 클래스는 객체 지향 프로그래밍에서 가장 기본이 되는 구조로,
    // 데이터(속성)와 그 데이터를 조작하는 메서드(함수)를 하나의 단위로 묶는 집합체입니다.

    // 클래스의 구성 요소
    // 속성(Properties) : 클래스 내부에 정의된 변수
    // 메서드(Methods) : 클래스 내부에 정의된 함수

    // 메모리 영역
    // 스택 메모리 영역
    // 스택 메모리 영역은 컴파일 시간에 크기가 결정되는 값 타입 데이터를 저장합니다.
    // 메서드(함수) 호출 시 해당 메서드의 지역 변수와 매개변수가 스택에 저장됩니다.
    // 메서드 종료 시 스택에 저장된 데이터는 사라집니다.

    // 힙 메모리 영역
    // 런타임에 동적으로 할당되는 메모리 영역으로, 
    // 참조 타입 데이터가 저장됩니다. => 클래스

    // 데이터 메모리 영역
    // 프로그램의 정적 변수 + 전역 변수가 저장되는 메모리 영역입니다.
    // 프로그램의 시작과 함께 할당되면 프로그램이 종료되면 사라진다.

    class Player
    {
        // Static 키워드는 정적 멤버(속성, 메서드 등)로 선언해준다.
        // Static로 선언된 정적 멤버는 객체의 인스턴스가 
        // 아닌 클래스 자체에 속한 멤버를 정의
        public static int ID = 0;

        public static Player Instance;

        public Player()
        {
            Instance = this;
            ID += 1;
            System.Console.WriteLine("Player 클래스의 ID는 " + ID);
        }
        
        // Player 클래스의 속성
        public string Name;

        // Player 클래스의 메서드
        public void Run()
        {
            ID += 1;
            System.Console.WriteLine(Name + "이 달립니다.");
        }

        // 정적 함수는 정적으로(Static)선언된 데이터들만 다룰 수 있다.
        public static void SetName()
        {
            ID = 10;
        }


    }

    public class Goblin
    {
        public Goblin()
        {
            Player.Instance.Name = "유니얼";
            Player.Instance.Run();
        }
    }

    static void StackExample()
    {
        int value1 = 10; // 스택에 저장
        int value2 = value1; // 스택에 복사본 생성
        value2 = 20; // value2의 값 변경
        Console.WriteLine(value1); // 출력: 10
    }

    static void Main(string[] args)
    {
        //복사
        //기본적으로 우리가 다루는 
        //값(데이터,int,float,string) 복사 형식으로 된다.
        int a = 10;
        int b = a;
        b = 20;
        System.Console.WriteLine(a); // 10

        //Player 클래스의 인스턴스 생성
        //인스턴스 = 객체
        //Player 클래스의 객체 생성
        Player player1 = new Player();
        player1.Name = "채성학생";
        player1.Run();// 채성학생이 달립니다.
        
        Goblin goblin = new Goblin();

        player1.Run();// 유니얼이 달립니다.

        // Instance 클래스의 객체를 데이터 메모리 영역에 저장해서
        // 접근하는 방식을 싱글톤 패턴이라고 합니다.
        // 싱글톤 패턴은 전역적으로 게임의 데이터를 관리할떄 사용한다.
        // GameManager, SoundManager, LevelManager, SceneManager
    }
}
