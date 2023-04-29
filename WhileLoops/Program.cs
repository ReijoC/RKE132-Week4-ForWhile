Random rnd  = new Random();
int cpuRandom;

bool loopActive = true;
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"{cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congrats, you won");
        //loopActive = false;
        break;
    }
    else { Console.WriteLine("try again!"); 
    }
}
Console.WriteLine("have a nice day");