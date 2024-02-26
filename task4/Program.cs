// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую

int n = 123;

if (n < 10)
{
    Console.Write(n);
}
else
{
    while(n > 0)
    {
        int currentDigit = n % 10;
        n /= 10;
        if(n > 0)
        {
            Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}