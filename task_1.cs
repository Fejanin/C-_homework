/******************************************************************************
Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
*******************************************************************************/

void Main() {
    int[] array = new int[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = rand.Next(1, 100); // [0 - 2^31)
    }
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] >= 20 && array[i] <= 90) {
            counter++;
        }
    }
    var str = string.Join(" ", array);
    Console.WriteLine(str); // отображаем содержимое массива
    Console.WriteLine(counter); // решение
 }


Main();
