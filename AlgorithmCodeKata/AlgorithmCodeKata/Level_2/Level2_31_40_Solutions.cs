namespace AlgorithmCodeKata.Level_2;

public class Level2_31_40_Solutions
{
    // 수박수박수박수박수박수?
    public string Solution_31(int n)
    {
        string answer = "";
        bool isPattern = true;

        for (int i = 0; i < n; i++)
        {
            answer += isPattern ? '수' : '박';
            isPattern = !isPattern;
        }

        return answer;
    }

    // 내적
    public int Solution_32(int[] a, int[] b)
    {
        int answer = 0;

        for (int i = 0; i < a.Length; i++)
        {
            answer += a[i] * b[i];
        }

        return answer;
    }

    // 약수의 개수와 덧셈
    public int Solution_33(int left, int right)
    {
        int answer = 0;

        for (int i = left; i <= right; i++)
        {
            int count = 0;

            for (int k = 1; k <= i; k++)
            {
                if (i % k == 0)
                    count++;
            }

            answer += count % 2 == 0 ? i : -i;
        }

        return answer;
    }

    // 문자열 내림차순으로 배치하기
    public string Solution_34(string s)
    {
        char[] charArr = s.ToCharArray();
        Array.Sort(charArr);
        Array.Reverse(charArr);
        return new string(charArr);
    }
}
