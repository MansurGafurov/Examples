int Fibocci (int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibocci(n - 1) + Fibocci(n - 2);
}
for(int i = 1; i < 30; i++)
{
    Console.WriteLine(Fibocci(i));
}

