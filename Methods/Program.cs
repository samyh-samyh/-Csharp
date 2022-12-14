//Вид 1: Ничего не принимают, ничего не возвращают

void Method1() // Важно назвать метод так, чтобы к нему можно было бы легко обратиться, не вспоминая
{
    Console.WriteLine("К примеру, указать здесь автора"); //description of the method
}

Method1(); //launch our method





// Вид 2: ничего не возвращает, но принимает какие-либо аргументы

void Method2(string msg)
{
    Console.WriteLine(msg); //description
}

Method2("Текст сообщения"); //запускает то что описано в методе
//Так же можно указать несколько аргументов, например:
//Method21(string msg, int count)
//   {
//    int i=0;
//    while(i<count)
//       {
//        Console.WriteLine(msg);
//        i++;
//       }
//    }
//
//Method21(count:4, msg: "новый текст"); /сразу же при вызове метода можно менять арументы
//                                       /и не важно в какой последовательности их писать






// Вид 3: Что-то возвращают, но ничего не принимают

int Method3()   // обязательно указываем тип данных которые ожидаем от метода (int, например)
{
    return DateTime.Now.Year;  //return ставим обязательно. Данная команда показывает какой год СЕЙЧАС
}

int year = Method3(); // в переменную year будет положен результат работы метода
Console.WriteLine(year);



//Вид 4: Что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i=0;
    string result=String.Empty; // переменная result будет пустой с помощью этой команды

    while(i<count)
    {
        result= result+text
        i++;
    }
    return result;
}

string res = Method4(10, "текст который будет склеен 10раз");
// вызываем метод с помощью создания новой переменной res с тем же типом данных
Console.WriteLine(res); // эта команда будет печатать то что в переменной(то что запрогали методом)