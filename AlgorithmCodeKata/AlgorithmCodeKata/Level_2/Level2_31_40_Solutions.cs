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
            if (isPattern)
            {
                answer += '수';
            }
            else
            {
                answer += '박';
            }

            isPattern = !isPattern;
        }

        return answer;
    }
}
