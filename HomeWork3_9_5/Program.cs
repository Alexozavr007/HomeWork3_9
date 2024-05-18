using System.Text;

class Program {
    public delegate double Delegate(int a, int b, int c);
    static void Main() {
        Console.OutputEncoding = Encoding.Unicode;
        int num1 = 120;
        int num2 = 69;
        int num3 = 23;

        Delegate del;
        del = (a,b,c) => ((double)a + b + c) / 3 ;

        Console.WriteLine($"середнє число чисел: {num1}, {num2}, {num3} = { del(num1, num2, num3)}");
    }
}
