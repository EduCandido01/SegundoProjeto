class program
{
    public static void Main()
    {

        Console.WriteLine("escreva de 1 a 7");
        int numero = Convert.ToInt32( Console.ReadLine());

        if (numero == 1 )
        {
            Console.WriteLine("segunda-feira");
        }

        else if (numero == 2)
        {
            Console.WriteLine("terça-feira");
        }

        else if (numero == 3)
        {
            Console.WriteLine("quarta-feira");
        }

        else if (numero == 4)
        {
            Console.WriteLine("quinta-feira");
        }

        else if (numero == 5)
        {
            Console.WriteLine("sexta-feira");
        }

        else if (numero == 6)
        {
            Console.WriteLine("sabado");
        }

        else if (numero == 7)
        {
            Console.WriteLine("domingo");
        }
    }
}
