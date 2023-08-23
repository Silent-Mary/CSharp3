/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */  

Console.Write("Input a 5-digit number: "); 
 
int n = Convert.ToInt32(Console.ReadLine());  
int temp = n; 
int sum = 0;

while (n > 0)      
{      
    int r = n % 10;      
    sum = (sum*10) + r;      
    n = n / 10;      
}  

if (temp == sum) 
{
    Console.WriteLine("is a palindrome");
}     

else  
{
    Console.WriteLine("is not a palindrome");
}         