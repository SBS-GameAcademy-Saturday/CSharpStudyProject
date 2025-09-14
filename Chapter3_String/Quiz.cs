using System;

public class Program
{
    // 숫자 맞히기 게임
    // 이 게임은 int.Parse()를 사용해 문자열을 숫자로 변환하는 예제를 게임 형식으로 만든 것입니다.
    // 게임 규칙:
    // 1, 컴퓨터가 1부터 100 사이의 숫자를 하나 생각합니다.
    // 2, 플레이어는 숫자를 입력하여 맞혀야 합니다.
    // 3, 컴퓨터는 입력한 숫자가 정답보다 큰지, 작은지 힌트를 줍니다.
    // 4, 정답을 맞힐 때까지 게임을 계속합니다.
    // 숫자 맞히기 게임을 실행하는 메서드
    public static void NumberGuessingGame()
    {
        // 1부터 100 사이의 난수를 생성합니다.
        Random random = new Random();
        int computerNumber = random.Next(1, 101);
        int userGuess = 0;
        bool isCorrect = false;

        Console.WriteLine("제가 1부터 100 사이의 숫자를 생각했습니다. 맞춰보세요!");

        // 사용자가 정답을 맞출 때까지 반복합니다.
        while (!isCorrect)
        {
            Console.Write("숫자를 입력하세요: ");
            string userInput = Console.ReadLine();

            try
            {
                // 문자열 입력을 정수로 변환합니다.
                userGuess = int.Parse(userInput);

                if (userGuess > computerNumber)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }
                else if (userGuess < computerNumber)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                else
                {
                    Console.WriteLine($"축하합니다! 정답은 {computerNumber}였습니다.");
                    isCorrect = true;
                }
            }
            catch (FormatException)
            {
                // 숫자가 아닌 다른 문자를 입력했을 때
                Console.WriteLine("잘못된 입력입니다. 숫자만 입력해주세요.");
            }
        }
    }

    public static void Main(string[] args)
    {
        NumberGuessingGame();
    }
}
