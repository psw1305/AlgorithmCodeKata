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

    // 명예의 전당 (1)
    public int[] Solution_53(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        List<int> bestScore = new List<int>();
        int num = 0;

        for (int i = 0; i < score.Length; i++)
        {
            if (num < k)
            {
                bestScore.Add(score[i]);
                num++;
            }
            else
            {
                int min = bestScore.Min();
                int minIdx = bestScore.IndexOf(min);

                if (min < score[i])
                {
                    bestScore[minIdx] = score[i];
                }
            }

            answer[i] = bestScore.Min();
        }

        return answer;
    }

    // 2016
    public string Solution_54(int a, int b)
    {
        string[] day = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
        DateTime date = new DateTime(2016, a, b);
        DayOfWeek dayOfWeek = date.DayOfWeek;
        return day[(int)dayOfWeek];
    }

    // 카드뭉치
    public string Solution_55(string[] cards1, string[] cards2, string[] goal)
    {
        int idx1 = 0;
        int idx2 = 0;

        for (int i = 0; i < goal.Length; i++)
        {
            if (idx1 < cards1.Length && goal[i] == cards1[idx1])
            {
                idx1++;
                continue;
            }
            else if (idx2 < cards2.Length && goal[i] == cards2[idx2])
            {
                idx2++;
                continue;
            }
            else
            {
                return "No";
            }
        }

        return "Yes";
    }

    // 과일 장수
    public int Solution_56(int k, int m, int[] score)
    {
        int answer = 0;

        int[] numbers = score.Where(n => n <= k && n >= 1).OrderByDescending(n => n).ToArray();

        for (int i = 0; i < score.Length; i += m)
        {
            int[] slice = numbers.Skip(i).Take(m).ToArray();

            if (slice.Length == m)
            {
                int min = slice.Min();
                answer += min * m;
            }
        }

        return answer;
    }

    // 모의고사
    public int[] Solution_57(int[] answers)
    {
        List<int> answer = new List<int>();
        int[] bestScore = new int[3];

        int[] student1 = { 1, 2, 3, 4, 5 };
        int[] student2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] student3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int num1 = 0;
        int num2 = 0;
        int num3 = 0;

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == student1[i % student1.Length])
            {
                num1 += 1;
            }

            if (answers[i] == student2[i % student2.Length])
            {
                num2 += 1;
            }

            if (answers[i] == student3[i % student3.Length])
            {
                num3 += 1;
            }
        }

        bestScore[0] = num1;
        bestScore[1] = num2;
        bestScore[2] = num3;

        int max = bestScore.Max();

        for (int i = 0; i < bestScore.Length; i++)
        {
            if (bestScore[i] == max)
            {
                answer.Add(i + 1);
            }
        }

        return answer.ToArray();
    }
}
