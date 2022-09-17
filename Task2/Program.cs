// Написать программу масштабирования фигуры 
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) 
// например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
// В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

int[] figure = new int[4];
Console.WriteLine("Введите коэффициент масштабирования: ");
int k = int.Parse(Console.ReadLine() ?? "0");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Scale(int[] array)
{
    Console.Write("Масштабированные координаты: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= k;
        Console.Write($"{array[i]} ");
    }
}

FillArray(figure);
PrintArray(figure);
Scale(figure);