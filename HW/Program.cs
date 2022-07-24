/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/

/*void Zadacha64()
{
    Console.WriteLine("Введите первое число: ");
    int numberM =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberN =Convert.ToInt32(Console.ReadLine());
    Recursion( numberM, numberN);
     

void Recursion(int numberM, int numberN, int result = 0)
{
    if ( numberM > numberN ) return;
    if ( numberM % 3 ==0 )
    {
    result = numberM;
    Console.Write(result + " ");
    }
    numberM++;
    Recursion( numberM, numberN);
}
}

Zadacha64();*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*void Zadacha66()
{
    Console.WriteLine("Введите первое число: ");
    int numberM =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberN =Convert.ToInt32(Console.ReadLine());
    
    Recursion( numberM, numberN);
    
void Recursion(int numberM, int numberN, int result = 0)
{
    if ( numberM > numberN )    
    {
        Console.Write(result);
        return;
    }  

    result += numberM;       
    numberM++;    
    Recursion( numberM, numberN, result);  
}
}
Zadacha66();*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29*/
void Zadacha68()
{
    Console.WriteLine("Введите первое число: ");
    int numberM =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberN =Convert.ToInt32(Console.ReadLine());      
    Console.Write(Recursion( numberM, numberN));
    int Recursion(int numberM, int numberN)
    {
    if (numberM == 0)
        {
            return numberN + 1;
        } 
    else if (numberN == 0 && numberM > 0)
        {
            return Recursion(numberM - 1, 1);
        } 
    else
        {
            return Recursion(numberM - 1, Recursion(numberM, numberN - 1));
        }
    }
}
Zadacha68();