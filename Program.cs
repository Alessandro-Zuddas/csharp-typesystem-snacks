﻿
start();

void start()
{

    Console.WriteLine();

    Console.WriteLine("Quale snack vorresti usare?");

   for(int i = 1; i <= 12; i++)
   {
        Console.WriteLine($"Snack{i}");
   }

   Console.WriteLine();

   Console.WriteLine("Digita il numero!");
   var userNumber = Convert.ToInt32(Console.ReadLine());

   switch (userNumber)
   {
       case 1:
           snack1();
           start();
           break;

       case 2:
          snack2();
            start();
            break;

        case 3:
            snack3();
            start();
            break;

        case 4:
            snack4();
            start();
            break;

        case 5:
            snack5();
            start();
            break;

        case 6:
            snack6();
            start();
            break;

        case 7:
            snack7();
            start();
            break;

        case 8:
            snack8();
            start();
            break;

        case 9:
            snack9();
            start();
            break;

        case 10:
            snack10();
            start();
            break;

        case 11:
            snack11();
            start();
            break;

        case 12:
            snack12();
            start();
            break;
    }
}

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

void snack6()
{
    string[] members = { "Alessandro", "Francesco", "Simone", "Riccardo", "Matteo" };

    Console.WriteLine("Inserisci il tuo nome per vedere se sei in lista!");
    var userName = Console.ReadLine();

    var wasFound = false;

    foreach(string member in members)
    {
        if(userName == member)
        {    
            Console.WriteLine("Benvenuto alla festa!");
            wasFound = true;
        }
    }

    if (!wasFound)
    {
        Console.WriteLine("Mi dispiace non sei sulla lista");
    }
}

void snack7()
{
    int[] numbers = { 6 };

    for(int i = 0; i < 5 ;i++)
    {
        Console.WriteLine("Inserisci un numero per 6 volte!");
        var userNumber = Convert.ToInt32(Console.ReadLine());
        
        if(userNumber % 2 != 0)
        {
            numbers[i] = userNumber;
        }
    }


    Console.WriteLine("I numeri dispari sono: ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

void snack8()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
    var sum = 0;

    for(int i = 0; i < numbers.Length ; i++)
    {
        if (i % 2 != 0)
        {
            sum += numbers[i];
        }
    }

    Console.WriteLine($"La somma dei numeri in posizioni dispari è: {sum}");
}

void snack9()
{
    int[] numbers = { 50 };
    var sum = 0;
    int i = 0;

    while(sum < 50)
    {
        Console.WriteLine("Inserisci dei numeri e verranno sommati!");
        var userNumber = Convert.ToInt32(Console.ReadLine());

        if (userNumber > 0)
        {
            numbers[i] = userNumber;
        }

        i++;
    }

    Console.WriteLine("Fine della corsa siamo a 50!");
}

void snack10()
{
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];

        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }

        foreach (var num in ints)
        {
            Console.Write($"{num}; ");
        }
    }
}

void snack11()
{
    Console.WriteLine("Inserisci la prima parola!");
    var word1 = Console.ReadLine() ?? "";
    Console.WriteLine("Inserisci la seconda parola!");
    var word2 = Console.ReadLine() ?? "";

    compareString(word1, word2);

    void compareString(string word1, string word2)
    {
        if(word1.Length == word2.Length)
        {
            Console.WriteLine($"La parole sono di uguale lunghezza: {word1} , {word2}");
        }
        else if(word1.Length > word2.Length)
        {
            Console.WriteLine($"La parola più lunga è: {word1}");
        }
        else
        {
            Console.WriteLine($"La parola più lunga è: {word2}");
        }
    }
}

void snack12()
{
    Console.WriteLine("Inserisci un numero per sapere se è pari o dispari!");
    var number = Convert.ToInt32(Console.ReadLine());

    oddOrEven(number);

    void oddOrEven(int number)
    {
        if(number % 2 == 0)
        {
            Console.WriteLine($"{number} è pari!");
        }
        else if (number % 2 != 0)
        {
            Console.WriteLine($"{number} è dispari!");
        }
    }

}