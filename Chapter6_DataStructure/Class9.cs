using System;
using System.Collections.Generic;

namespace CSharp_ProgramingStudy.Chapter6_DataStructure
{
  /// <summary>
  /// SortedList
  /// 목표: SortedList를 사용하여 키-값 쌍을 자동으로 정렬된 상태로 관리하는 방법을 학습한다.
  /// 
  /// SortedList란?
  /// SortedList는 키-값 쌍으로 이루어진 데이터를 자동으로 키 값에 따라 정렬하여 저장하는 컬렉션입니다.
  /// `SortedList<TKey, TValue>`는 `Dictionary`와 `List`의 특성을 결합한 데이터 구조로,
  /// 데이터를 키-값 쌍으로 저장하면서, 키에 따라 자동으로 정렬합니다.
  /// 
  /// SortedList의 주요 특징:
  /// 1. **자동 정렬**: `SortedList`는 키를 기준으로 자동으로 요소를 정렬합니다. 
  ///    기본적으로 오름차순으로 정렬되며, 키가 중복될 수 없습니다.
  /// 
  /// 2. **키-값 쌍 구조**: `SortedList`는 각 요소를 키-값 쌍으로 저장하며, 
  ///    `Dictionary`와 유사하게 키를 통해 값을 빠르게 검색할 수 있습니다.
  /// 
  /// 3. **인덱스 접근 가능**: `SortedList`는 키를 사용하여 요소에 접근하는 것 외에도,
  ///    인덱스를 통해 요소에 접근할 수 있습니다. 이는 `SortedDictionary`와의 차이점 중 하나입니다.
  /// 
  /// 4. **메모리 효율성**: `SortedList`는 `SortedDictionary`에 비해 메모리를 더 효율적으로 사용하지만,
  ///    요소를 삽입하거나 삭제할 때 속도가 느릴 수 있습니다.
  /// 
  /// 주요 메서드 및 속성:
  /// - `Add(TKey key, TValue value)`: 리스트에 새 키-값 쌍을 추가합니다.
  /// - `Remove(TKey key)`: 지정된 키에 해당하는 요소를 제거합니다.
  /// - `ContainsKey(TKey key)`: 특정 키가 리스트에 포함되어 있는지 확인합니다.
  /// - `ContainsValue(TValue value)`: 특정 값이 리스트에 포함되어 있는지 확인합니다.
  /// - `IndexOfKey(TKey key)`: 특정 키의 인덱스를 반환합니다.
  /// - `IndexOfValue(TValue value)`: 특정 값의 인덱스를 반환합니다.
  /// - `Keys`: 리스트의 모든 키를 반환합니다.
  /// - `Values`: 리스트의 모든 값을 반환합니다.
  /// - `Count`: 리스트에 있는 키-값 쌍의 수를 반환합니다.
  /// </summary>
  public class Class9
  {
    public void Run()
    {
      // SortedList 생성
      SortedList<int, string> students = new SortedList<int, string>();

      // 키-값 쌍 추가
      students.Add(101, "Alice");
      students.Add(103, "Charlie");
      students.Add(102, "Bob");

      // 자동으로 정렬된 키-값 쌍 출력
      Console.WriteLine("SortedList elements:");
      foreach (KeyValuePair<int, string> student in students)
      {
        Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        // 출력 순서: ID: 101, Name: Alice
        //            ID: 102, Name: Bob
        //            ID: 103, Name: Charlie
      }

      // 특정 키를 사용하여 값에 접근
      Console.WriteLine($"Student with ID 102: {students[102]}"); // 출력: Student with ID 102: Bob

      // 키를 사용하여 요소 제거
      students.Remove(103);

      // 요소 제거 후 SortedList 출력
      Console.WriteLine("After removing ID 103:");
      foreach (KeyValuePair<int, string> student in students)
      {
        Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        // 출력 순서: ID: 101, Name: Alice
        //            ID: 102, Name: Bob
      }

      // 특정 키가 포함되어 있는지 확인
      Console.WriteLine($"Contains key 101: {students.ContainsKey(101)}"); // 출력: Contains key 101: True

      // 특정 값이 포함되어 있는지 확인
      Console.WriteLine($"Contains value 'Charlie': {students.ContainsValue("Charlie")}"); // 출력: Contains value 'Charlie': False

      // 인덱스를 통해 요소 접근
      Console.WriteLine($"First student: {students.Values[0]}"); // 출력: First student: Alice
    }
  }
}
