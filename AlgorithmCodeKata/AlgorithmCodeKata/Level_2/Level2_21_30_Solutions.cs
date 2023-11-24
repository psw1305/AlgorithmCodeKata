namespace AlgorithmCodeKata.Level_2;

public class Level2_21_30_Solutions
{
    // 하샤드 수
    public bool Solution_21(int x)
    {
        int num = 0;
        string str = x.ToString();

        for (int i = 0; i < str.Length; i++)
        {
            num += int.Parse(str[i].ToString());
        }

        if (x % num == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 두 정수 사이의 합
    public long Solution_22(int a, int b)
    {
        long answer = 0;
        long min, max;

        if (a >= b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }

        for (long i = min; i <= max; i++)
        {
            answer += i;
        }

        return answer;
    }
}
