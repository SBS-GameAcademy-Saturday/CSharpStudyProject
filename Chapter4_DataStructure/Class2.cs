using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_ProgramingStudy.Chapter4_DataStructure
{
    /// <summary>
    /// 연습 문제
    /// 문제: 다음 조건에 맞는 코드를 작성하세요.
    /// 5명의 학생 이름을 저장할 수 있는 문자열 배열을 생성하고, 각각에 학생 이름을 할당하세요.
    /// 배열의 모든 학생 이름을 출력하세요.
    /// </summary>
    public class Class2
    {
        public void Run()
        {
            // 연습 문제 1: 5명의 학생 이름을 저장하는 배열 생성 및 할당
            string[] students = { "Alice", "Bob", "Charlie", "Dave", "Eve" };

            // 연습 문제 2: 배열의 모든 학생 이름 출력
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
        }
    }
}