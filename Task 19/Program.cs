Console.Clear();
Console.WriteLine("Enter a five-digit number:");
string N = Console.ReadLine()!;

if (N.Length != 5)
{
    Console.WriteLine("A five-digit number has not been entered.");
    return;
}
int a = 1;

for(int i = 0; i < N.Length / 2; i++)
{
    if (N[i] != N[N.Length - 1 - i])
    {
        a = 0;
    }
}
if (a == 1)
{
    Console.WriteLine("It's a palindrome");
}
else
{
    Console.WriteLine("It's not a palindome");
}