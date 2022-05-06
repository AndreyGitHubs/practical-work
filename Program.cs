
//string Array = Console.ReadLine(); //получение строки с клавиатуры

// задаю заданный условием массив с имеющимеся значениями
string[] Array = new string[] {"hello", "2", "world", ":-)"};

// создаю новый массив в который будут складываться нужные значения. Длинна нового массив равна длинне заданного массива Array
string[] NewArray = new string [Array.Length];

void all (string [] array, string [] newarray)
{

}

//Метод печати массива
void PrintArray (string [] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    
PrintArray(Array);
all(Array, NewArray);
PrintArray(NewArray);