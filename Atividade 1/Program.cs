class program
{
    public static void Main()
    {

        Console.WriteLine("informe um numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 / 2)
        {
            Console.WriteLine("O nunmero é par!");
        }

        else
        {
            Console.WriteLine("O numero é impar!");
        }
    }
}