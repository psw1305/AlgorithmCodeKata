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

    // 음양 더하기
    public int Solution_26(int[] absolutes, bool[] signs)
    {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            if (signs[i])
            {
                answer += absolutes[i];
            }
            else
            {
                answer -= absolutes[i];
            }
        }

        return answer;
    }

    // 핸드폰 번호 가리기
    public string Solution_27(string phone_number)
    {
        string answer = "";
        int lastFourLength = phone_number.Length - 4;

        for (int i = 0; i < phone_number.Length; i++)
        {
            if (i < lastFourLength)
            {
                answer += "*";
            }
            else
            {
                answer += phone_number[i];
            }
        }

        return answer;
    }

    // 없는 숫자 더하기
    public int Solution_28(int[] numbers)
    {
        int answer = 45;
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        answer -= sum;
        return answer;
    }

    // 제일 작은 수 제거하기
    public int[] Solution_29(int[] arr)
    {
        int[] answer = new int[] { };

        if (arr.Length == 1)
        {
            return answer = new int[] { -1 };
        }

        int temp = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < temp)
            {
                temp = arr[i];
            }
        }

        answer = arr.Where(num => num != temp).ToArray();

        return answer;
    }

    // 가운데 글자 가져오기
    public string Solution_30(string s)
    {
        int middleNum = s.Length / 2;
        string answer = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s.Length % 2 == 0)
            {
                if (i == middleNum - 1 || i == middleNum)
                {
                    answer += s[i];
                }
            }
            else
            {
                if (i == middleNum)
                {
                    answer += s[i];
                }
            }
        }

        return answer;
    }
}
