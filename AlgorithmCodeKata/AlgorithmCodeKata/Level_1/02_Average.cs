namespace AlgorithmCodeKata.Level_1;

/// <summary>
/// 정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.
/// </summary>

public class _02_Average
{
    public double solution(int[] arr)
    {
        double answer = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }

        answer /= arr.Length;

        return answer;
    }
}
