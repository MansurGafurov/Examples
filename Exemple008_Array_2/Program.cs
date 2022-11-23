// index          0   1   2  3   4  5   6  7  8
int [] array = { 11, 26, 33, 4, 33, 6, 8, 88, 33 };

int n = array.Length;
int index = 0;
int find = 33;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine( " Index = " + index );
        break; 
    }
    index ++;
    // или index += 1
    // или index = index + 1
}
