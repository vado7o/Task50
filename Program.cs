// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.WriteLine("Программа, возвращающая значение элемента двумерного массива");

int row = 0;
int column = 0;
int element_row = 0;
int element_column = 0;

AskForInput("row");
AskForInput("column");

int[,] array = FillArray(row, column, 0, 10);

Console.Write("\nCгенерированный массив: \n");
PrintArray(array);

AskForInput("element_row");
AskForInput("element_column");

try
{
    Console.Write("\nЭлемент строки " + element_row + " массива и столбца " + element_column + " массива : " + array[element_row - 1, element_column - 1]);
}
catch
{
    Console.Write("\nЭлемент строки " + element_row + " массива и столбца " + element_column + " массива НЕ СУЩЕСТВУЕТ!!!");
}


///////////////// функции: //////////////////////////////
int[,] FillArray(int row, int column, int min, int max)
{
    int[,] filledArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
        filledArray[i, j] = new Random().Next(min, max);
        }
    }
    return filledArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }   
}

void AskForInput(string str)
{
    while (true)
    {
        if(str == "row")
        {
            Console.Write("\nНапишите - из скольки строк должен состоять массив? :");
        }
        else if(str == "column") 
        {
            Console.Write("\nНапишите - из скольки столбцов должен состоять массив? :");
        }
        else if(str == "element_row")
        {
            Console.Write("\nНапишите номер строки массива, на которой расположен элемент :");
        }
        else if(str == "element_column")
        {
            Console.Write("\nНапишите номер столбца массива, на которой расположен элемент :");
        }
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0)
            {
                if(str == "row")
                {
                    row = number;
                }
                else if(str == "column")
                {
                    column = number;
                }
                else if(str == "element_row")
                {
                    element_row = number;
                }
                else if(str == "element_column")
                {
                    element_column = number;
                }
                break;
            }
            else Console.WriteLine("Некорректно указано количество строк массива!\n");
        }
        else Console.WriteLine("Некорректно указано количество строк массива!\n");
    }
}