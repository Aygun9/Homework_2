Console.Write("Insert 3 digit number");
int number= int.Parse(Console.ReadLine());
int balance = number/100+1;
Console.WriteLine("Middle Digit :" + balance);