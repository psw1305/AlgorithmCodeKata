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

    // 콜라츠 추측
    public int Solution_23(long num)
    {
        int count = 0;

        while (num != 1 && count <= 500)
        {
            num = num % 2 == 0 ? num /= 2 : (num * 3) + 1;
            count++;
        }

        return count <= 500 ? count : -1;
    }

    // 서울에서 김서방 찾기
    public string Solution_24(string[] seoul)
    {
        string answer = "";

        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i].Contains("Kim"))
            {
                answer = $"김서방은 {i}에 있다";
            }
        }

        return answer;
    }

    // 나누어 떨어지는 숫자
    public int[] Solution_25(int[] arr, int divisor)
    {
        int[] answer = arr.Where(num => num % divisor == 0).ToArray();

        if (answer.Length != 0)
        {
            Array.Sort(answer);
        }
        else
        {
            answer = new int[] { -1 };
        }

        return answer;
    }
}
