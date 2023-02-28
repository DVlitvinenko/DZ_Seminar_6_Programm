using System.Text;
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}

// 2.1 Заполнение массива с клавиатуры

public static void FillArrayKeyboard (int []NameArray)
{
  for(int index = 0; index < NameArray.Length; index++)
  {
    NameArray[index] = Input($"Введите число {index+1}: ");
  }
}

// 3. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}


// 4. Вывод массива

public static void WriteArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}
//5. Суммирование количества чисел больше 0 и вывод
public static void SummPositivNumbers(int []Array)
{
  int summ = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] > 0) summ += 1;
  }
  Console.WriteLine("Количество чисел больше нуля: " + summ);
}

}


 

 
