
//snack1();
//snack2();
//snack3();
//snack4();
//snack5();

void snack1()
{
    Console.WriteLine("Inserisci il primo numero!");
    var num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Inserisci il secondo numero!");
    var num2 = Convert.ToInt32(Console.ReadLine());

    if(num1 > num2)
    {
        Console.WriteLine("Il primo numero è maggiore!");
    }else if(num1 == num2)
    {
        Console.WriteLine("I due numeri sono uguali!");
    }
    else
    {
        Console.WriteLine("Il secondo numero è più grande!");
    }
}

void snack2()
{
    Console.WriteLine("Inserisci la prima parola!");
    var word1 = Console.ReadLine() ?? "";

    Console.WriteLine("Inserisci la seconda parola!");
    var word2 = Console.ReadLine() ?? "";

    if (word1.Length > word2.Length)
    {
        Console.WriteLine("La prima parola è più lunga!");
    }
    else if (word1.Length == word2.Length)
    {
        Console.WriteLine("Le due parole hanno uguale lunghezza!");
    }
    else
    {
        Console.WriteLine("La seconda parola è più lunga!");
    }
}

void snack3()
{
    var sum = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Inserisci un numero per dieci volte!");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        sum += userNumber;
    }

    Console.WriteLine($"La somma dei numeri inseriti è: {sum}");
}

void snack4()
{
    int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var sum = 0;
    double average;

    for(int i = 0; i < numbers.Length ;i++)
    {
        sum += numbers[i];
    }

    average = sum / numbers.Length;
    Console.WriteLine(average);
}

void snack5()
{
    Console.WriteLine("Inserisci un numero!");
    var userNumber = Convert.ToInt32(Console.ReadLine());
    
    if(userNumber % 2 == 0)
    {
        Console.WriteLine("Il numero inserito è pari!");
    }
    else
    {
        userNumber++;
        Console.WriteLine(userNumber);
    }
}