// 문제 1: 1차원 배열의 최대값 찾기
// 설명: 사용자로부터 5개의 정수를 입력받아 1차원 배열에 저장한 후, 배열 내에서 가장 큰 값을 찾아 출력하는 프로그램을 작성하세요.

// 요구 사항:

// 사용자가 입력한 5개의 정수를 배열에 저장하세요.
// 배열 내에서 최대값을 찾는 로직을 구현하세요.
// 최대값을 콘솔에 출력하세요.
public class ArrayMaxValue
{
  public void Run()
  {
    int[] numbers = new int[5];

    // 사용자로부터 정수 입력 받기
    for (int i = 0; i < numbers.Length; i++)
    {
      Console.Write($"숫자 {i + 1}을 입력하세요: ");
      numbers[i] = int.Parse(Console.ReadLine());
    }

    // 배열 내에서 최대값 찾기
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
      if (numbers[i] > max)
      {
        max = numbers[i];
      }
    }

    // 최대값 출력
    Console.WriteLine($"가장 큰 값은: {max}");
  }
}

// 문제 2: 2차원 배열의 합계 계산
// 설명: 3x3 크기의 2차원 배열을 사용하여, 각 요소에 1부터 9까지의 값을 채운 후, 배열에 저장된 모든 값의 합계를 계산하고 출력하는 프로그램을 작성하세요.

// 요구 사항:

// 3x3 크기의 2차원 배열을 선언하고 초기화하세요.
// 배열의 각 요소에 1부터 9까지의 값을 할당하세요.
// 배열의 모든 요소의 합계를 계산하는 로직을 구현하세요.
// 최종 합계를 콘솔에 출력하세요.
public class Array2DSum
{
  public void Run()
  {
    int[,] matrix = new int[3, 3];
    int value = 1;

    // 배열 요소에 값 채우기
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = value++;
      }
    }

    // 배열 요소의 합계 계산
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        sum += matrix[i, j];
      }
    }

    // 합계 출력
    Console.WriteLine($"2차원 배열의 모든 요소의 합은: {sum}");
  }
}

// 문제 3: 특정 값을 포함하는 2차원 배열의 위치 찾기
// 설명: 4x4 크기의 2차원 배열에 임의의 정수를 채우고, 사용자로부터 특정 값을 입력받아 해당 값이 배열의 어느 위치에 있는지를 찾는 프로그램을 작성하세요. (값이 없을 경우 "값을 찾을 수 없습니다."를 출력)

// 요구 사항:

// 4x4 크기의 2차원 배열을 선언하고 임의의 정수로 채우세요.
// 사용자로부터 검색할 값을 입력받으세요.
// 배열을 순회하며 해당 값이 존재하는지 확인하고, 위치를 출력하세요.
// 만약 배열에 값이 없으면, 값이 없다는 메시지를 출력하세요.
public class Array2DSearch
{
  public void Run()
  {
    int[,] matrix = {
            { 10, 20, 30, 40 },
            { 50, 60, 70, 80 },
            { 90, 100, 110, 120 },
            { 130, 140, 150, 160 }
        };

    // 사용자로부터 검색할 값 입력 받기
    Console.Write("검색할 값을 입력하세요: ");
    int target = int.Parse(Console.ReadLine());

    bool found = false;

    // 배열 순회하며 값 찾기
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (matrix[i, j] == target)
        {
          Console.WriteLine($"값 {target}은 {i}행 {j}열에 위치합니다.");
          found = true;
          break;
        }
      }
    }

    if (!found)
    {
      Console.WriteLine("값을 찾을 수 없습니다.");
    }
  }
}
