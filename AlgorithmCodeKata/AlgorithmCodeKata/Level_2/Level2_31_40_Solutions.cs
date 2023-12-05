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

    // 부족한 금액 계산하기
    public long Solution_35(int price, long money, int count)
    {
        long sum = 0;

        for (int i = 1; i <= count; i++)
        {
            sum += (price * i);
        }

        if (money >= sum)
        {
            return 0;
        }
        else
        {
            return sum - money;
        }
    }

    // 문자열 다루기 기본
    public bool Solution_36(string s)
    {
        if (s.Length == 4 || s.Length == 6)
        {
            bool answer = int.TryParse(s, out int num);
            return answer;
        }
        else
        {
            return false;
        }
    }

    // 행렬의 덧셈
    public int[,] Solution_37(int[,] arr1, int[,] arr2)
    {
        int row = arr1.GetLength(0);
        int col = arr1.GetLength(1);
        int[,] answer = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int k = 0; k < col; k++)
            {
                answer[i, k] = arr1[i, k] + arr2[i, k];
            }
        }

        return answer;
    }

    // 직사각형 별찍기
    public static void Solution_38()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        for (int i = 0; i < b; i++)
        {
            for (int k = 0; k < a; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    // 최대공약수와 최소공배수
    public int[] Solution_39(int n, int m)
    {
        int[] answer = new int[2];
        answer[0] = GCD(n, m);
        answer[1] = n * m / answer[0];
        return answer;
    }

    public int GCD(int a, int b)
    {
        if (b == 0) return a;
        else return GCD(b, a % b);
    }

    // 3진법 뒤집기
    public int Solution_40(int n)
    {
        int answer = 0;

        while (n > 0)
        {
            answer *= 3;
            answer += n % 3;
            n /= 3;
        }

        return answer;
    }
}
