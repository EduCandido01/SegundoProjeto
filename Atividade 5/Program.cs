class program
{
    public static void Main()
    {
        Console.WriteLine("digite um número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine($"O numero {num} é zero");
        }

        else if (num <0) 
        {

            Console.WriteLine($"o nume {num} é negativo");
               
        }

        else if (num >0)
        {

            Console.WriteLine($"o numero {num} é positivo ");

        }
    }
}