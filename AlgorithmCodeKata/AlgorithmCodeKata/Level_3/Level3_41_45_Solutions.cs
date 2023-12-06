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
}
