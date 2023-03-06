//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowNumbers(int num)
{
    Console.Write(num + "  ");
    if(num > 1) ShowNumbers(num - 1);
    if(num < 1) ShowNumbers(num + 1);                
}

ShowNumbers(-1);
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/
/*
int Sum(int m, int n)
{
    if(m >= n) return Sum(m-1, n) + m % 10;
    //if(m <= n) return Sum(m, n-1) + n % 10;
    if(m == n) return m;
    else return 0;
}

int sum = Sum(5,1);
Console.WriteLine(sum);
*/
/*
int Sum(int m, int n)
{
    if(m >= n) return Sum(m-1, n) + m;
    if(m <= n) return Sum(m, n-1) + n;
    if(m == n) return m;
    else return 0;
}

int sum = Sum(5,0);
Console.WriteLine(sum);
*/

/*
5+4+3+2+1=15
5 + 4 = 9
3 + 2 = 5
1 + = 1

1+2+3+4+5=15
1+2=3
3+4=7
5+0=5
*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int Akkerman(int m, int n)
{
    if(m == 0) return n+1;
    if((m != 0 && n == 0)) return Akkerman(m-1,1);
    else return Akkerman(m-1, Akkerman(m, n-1));
}

int akkerman = Akkerman(3,0);
Console.WriteLine(akkerman);
*/


