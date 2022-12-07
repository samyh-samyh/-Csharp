// string Method4(int count, string text)
// {
//     int i=0;
//     string result=String.Empty; // переменная result будет пустой с помощью этой команды

//     while(i<count)
//     {
//         result= result+text
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result=String.Empty; 
    for (int i=0;i<count;i++) {result= result+text;}
    return result;
}
string res = Method4(10, "s");
//Console.WriteLine(res);

for(int i=2;i<=10;i++)
{
    for (int j=2;j<=10;j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine(); //Чтобы тело цикла на выводе прерывалось пустой строкой
}