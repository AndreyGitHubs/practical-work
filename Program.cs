
//string Array = Console.ReadLine(); //получение строки с клавиатуры

// задаю заданный условием массив с имеющимеся значениями
string[] Array = new string[] {"hello", "2", "world", ":-)"};

// создаю новый массив в который будут складываться нужные значения. Длинна нового массив равна длинне заданного массива Array
string[] NewArray = new string [Array.Length];

//Метод печати массива
void PrintArray ()
    {
        Console.Write("[ ");
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write($"{Array[i]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    PrintArray();