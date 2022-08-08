while (true)
{
    Console.WriteLine("What is your name?");
    var name = Console.ReadLine();

    Console.WriteLine($"Hi {name}");
    Thread.Sleep(1000);

    Console.WriteLine($"How old are you?");
    var age = Convert.ToInt32(Console.ReadLine());

    if (age > 18)
    {
        Console.WriteLine($"You are biiiiiiig {name}!!");
    }
    else
    {
        Console.WriteLine($"You are babyyyyyyy {name}!!");
    }

    Console.ReadLine();
}
