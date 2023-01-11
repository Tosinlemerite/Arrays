// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] Fibonacci;

string ans = "yes";
long n = 0;

while (ans.ToLower() == "yes" || ans.ToLower() == "y")
{

  Console.Clear();
  Console.Beep();
  Console.WriteLine("*******************************************U");
  Console.WriteLine("Programe to compute sum of fibonacci numbers");
  Console.WriteLine("********************************************");
  Console.WriteLine();

  {

    Console.Write("Fibonacci number:");
    n = Convert.ToInt32(Console.ReadLine());
    Fibonacci = new int[n];
    Fibonacci[0] = 0;
    Fibonacci[1] = 1;

    for (int i = 2; i < n; ++i)
    {
      Fibonacci[i] = Fibonacci[i - 2] + Fibonacci[i - 1];
    }
    
    Console.Beep();
    for (int i = 0; i < n; i++)
    {
      Console.Write(Fibonacci[i] + " ");
    }
    
    Console.WriteLine();
    Console.Beep();
    Console.Write("Do you want to continue? Yes(Y) | No(N): ");

    ans = Console.ReadLine();
  }

  Console.WriteLine();
  Console.Beep();
  Console.WriteLine("Thank you for using this app.");


}

// loops that store prime numbers, evem numbers, odd numbers, in an array
//Program should have input: even numbers, odd numbers and prime numbers
//Ask the numbers of each odd, even and prime numbers to be generated
