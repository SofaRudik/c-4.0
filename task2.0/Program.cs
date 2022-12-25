Console.Clear();
Console.Write("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
int sum=0;
while(n>0)
{
    int m=n%10;
    n=n/10;
    sum=sum+m;

}
Console.WriteLine(sum);

