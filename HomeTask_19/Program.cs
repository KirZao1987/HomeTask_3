Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
int[] d = new int[5];
for (int i = 0; i < 5; i++)
{
  d[i] = n % 10;
  n /= 10;
}
bool Palindrom = true;
for (int i = 0; i < 2; i++)
{
  if (d[i] != d[4 - i]){
    Palindrom = false;
    break;
  }
}
if (Palindrom)
  Console.WriteLine("Число является палиндромом");
else
  Console.WriteLine("Число не является палиндромом");