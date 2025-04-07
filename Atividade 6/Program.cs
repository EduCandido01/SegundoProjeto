class program
{
    public static void Main()
    {
        Console.WriteLine("escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        char num1 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("digite número 1:");
        int num2 = Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("digite número 2:");
        int num3 = Convert.ToInt32(Console.ReadLine());


        if (num1 == '1')
        {
            int soma = num2 + num3;
            Console.WriteLine("Resultado da operação");
            Console.WriteLine(soma);
        }
        else if (num1  == '2')
        {
            int subtração = num2 - num3;
            Console.WriteLine("Resultado da operação");
            Console.WriteLine(subtração);
        }
        else if (num1 == '3')
        {
            int multiplicação = num2 * num3;
            Console.WriteLine("Resultado da operação");
            Console.WriteLine(multiplicação);
        }
        else if (num1 == '4')
        {
            int divisão = num2 / num3;
            Console.WriteLine("Resultado da operação");
            Console.WriteLine(divisão);
        }
    }
}
