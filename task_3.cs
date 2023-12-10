/******************************************************************************
Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.
*******************************************************************************/

void Main() {
    double[] array = new double[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = rand.NextDouble();
    }
    double diff = 0;
    double minNum = 1;
    double maxNum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > maxNum) {
            maxNum = array[i];
        }
        if (array[i] < minNum) {
            minNum = array[i];
        }
    }
    var str = string.Join(" ", array);
    Console.WriteLine(str); // отображаем содержимое массива
    diff = maxNum - minNum;
    Console.WriteLine(minNum); // отображаем максимум
    Console.WriteLine(maxNum); // отображаем минимум
    Console.WriteLine(diff); // решение
}

Main();


