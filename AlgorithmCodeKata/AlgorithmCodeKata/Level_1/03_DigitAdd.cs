namespace AlgorithmCodeKata.Level_1;

/// <summary>
/// 자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 solution 함수를 만들어 주세요.
/// 예를들어 N = 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.
/// </summary>

public class _03_DigitAdd
{
    public int Solution(int n)
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
}
