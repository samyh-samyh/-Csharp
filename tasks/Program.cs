// Пробелы меняем на черточки
// Маленькие "к" меняем на большие "К"
// Большие "С" меняем на маленькие "с"

// Ясна ли задача?

string text ="Вы также можете расскомментировать код с помощью той же команды."
            +" Выберите код, который в данный момент закомментирован, и выполните"
            +" команду быстрого доступа. Он снова станет незакомментированным";
//string s= "qwerty"
//           012345
//s[3] -обращение к 3му(по факту к 4му) символу строки 

string Replace(string text, char oldValue, char newValue)
{
   string result = String.Empty;
   int length = text.Length;
   for (int i=0; i<length;i++)
   {
    if (text[i] == oldValue) result= result +$"{newValue}";
    else result= result+$"{text[i]}";
   }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText=Replace(text, 'к', 'К');
Console.WriteLine(newText);