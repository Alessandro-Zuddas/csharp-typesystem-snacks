
snack1();

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
