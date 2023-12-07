namespace AlgorithmCodeKata.Level_3;

public class Level3_41_45_Solutions
{
    // 이상한 문자 만들기
    public string Solution_41(string s)
    {
        string answer = "";
        string[] strArr = s.Split();
        int count = strArr.Length;

        foreach (string str in strArr)
        {
            count--;

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    answer += str[i].ToString().ToUpper();
                }
                else
                {
                    answer += str[i].ToString().ToLower();
                }
            }

            if (count > 0) answer += " ";
        }

        return answer;
    }

    // 삼총사
    public int Solution_42(int[] number)
    {
        int answer = 0;
        int result = 0;
        int length = number.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                for (int k = j + 1; k < length; k++)
                {
                    result = number[i] + number[j] + number[k];
                    if (result == 0)
                    {
                        answer++;
                    }
                }
            }
        }

        return answer;
    }
}
