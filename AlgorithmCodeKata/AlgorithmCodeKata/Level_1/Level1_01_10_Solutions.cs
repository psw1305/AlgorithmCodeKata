namespace AlgorithmCodeKata.Level_1;

public class Level1_01_10_Solutions
{
    // 두 수의 차
    public int Solution_1(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }

    // 두 수의 곱
    public int Solution_2(int num1, int num2)
    {
        int answer = 0;
        answer = num1 * num2;
        return answer;
    }

    // 몫 구하기
    public int Soluction_3(int num1, int num2)
    {
        int answer = 0;
        answer = num1 / num2;
        return answer;
    }
    
    // 나이 출력
    public int Solution_4(int age)
    {
        int answer = 0;
        answer = 2023 - age;
        return answer;
    }

    // 숫자 비교하기
    public int Solution_5(int num1, int num2)
    {
        if (num1 == num2) return 1;
        else return -1;
    }

    // 두 수의 합
    public int Solution_6(int num1, int num2)
    {
        return num1 + num2;
    }

    // 두 수의 나눗셈
    public int Soluction_7(int num1, int num2)
    {
        return (num1 * 1000) / num2;
    }

    // 각도기
    public int Soluction_8(int angle)
    {
        int answer = 0;
        if (angle > 0 && angle < 90) answer = 1;
        else if (angle == 90) answer = 2;
        else if (angle > 90 && angle < 180) answer = 3;
        else if (angle == 180) answer = 4;
        return answer;
    }

    // 짝수의 합
    public int Soluction_9(int n)
    {
        int answer = 0;

        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0) answer += i;
        }

        return answer;
    }

    // 배열의 평균값
    public double Soluction_10(int[] numbers)
    {
        double answer = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            answer += numbers[i];
        }

        return answer / numbers.Length;
    }
}
