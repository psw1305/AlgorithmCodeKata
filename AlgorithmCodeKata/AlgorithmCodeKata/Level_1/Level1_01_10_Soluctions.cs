namespace AlgorithmCodeKata.Level_1;

public class Level_01_Soluctions
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
}
