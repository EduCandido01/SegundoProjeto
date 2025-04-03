class program
{
    public static void Main()
    {
        Console.WriteLine("Escreva sua idade: ");
        int idade = Convert.ToInt32( Console.ReadLine());
        
        if (idade <= 17)
        {
            Console.WriteLine("Menor de idade!");
        }

        else
        {
            Console.WriteLine("maior de idade!");
        }
   
    }
}