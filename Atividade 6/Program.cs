class program
{
    public static void Main()
    {
        //• Nota ≥ 9 → "A"  • Nota ≥ 7 → "B"  • Nota ≥ 5 → "C"  • Nota < 5 → "D"
        Console.WriteLine("Digite a nota do aluno: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota > 9)
        {
            Console.WriteLine("Sua nota é A");
        }

        else if (nota > 7)
        {
            Console.WriteLine("Sua nota é B");
        }

        else if (nota > 5)
        {
            Console.WriteLine("Sua nota é C");
        }

        else if (nota < 5)
        {
            Console.WriteLine("Sua nota é D");
        }


    }
}
