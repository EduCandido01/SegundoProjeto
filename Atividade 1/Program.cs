class program
{
    public static void Main()
    {

        Console.WriteLine("informe um numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine($"O nunmero {num1} é par");
        }

        else
        {
            Console.WriteLine($"O numero {num1} é impar" );

        }
    }
}
