Console.Write("Введите свое имя:");
string username = Console.ReadLine();

if(username.ToLower() == "мансур")
{
    Console.WriteLine("Здравствуй дорогой");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}