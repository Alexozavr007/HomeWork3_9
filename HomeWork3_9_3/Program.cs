class Program {

    public delegate int IntDelegate();

    static void Main() {

        var avg = (IntDelegate[] methods) => {
            int totalSumm = 0;
            for (int i=0; i < methods.Length; i++) {
                totalSumm += methods[i]();
            }

            return (double)totalSumm / (methods.Length);
        };

        IntDelegate m1 = () => 2;
        IntDelegate m2 = () => 7;

        var result = avg(new[] { m1, m2 });
        Console.WriteLine(result);
    }

}