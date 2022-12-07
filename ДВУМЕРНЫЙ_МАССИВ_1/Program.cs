
void PrintArray (int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int y = 0; y < matr.GetLength(1); y++)
        {
            matr[i, y] += 1; 
            Console.Write($"{matr[i, y]} ");
        }
    Console.WriteLine();    
    }
}

void FullArray (int[,] matr)
{
    for(int x = 0; x < matr.GetLength(0); x++)
    {
        for(int y = 0; y < matr.GetLength(1); y++)
        {
            matr[x, y] = new Random().Next(1, 10);
        }
    }
}




int[,] matrix = new int[3, 6];
PrintArray(matrix);
Console.WriteLine();
FullArray(matrix);
PrintArray(matrix);


// string[,] table = new string[2, 4];
// for(int rows = 0; rows < table.GetLength(0); rows++)
// {
//     for(int columns = 0; columns < table.GetLength(1); columns++)
//     {
//         table[rows, columns] = "слово";
//         Console.Write($"{table[rows, columns]} ");
//     }
// Console.WriteLine();    
// }
