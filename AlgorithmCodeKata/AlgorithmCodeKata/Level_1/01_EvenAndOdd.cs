﻿namespace AlgorithmCodeKata.Level_1;

/// <summary>
/// 정수 num이 짝수일 경우 "Even"을 반환하고 홀수인 경우 "Odd"를 반환하는 함수, solution을 완성해주세요.
/// </summary>

public class _01_EvenAndOdd
{
    public string Solution(int num)
    {
        string answer = "";

        if (num % 2 == 0)
        {
            answer = "Even";
        }
        else
        {
            answer = "Odd";
        }

        return answer;
    }
}
