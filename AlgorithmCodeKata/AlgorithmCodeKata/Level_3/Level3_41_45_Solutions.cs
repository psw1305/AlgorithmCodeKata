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

    // 크기가 작은 부분 문자열
    public int Solution_43(string t, string p)
    {
        int answer = 0;

        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            string str = t.Substring(i, p.Length);

            if (Convert.ToInt64(str) <= Convert.ToInt64(p))
            {
                answer += 1;
            }
        }

        return answer;
    }

    // 최소 직사각형
    public int Solution_44(int[,] sizes)
    {
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 0] < sizes[i, 1])
            {
                int temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }
        }

        int max_w = 0;
        int max_h = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (max_w < sizes[i, 0]) max_w = sizes[i, 0];
            if (max_h < sizes[i, 1]) max_h = sizes[i, 1];
        }

        return max_w * max_h;
    }

    // 시저 암호
    public string Solution_45(string s, int n)
    {
        char[] charArr = s.ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            int asc = (int)charArr[i];

            if ((asc >= 65 && asc <= 90))
            {
                asc += n;

                if (asc > 90)
                {
                    asc -= 26;
                }
            }
            else if (asc >= 97 && asc <= 122)
            {
                asc += n;

                if (asc > 122)
                {
                    asc -= 26;
                }
            }

            charArr[i] = (char)asc;
        }

        string answer = new string(charArr);
        return answer;
    }

    // 숫자 문자열과 영단어
    public int Solution_46(string s)
    {
        string str = "";
        string result = "";
        string[] units = { "zero", "one", "two", "three", "four",
                          "five", "six", "seven", "eight", "nine" };

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                str += c;
            }
            else
            {
                result += c;

                int index = Array.IndexOf(units, result);

                if (index != -1)
                {
                    result = "";
                    str += index;
                }
            }
        }

        int answer = int.Parse(str);
        return answer;
    }
}
