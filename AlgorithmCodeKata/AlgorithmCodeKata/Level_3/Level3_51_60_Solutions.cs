namespace AlgorithmCodeKata.Level_3;

public class Level3_51_60_Solutions
{
    // 푸드 파이트 대회
    public string Solution_51(int[] food)
    {
        string strFirst = "";

        for (int i = 0; i < food.Length; i++)
        {
            int num = int.Parse(food[i].ToString());

            if (num % 2 != 0)
            {
                num -= 1;
            }

            for (int j = 0; j < num / 2; j++)
            {
                strFirst += i.ToString();
            }
        }

        char[] charArray = strFirst.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        string answer = strFirst + "0" + reversed;
        return answer;
    }

    // 콜라 문제
    public int Solution_52(int a, int b, int n)
    {
        int answer = 0;

        while (n >= a)
        {
            int remain = n % a;
            int result = n / a;
            answer += result * b;
            n = (result * b) + remain;
        }

        return answer;
    }
}
