//                                                                              15.12.2022
// Первая задача

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// if (a > b)
// {
//     Console.WriteLine($"{a} есть ваше максимальное число.");
// }
// else
// {
//        Console.WriteLine($"{b} есть ваше максимальное число.");
// }




// Вторая задача

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);

// int max;

// if (a > b)
// {
//     if (a > c)
//     {
//         max = a;
//     }
//     else
//     {
//         max = c;
//     }
// }
// else 
// {
//     if (b > c)
//     {
//         max = b;
//     }
//     else
//     {
//         max = c;
//     }
// }

// Console.WriteLine($"Из вышевведённых чисел максимальным является {max}.");




// Третья задача

// Console.Clear();
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);

// if (a%2 == 0)
// {
//     Console.WriteLine($"Это невероятно! Число {a} является чётным!");
// }
// else
// {
//     Console.WriteLine($"Увы и ах! Число {a} является нечётным...");
// }




// Четвёртая задача

// Console.Clear();
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);

// int b = 2;

// if (a > 1)
// {
//     while (b <= a) {
//     Console.Write($"{b} ");
//     b = b + 2;
//     }
// }
// else
// {
//     Console.WriteLine($"Введите число побольше.");
// }


//                                                              19.12.2022
// Первая задача


// Console.Clear();
// Console.Write("Введите трёхзначное число: ");
// int a = int.Parse(Console.ReadLine()!);

// if ((a < 100)||(a >= 1000)){
//     Console.WriteLine("Введите ТРЁХЗНАЧНОЕ число!");
// }
// else{
//     Console.WriteLine($"Вторая цифра введённого числа - это {(a/10)%10}.");
// }

// -----------------------------------------------------------------------------------------------------------

// Вторая задача


// Console.Clear();
// Console.Write("Введите число меньше 100 000: ");
// int a = int.Parse(Console.ReadLine()!);

// if ((a >= 100000)){
//         Console.WriteLine("Введите число меньше 100 000, это важно!");
// }
// if (a < 100){
//         Console.WriteLine("Третьей цифры здесь нет. Попробуйте ещё раз.");
//     }
// if ((100 <= a)&&(a < 1000)){
//         Console.WriteLine($"Третья цифра введённого числа - это {a%10}.");
//     }
// if ((1000 <= a)&&(a < 10000)){
//         Console.WriteLine($"Третья цифра введённого числа - это {(a/10)%10}.");
//     }
// if ((10000 <= a)&&(a < 100000)){
//         Console.WriteLine($"Третья цифра введённого числа - это {(a/100)%10}.");
//     }

// -----------------------------------------------------------------------------------------------------------

// Третья задача


// Console.Clear();
// Console.Write("Введите число, соответствующее определённому дню недели: ");
// int a = int.Parse(Console.ReadLine()!);

// if ((a < 1)||(a > 7)){
//         Console.WriteLine("В неделе только СЕМЬ дней!");
//     }
// if ((a >= 1)&&(a < 6)){
//         Console.WriteLine("Увы, сегодня не выходной...");
//     }
// if ((a == 6)||(a == 7)){
//         Console.WriteLine("Да, как раз таки это и есть выходной!");
//     }

// -----------------------------------------------------------------------------------------------------------