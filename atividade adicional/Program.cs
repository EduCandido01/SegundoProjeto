class program
{
    public static void Main()
    {
        Console.WriteLine("Coloque o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Coloque o primeiro número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1 - soma: ");
        Console.WriteLine("2 - subtração: ");
        Console.WriteLine("3 - multiplicação: ");
        Console.WriteLine("4 - divisão: ");
        char opcao = Convert.ToChar(Console.ReadLine());

        switch (opcao)
        {
            case '1': Console.WriteLine("resultado: " + (num1 + num2));
                break;
            case '2': Console.WriteLine("resultado: " + (num1 - num2));
                break;
            case '3': Console.WriteLine("resultado: " + (num1 * num2));
                break;
            case '4': 
                if (num2 == 0)
                {
                    Console.WriteLine("Operação impossivel ");
                }

                else { 
                Console.WriteLine("resultado: " + (num1 / num2));
                }
                break;
            default: Console.WriteLine("Erro de digitação"); 
                break;
        }


    }
}