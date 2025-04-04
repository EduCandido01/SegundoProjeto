class program
{
    public static void Main()
    {
        Console.WriteLine("escolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite um número:");
        int num2 = Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("digite um número:");
        int num3 = Convert.ToInt32(Console.ReadLine());


        if (num1 == 1)
        {
            int soma = num2 + num3;
            Console.WriteLine(soma);
        }
        else if (num1 != num3)
        {
            int subtração = num2 - num3;

            Console.WriteLine(subtração);
        }
        else if (num1 != num3)
        {
            int multiplicação = num2 * num3;
            Console.WriteLine(multiplicação);
        }
        else if (num1 != num3)
        {
            int divisão = num2 / num3;
            Console.WriteLine(divisão);
        }
    }
}
