// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа

int num = 12;

int firstDigit = num / 10;
int secondDigit = num % 10;

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

Console.WriteLine(maxDigit);