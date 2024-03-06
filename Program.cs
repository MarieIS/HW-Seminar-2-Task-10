Console.Write("Insert a three digit number: ");
int N = int.Parse(Console.ReadLine());
if (N / 100 == 0)
 {
   Console.WriteLine($"{N} is not the three digit number. please try again");
 }
 else
 {
   int digit2 = (N - (N / 100) * 100) / 10;
   Console.WriteLine($"{N} -> {digit2}");
 }