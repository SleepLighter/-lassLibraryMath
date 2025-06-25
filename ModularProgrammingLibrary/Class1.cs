using System;

namespace ModularProgrammingLibrary
{
    public static class MathFunctions
    {
        // 7.4. Возвращает максимум трех выражений
        public static double MaxOfThreeExpressions(double a, double b)
        {
            double x = Math.Pow(Math.Cos(a + b), 2);
            double y = Math.Sin(a + b);
            double z = (a + b) / 2;

            return Math.Max(x, Math.Max(y, z));
        }
    }

    public static class ArrayFunctions
    {
        // 7.9. Подсчет количества вхождений числа в массиве
        public static int CountNumberOccurrences(int[] array, int n)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num == n) count++;
            }
            return count;
        }

        // 7.11. Максимальный элемент и количество максимумов
        public static (int max, int count) FindMaxAndCount(int[] array)
        {
            if (array.Length == 0) return (0, 0);

            int max = array[0];
            int count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
                else if (array[i] == max)
                {
                    count++;
                }
            }

            return (max, count);
        }

        // 7.24. Сумма первых n элементов массива
        public static int SumFirstNElements(int[] array, int n)
        {
            if (n <= 0) return 0;
            if (n > array.Length) n = array.Length;

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }

    public static class MatrixFunctions
    {
        // 7.16. Замена элементов диагонали матрицы на нули
        public static void ZeroDiagonal(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = 0;
            }
        }

        // 7.17. Замена всех отрицательных чисел матрицы на единицы
        public static void ReplaceNegativesWithOnes(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
        }

        // 7.18. Сумма минимальных элементов по строкам
        public static int SumOfRowMinimals(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                sum += min;
            }

            return sum;
        }
    }

    public static class StringFunctions
    {
        // 7.10. Подсчет количества вхождений символа в строке
        public static int CountCharOccurrences(string str, char c)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (ch == c) count++;
            }
            return count;
        }

        // 7.21. Реверс строки
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7.22. Добавление символов в начало строки
        public static string AddPrefixToString(string str)
        {
            return "++++-----" + str;
        }

        // 7.23. Создание строки из повторяющихся символов
        public static string CreateStringFromChar(char c, int k)
        {
            return new string(c, k);
        }
    }
}