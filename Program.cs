
string ans = string.Empty;
do
{
    Console.Clear();
    Console.Beep();
    Console.WriteLine("*********************************************");
    Console.WriteLine("sum of even numbers in a series of N integers");
    Console.WriteLine("*********************************************");

    int i, num, totlSum = 0;
    
    // The number of integers N = num

    Console.Beep();
    Console.WriteLine();
    Console.Write("Enter a number: ");
    num = Convert.ToInt32(Console.ReadLine());

    for (i = 2; i <= num; i++)
    {
        int mod = i % 2;

        if (mod == 0)
        {

            totlSum += i;

        }
    }
    Console.WriteLine();
    Console.Beep();
    Console.WriteLine("Total sum of all even numbers less or equal to " + num + " is: " + totlSum);
    Console.WriteLine();


    Console.Beep();
    Console.WriteLine();
    Console.Write("Do you want to continue Yes(Y) or No(N): ");
    ans = Console.ReadLine();

} while (ans.ToLower() == "yes" || ans.ToLower() == "y");

Console.Beep();
Console.WriteLine("Thank you for using my app!");
Console.WriteLine();
Console.WriteLine();

