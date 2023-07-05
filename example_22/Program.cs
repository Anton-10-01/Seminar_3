/* 17. Напишите программу, которая принимает на вход
число (N) и выдает таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25
2 -> 1, 4
*/

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) {
    TableSquare(number);
} else {
    Console.Write("Ошибка ввода");
}

void TableSquare(int num) {
    int count = 1;
    while (count <= num) {
        Console.WriteLine($"{count, 3} {count * count, 5}");
        count++;
    }
}