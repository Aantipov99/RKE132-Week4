Random rnd = new Random();
int cpuRandom;

bool LoopActive = true; //bool-true/false

while(LoopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess.Enter a number 1-3");
    int UserNumber = Int32.Parse(Console.ReadLine());

    if (UserNumber == cpuRandom)
  {
        Console.WriteLine("Congratulations, you won!");
        //LoopActive = false;
        break;
  } 
    else
  {
        Console.WriteLine("Oops. Try again.");
  }
 }
Console.WriteLine("Have a nice day!");