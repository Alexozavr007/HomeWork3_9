using System.Text;

public delegate double DelegateCalculation(int x, int y);

class Program {
    static void Main() {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Введіть знак операції (1 - додавання, 2 - віднімання, 3 - множення, 4 - ділення)");
        int a = Convert.ToInt32(Console.ReadLine());
        int number1 = 12;
        int number2 = 56;

        DelegateCalculation targetCalculation;

        string op;

        switch (a) {
            case 1:
                targetCalculation = (x, y) => x + y;
                op = "+";
                break;

            case 2:
                targetCalculation = (x, y) => x - y;
                op = "-";
                break;

            case 3:
                targetCalculation = (x, y) => x * y;
                op = "*";
                break;

            case 4:
                targetCalculation = (x, y) => {
                    if (y == 0)
                        throw new Exception("Поділ на 0 неможливий");
                    return (double)x / y;
                };
                op = "/";
                break;

            default:
                Console.WriteLine("неочікуване значення");
                return;
        }
        Console.WriteLine($"{number1} {op} {number2} = {targetCalculation(number1, number2)}");
    }
}