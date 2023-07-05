/* 17. Напишите программу, которая по заданному номеру четверти,
показывает дапазон возможных координат в этой четверти (x и y)
*/

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());


string range = Range (number);
string result = range == null
            ? "Введены некоректные координаты"
            : $"Указанные координаты соответствуют четверти {range}";

Console.WriteLine(result);

string Range (int num) {
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

