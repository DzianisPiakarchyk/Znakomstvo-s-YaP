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

//                                                               22.12.2022
// Первая задача

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int a = int.Parse(Console.ReadLine()!);

// string num = a.ToString();

// if(num.Length == 5){
//     if(num[0] == num [4] && num[1] == num[3]){
//         Console.WriteLine("У вас палиндром! Поздравляем!");
//     }
//     else{
//         Console.WriteLine("Нет, это не палиндром...");
//     }

// }
// else{
//     Console.WriteLine("Введено непятизначное число. Попробуйте ещё раз.");
// }

// ---------------------------------------------------------------------------------------------------------



// Вторая задача

// Console.Clear();
// Console.Write("Введите A-абсциссу: ");
// int x_A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите A-ординату: ");
// int y_A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите A-аппликату: ");
// int z_A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите B-абсциссу: ");
// int x_B = int.Parse(Console.ReadLine()!);
// Console.Write("Введите B-ординату: ");
// int y_B = int.Parse(Console.ReadLine()!);
// Console.Write("Введите B-аппликату: ");
// int z_B = int.Parse(Console.ReadLine()!);

// double dist  = Math.Sqrt(Math.Pow(x_A-x_B, 2) + Math.Pow(y_A-y_B, 2) + Math.Pow(z_A-z_B, 2));

// Console.WriteLine($"Искомое расстояние: {dist:f2}.");

// ---------------------------------------------------------------------------------------------------------



// Третья задача

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// for (int i = 1; i <= num; i++){
//     Console.Write($"{Math.Pow(i, 3)} ");
// }

// -----------------------------------------------------------------------------------------------------------


//                                                               Семинар 4. 12.01.2023

// Первая задача


// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{a} в степени {b} есть {Stepen(a, b)}.");

// // --- Метод ---

// int Stepen (int A, int B){
//     int mult = 1;
//     if (B == 0) return 1;
//     for (int i = 1; i <= B; i++){
//         mult = mult * A;
//     }
//     return mult;
// }

// ---------------------------------------------------------------------------------------------------------


// Вторая задача

// Console.Clear();
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр {a} есть {DigitSum(a)}.");

// // --- Метод ---

// int DigitSum (int num){
//     int sum = 0;
//     while (num > 0){
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }


// ---------------------------------------------------------------------------------------------------------


// Третья задача

// Console.Clear();
// int[] SomeArray = RandomArray(8);
// Console.WriteLine($"[{String.Join(", " , SomeArray)}]");

// // --- Метод ---

// int[] RandomArray (int arr){
//     int[] SomeArray = new int[arr];
//     for (int i = 0; i < arr; i++){
//         SomeArray[i] = new Random().Next(-10000, 10000);
//     }
//     return SomeArray;
// }

// -----------------------------------------------------------------------------------------------------------
