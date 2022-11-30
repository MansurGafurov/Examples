// Виды методов!

// Вид1 - ничего не возвращают, ничего не принимают!

void Method1 () {
    Console.WriteLine("Автор: Гафуров Мансур!");
}
// Method1(); - вызвать метод1




//Вид2 - Ничего не возвращают, но принимают аргументы!
void Method2 (string msg) {
    Console.WriteLine(msg);
}
//Method2("Hi, Mansur!"); - вызвать метод2





void Method21 (string msg, int count) {
    for(int i = 0; i < count; i++) Console.WriteLine(msg);
}
// Method21("Mansur", 5); - вызвать метод2.1






// Вид 3 - Что-то возвращ, но ничего не принимает!

int Method3() {
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);







// Вид 4 - Что то принимает и что то возвращ.

string Method4(int count, string text) {
    string result = string.Empty;
    for(int i = 0; i < count; i++) 
    {
        result = result + text;
    }
    return result;
}

string res = Method4(6, "Mansur");
Console.WriteLine(res);