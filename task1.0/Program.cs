Console.Clear();
Console.Write("Введите 1-ое число: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число степени: ");
int m=Convert.ToInt32(Console.ReadLine());
int st=n;
for ( int i=1; i<m; i++)
{
    st=st*n;
}
Console.WriteLine(st);