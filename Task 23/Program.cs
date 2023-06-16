Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] result = new int[N];
for (int i = 1; i <= N; i++)
{
Console.WriteLine(Math.Pow(i , 3));
}
int j = 1;
while(j <= N)
{
    Console.WriteLine(Math.Pow(j , 3));
    j++;
}