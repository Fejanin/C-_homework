/******************************************************************************
Задайте массив на 10 целых чисел. 
Напишите программу, которая определяет количество чётных чисел в массиве.
*******************************************************************************/

void Main() {
    int[] array = new int[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = rand.Next(1, 100);
    }
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            counter++;
        }
    }
    var str = string.Join(" ", array);
    Console.WriteLine(str); // отображаем содержимое массива
    Console.WriteLine(counter); // решение
}

Main();
