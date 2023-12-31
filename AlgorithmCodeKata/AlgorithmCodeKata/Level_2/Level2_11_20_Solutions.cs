﻿namespace AlgorithmCodeKata.Level_2;

public class Level2_11_20_Solutions
{
    /// <summary>
    /// 정수 num이 짝수일 경우 "Even"을 반환하고 홀수인 경우 "Odd"를 반환하는 함수, solution을 완성해주세요.
    /// </summary>
    public string Solution_11(int num)
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

    /// <summary>
    /// 정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.
    /// </summary>
    public double Solution_12(int[] arr)
    {
        double answer = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }

        answer /= arr.Length;

        return answer;
    }

    /// <summary>
    /// 자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 solution 함수를 만들어 주세요.
    /// 예를들어 N = 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.
    /// </summary>
    public int Solution_13(int n)
    {
        int answer = 0;

        while (n != 0)
        {
            int remain;

            remain = n % 10;

            answer += remain;

            n /= 10;
        }

        return answer;
    }

    // 약수의 합
    public int Solution_14(int n)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) answer += i;
        }
        return answer;
    }

    // 나머지가 1이 되는 작은 수 찾기
    public int Solution_15(int n)
    {
        int answer = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 1)
            {
                answer = i;
                break;
            }
        }
        return answer;
    }

    // x만큼 간격이 있는 n개의 숫자
    public long[] Solution_16(int x, int n)
    {
        long[] answer = new long[n];
        long num = x;

        for (int i = 0; i < n; i++)
        {
            answer[i] = num;
            num += x;
        }

        return answer;
    }

    // 자연수 뒤집어 배열로 만들기
    public int[] Solution_17(long n)
    {
        string str = n.ToString();
        int length = str.Length;
        int[] answer = new int[length];

        for (int i = 0; i < length; i++)
        {
            answer[i] = int.Parse(str[(length - 1) - i].ToString());
        }

        return answer;
    }

    // 문자열을 정수로 바꾸기
    public int Solution_18(string s)
    {
        int answer = 0;
        return answer = int.Parse(s);
    }

    // 정수 제곱근 판별
    public long Solution_19(long n)
    {
        double num = Math.Sqrt(n);

        if (num % 1 == 0)
        {
            return (long)((num + 1) * (num + 1));
        }
        else
        {
            return -1;
        }
    }

    // 정수 내림차순으로 배치하기
    public long Solution_20(long n)
    {
        string str = n.ToString();
        char[] charArr = str.ToCharArray();

        Array.Sort(charArr);
        Array.Reverse(charArr);

        string reversedStr = new string(charArr);
        long answer = long.Parse(reversedStr);

        return answer;
    }
}
