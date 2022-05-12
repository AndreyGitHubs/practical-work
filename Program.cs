/*
//заполняем массив с клавиатуры
Console.WriteLine("Введиие размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[size];

string[] InputArrayKeyboard()
{
    int index = 0; 
    for (j = 0; j < size; j++)
    {
        Console.WriteLine("Введиие элемент массива");
        Array[index] = Console.ReadLine();
    }
    while (index < size);
    return Array;
}
*/

// задаю заданный условием массив с имеющимеся значениями
string[] Array = new string[] {"hello", "2", "world", ":-)"}; // ок, работает на выходе [ 2 :-)   ].

// создаю новый массив в который будут складываться нужные значения. Длинна нового массив равна длинне заданного массива Array
string[] NewArray = new string [Array.Length];

// метод сканирования массива на наличие элементов <= 3 символам.
void ThreeElementsArray (string [] array, string [] newarray)
{
    int index = 0;
    for (int i = 0; i < Array.Length; i++)
        {
            if (array[i].Length < 4)
            {
                newarray[index] = array[i];
                index++;
            }
        }
}

//Метод печати массива
void PrintArray (string [] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}");
        }
        Console.Write("]");
        Console.WriteLine();
    }

//InputArrayKeyboard(); // заполнение массива с клавиатуры
Console.WriteLine("Заданый массив");
PrintArray(Array);
ThreeElementsArray(Array, NewArray);
Console.WriteLine("Обработанный массив");
PrintArray(NewArray);