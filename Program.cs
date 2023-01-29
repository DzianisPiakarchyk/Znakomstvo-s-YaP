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

// ------------------------------------------------------------- Семинар 5. 16.01.2023 ----------------------------------------------


// ----------------------------------------------------------------- ПЕРВАЯ ЗАДАЧА --------------------------------------------------

// Console.Clear();
// int[] array = SomeArray(14, 100, 999);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"Количество чётных элементов в массиве равно {EvenElements(array)}.");


// ----------------------------------------------------------------- ВТОРАЯ ЗАДАЧА --------------------------------------------------

// Console.Clear();
// int[] array = SomeArray(8, -9, 9);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах, равна {SumOddIndex(array)}.");


// ----------------------------------------------------------------- ТРЕТЬЯ ЗАДАЧА --------------------------------------------------
// Console.Clear();
// int[] array = SomeArray(7, -9, 10);
// Console.Write($"[{String.Join(", ", array)}] --> ");
// int[] halfArray = MultMirrArray(array);
// Console.WriteLine($"[{String.Join(", ", halfArray)}]");


// ----------------------------------------------- Метод произведения зеркальных элементов массива ----------------------------------
int[] MultMirrArray(int[] list){
    int[] halfList = new int[(list.Length + 1) / 2];
    for(int i = 0; i < (list.Length + 1) / 2; i++){
        if(list.Length % 2 == 0){
            halfList[i] = list[i] * list[list.Length - 1 - i];
            }
        else{
            halfList[i] = list[i] * list[list.Length - 1 - i];
            halfList[list.Length / 2] = list[list.Length / 2];
            }  
    }
    return halfList;
}

// ------------------------------------------------------- Метод суммы на нечётных индексах -----------------------------------------
int SumOddIndex(int[] list){   
    int sum = 0;
    for(int i = 1; i < list.Length; i += 2){
        sum += list[i];
    }
    return sum;
}

// --------------------------------------------------------- Метод поиска чётного элемента ------------------------------------------
int EvenElements(int[] list){   
    int count = 0;
    foreach(int el in list){
        if(el % 2 == 0){
            count++;
        }
    } 
    return count;
}

// ------------------------------------------------------ Метод генерирования рандомного массива -------------------------------------
int[] SomeArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


// ------------------------------------------------------------- Семинар 6. 19.01.2023 ----------------------------------------------

// ----------------------------------------------------------------- ПЕРВАЯ ЗАДАЧА --------------------------------------------------

// Console.Clear();
// Console.Write("Введите числа через пробел: ");
// int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// Console.WriteLine($"Между прочим, количество ваших положительных чисел есть {PositiveCount(numbers)}.");

// ---------------------------------------------- Метод подсчёта количества положительных чисел ----------------------------------
int PositiveCount(int[] list){   
    int count = 0;
    for(int i = 0; i < list.Length; i++){
        if(list[i] > 0){
            count++;
        }
    } 
    return count;
}

// ----------------------------------------------------------------- ВТОРАЯ ЗАДАЧА --------------------------------------------------

// Console.Clear();
// Console.Write("Задайте размерность массива (не менее шести, но и большой не нужно): ");
// int a = int.Parse(Console.ReadLine()!);
// int[] array = SomeArray(a, 0, 100);
//     if (a >= 6 && a <= 32){
//         Console.WriteLine($"[{String.Join(", ", array)}]");
//         Console.WriteLine();
//         Console.WriteLine("Отсортированный по возрастанию массив:");
//         ArrayToMax(array);
//         Console.WriteLine($"[{String.Join(", ", array)}]");
//     }
//     else{
//         Console.WriteLine();
//         Console.Write("Размерность, чтобы было нагляднее...");
//     }
// Console.WriteLine();

// ------------------------------------------------------- Метод сортировки массива по возрастанию------------------------------------
void ArrayToMax(int[] list){
    int[] ListToMax = new int[list.Length];
    for (int i = 0; i < list.Length - 1; i++){
        int minPosition = i;
        for (int j = i + 1; j < list.Length; j++){
            if(list[j] < list[minPosition]){
            minPosition = j;
            }
        }
    int temp = list[i];
    list[i] = list[minPosition];
    list[minPosition] = temp;
    }
}

// ------------------------------------------------------------- Семинар 7. 23.01.2023 ----------------------------------------------

// ----------------------------------------------------------------- ПЕРВАЯ ЗАДАЧА --------------------------------------------------

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = SomeDoubleRationalArray(rows, columns, -10, 10);
// PrintDoubleRationalArray(array);

// -------------------------------------------- Метод генерирования рандомного вещественного двумерного массива -------------------------
double[,] SomeDoubleRationalArray(int m, int n, int minValue, int maxValue){
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            res[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
            res[i, j] = Math.Round(res[i, j], 1);
        }
    }
    return res;
}

// ------------------------------------------------- Метод вывода рандомного вещественного двумерного массива ----------------------------

void PrintDoubleRationalArray(double[,] list){
    for (int i = 0; i < list.GetLength(0); i++){
        for (int j = 0; j < list.GetLength(1); j++){
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
}

// ----------------------------------------------------------------- ВТОРАЯ ЗАДАЧА --------------------------------------------------

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = SomeDoubleArray(rows, columns, 0, 9);
// PrintDoubleArray(array);

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);

// if (FindElement(array, a)){
//     Console.WriteLine("Бинго! Данное число среди элементов массива есть.");
// }
// else{
//     Console.WriteLine("Увы! Данного числа среди элементов массива нет.");
// }

// --------------------------------------------------------------- Метод поиска числа в массиве ---------------------------------------

bool FindElement(int[,] list, int a){
    foreach (int el in list){
        if (el == a){
            return true;
        }
    }
    return false;
}

// --------------------------------------------------- Метод генерирования рандомного двумерного массива ------------------------------
int[,] SomeDoubleArray(int m, int n, int minValue, int maxValue){
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// ----------------------------------------------------- Метод вывода рандомного двумерного массива ------------------------------------

void PrintDoubleArray(int[,] list){
    for (int i = 0; i < list.GetLength(0); i++){
        for (int j = 0; j < list.GetLength(1); j++){
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
}

// ------------------------------------------------------------------- ТРЕТЬЯ ЗАДАЧА ----------------------------------------------------

// Console.Clear();
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = SomeDoubleArray(rows, columns, 0, 4);
// PrintDoubleArray(array);

// Console.WriteLine();
// double[] av = ColumnsAverage(array);
// Console.WriteLine($"[{String.Join(", ", av)}]");


// -------------------------------------------------------- Метод среднего арифметического по столбцам -----------------------------------
double[] ColumnsAverage(int[,] list){
    double[] average = new double[list.GetLength(1)];
    double[] sum = new double[list.GetLength(1)];
    for (int i = 0; i < list.GetLength(0); i++){
        for (int j = 0; j < list.GetLength(1); j++){
        sum[j] += list[i, j];
        average[j] = sum[j] / list.GetLength(0);
        }
    }
    return average;
}


// ------------------------------------------------------------- Семинар 9. 29.01.2023 ----------------------------------------------

// ----------------------------------------------------------------- ПЕРВАЯ ЗАДАЧА --------------------------------------------------

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbersFromNTo1(N,1));


// ---------------------------------------------------- Метод вывода натуральных чисел убывательно ----------------------------------
string PrintNumbersFromNTo1(int end, int start){
    if (end == start) return end.ToString();
    return (end + " " + PrintNumbersFromNTo1(end - 1, start));
}

// ----------------------------------------------------------------- ВТОРАЯ ЗАДАЧА --------------------------------------------------

// Console.Write("Введите начало: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.Write("Введите конец: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от {N} до {M} равна {SumNumbersFromNToM(N,M)}.");

// ---------------------------------------------------- Метод подсчёта суммы натуральных чисел --------------------------------------
int SumNumbersFromNToM(int start, int end){
    int sum = start;
    if (start == end) return sum;
    return sum + SumNumbersFromNToM(start + 1, end);
}

// ----------------------------------------------------------------- ТРЕТЬЯ ЗАДАЧА --------------------------------------------------

// Console.Write("Введите m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Akker(m,n));

// ------------------------------------------------------- Метод вычисления функции Аккермана ----------------------------------------
int Akker(int m,int n){
    if (m == 0) return n + 1; 
        if (n == 0) return Akker(m - 1, 1); 
        return Akker(m - 1, Akker(m, n - 1)); 
}

