
void Zadacha()
{
 /*
 Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
 либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 Пример:
 ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
 ["1234", "1567", "-2", "computer science"] -> ["-2"]
 ["Russia", "Denmark", "Kazan"] -> []
 */






 string[] FerstArray = new string[4] {"hello", "2", "world", ":-)"};
 string[] SecondArray = new string[FerstArray.Length];
 void SecondArrayWithIF(string[] FerstArray, string[] SecondArray)
 {
     int count = 0;
     for (int i = 0; i < FerstArray.Length; i++)
     {
     if(FerstArray[i].Length <= 3)
         {
         SecondArray[count] = FerstArray[i];
         count++;
         }
     }
 }
 void PrintArray(string[] array)
 {
     for (int i = 0; i < array.Length; i++)
     {
         Console.Write($"{array[i]} ");
     }
     Console.WriteLine();
 }
 SecondArrayWithIF(FerstArray, SecondArray);
 PrintArray(SecondArray);
}

Zadacha();
