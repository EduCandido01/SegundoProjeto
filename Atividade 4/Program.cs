class program
{
    public static void Main()
    {
        Console.WriteLine("digite um numero de 1 a 7");
        int num = Convert.ToInt32( Console.ReadLine());

        switch (num)
        {
            case 1: Console.WriteLine("domingo"); break;
            case 2: Console.WriteLine("segunda - feira"); break;
            case 3: Console.WriteLine("terça - feira"); break;
            case 4: Console.WriteLine("quarta - feira"); break;
            case 5: Console.WriteLine("quinta - feira"); break;
            case 6: Console.WriteLine("sexta - feira"); break;
            case 7: Console.WriteLine("sabado"); break;
            default: Console.WriteLine("numero invalido"); break;
        }

        
    }
}