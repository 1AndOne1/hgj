public class Calc
{
    public int Sum(int x, int y)
    {
        return x + y;
    }
}

public class Requester
{
    Calc calc;

    public Requester(Calc calc)
    {
        this.calc = calc;
    }
    public void req()
    {
        double firstValue, secondValue;
        string action = "";

        Console.WriteLine("Введите первое число: ");
        firstValue = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        secondValue = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
        action = Console.ReadLine();

        switch (action)
        {
            case "+":
                double plus = firstValue + secondValue;
                Console.WriteLine("Результат сложения: " + plus);
                break;
            case "-":
                double minus = firstValue - secondValue;
                Console.WriteLine("Результат вычитания: " + minus);
                break;
            case "*":
                double multi = firstValue * secondValue;
                Console.WriteLine("Результат умножения: " + multi);
                break;
            case "/":
                if (secondValue == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    double div = firstValue / secondValue;
                    Console.WriteLine("Результат деления: " + div);
                }
                break;
            default:
                Console.WriteLine("Ошибка! Неизвестное действие!");
                break;
        }
        Console.ReadLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calc calc = new Calc();
        Requester req = new Requester(calc);
        req.req();
    }
}
