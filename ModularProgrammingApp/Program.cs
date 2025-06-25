using System;
using ModularProgrammingLibrary;

namespace ModularProgrammingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите функцию для демонстрации:");
                Console.WriteLine("1. Максимум трех выражений (7.4)");
                Console.WriteLine("2. Подсчет числа в массиве (7.9)");
                Console.WriteLine("3. Подсчет символа в строке (7.10)");
                Console.WriteLine("4. Максимум и количество в массиве (7.11)");
                Console.WriteLine("5. Замена диагонали матрицы на нули (7.16)");
                Console.WriteLine("6. Замена отрицательных в матрице на 1 (7.17)");
                Console.WriteLine("7. Сумма минимальных по строкам (7.18)");
                Console.WriteLine("8. Реверс строки (7.21)");
                Console.WriteLine("9. Добавление префикса к строке (7.22)");
                Console.WriteLine("10. Создание строки из символа (7.23)");
                Console.WriteLine("11. Сумма первых n элементов массива (7.24)");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 11)
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    Console.ReadKey();
                    continue;
                }

                if (choice == 0) break;

                Console.Clear();
                Console.WriteLine($"Демонстрация функции {choice}");

                try
                {
                    switch (choice)
                    {
                        case 1:
                            DemoMaxOfThreeExpressions();
                            break;
                        case 2:
                            DemoCountNumberOccurrences();
                            break;
                        case 3:
                            DemoCountCharOccurrences();
                            break;
                        case 4:
                            DemoFindMaxAndCount();
                            break;
                        case 5:
                            DemoZeroDiagonal();
                            break;
                        case 6:
                            DemoReplaceNegativesWithOnes();
                            break;
                        case 7:
                            DemoSumOfRowMinimals();
                            break;
                        case 8:
                            DemoReverseString();
                            break;
                        case 9:
                            DemoAddPrefixToString();
                            break;
                        case 10:
                            DemoCreateStringFromChar();
                            break;
                        case 11:
                            DemoSumFirstNElements();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        static void DemoMaxOfThreeExpressions()
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());

            double result = MathFunctions.MaxOfThreeExpressions(a, b);
            Console.WriteLine($"Максимум трех выражений: {result}");
        }

        static void DemoCountNumberOccurrences()
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 3, 2, 1, 9 };
            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.Write("Введите число для поиска: ");
            int n = int.Parse(Console.ReadLine());

            int count = ArrayFunctions.CountNumberOccurrences(array, n);
            Console.WriteLine($"Число {n} встречается {count} раз(а)");
        }

        static void DemoCountCharOccurrences()
        {
            string str = "Hello, world! This is a test string.";
            Console.WriteLine("Строка: " + str);

            Console.Write("Введите символ для поиска: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int count = StringFunctions.CountCharOccurrences(str, c);
            Console.WriteLine($"Символ '{c}' встречается {count} раз(а)");
        }

        static void DemoFindMaxAndCount()
        {
            int[] array = { 1, 5, 3, 5, 2, 5, 7, 7, 1, 9 };
            Console.WriteLine("Массив: " + string.Join(", ", array));

            var (max, count) = ArrayFunctions.FindMaxAndCount(array);
            Console.WriteLine($"Максимальный элемент: {max}, встречается {count} раз(а)");
        }

        static void DemoZeroDiagonal()
        {
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            MatrixFunctions.ZeroDiagonal(matrix);

            Console.WriteLine("\nМатрица после замены диагонали:");
            PrintMatrix(matrix);
        }

        static void DemoReplaceNegativesWithOnes()
        {
            int[,] matrix = {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 9 }
            };

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            MatrixFunctions.ReplaceNegativesWithOnes(matrix);

            Console.WriteLine("\nМатрица после замены отрицательных:");
            PrintMatrix(matrix);
        }

        static void DemoSumOfRowMinimals()
        {
            int[,] matrix = {
                { 3, 1, 4 },
                { 2, 5, 1 },
                { 6, 3, 2 }
            };

            Console.WriteLine("Матрица:");
            PrintMatrix(matrix);

            int sum = MatrixFunctions.SumOfRowMinimals(matrix);
            Console.WriteLine($"\nСумма минимальных элементов по строкам: {sum}");
        }

        static void DemoReverseString()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            string reversed = StringFunctions.ReverseString(str);
            Console.WriteLine($"Реверсированная строка: {reversed}");
        }

        static void DemoAddPrefixToString()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            string result = StringFunctions.AddPrefixToString(str);
            Console.WriteLine($"Результат: {result}");
        }

        static void DemoCreateStringFromChar()
        {
            Console.Write("Введите символ: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Введите количество повторений: ");
            int k = int.Parse(Console.ReadLine());

            string result = StringFunctions.CreateStringFromChar(c, k);
            Console.WriteLine($"Результат: {result}");
        }

        static void DemoSumFirstNElements()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Массив: " + string.Join(", ", array));

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = ArrayFunctions.SumFirstNElements(array, n);
            Console.WriteLine($"Сумма первых {n} элементов: {sum}");
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}