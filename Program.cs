// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine(subject.Length);



// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;
// }
// Console.WriteLine($"Сумма всех оценок: {sum}");
// Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");



// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;
// int allStud = 0;
// foreach (string student in students)
// {
//     Console.WriteLine($"{count += 1}. {student}");
//     allStud += 1;
// }
// Console.WriteLine($"Всего учеников: {allStud}");


// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] += 5;
//     Console.WriteLine(points[i]);
// }



// string[] students = { "Аня", "Ярослав", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number += 1;
// }



// //Задача В
// string word = "Программирование";
// char[] wl = { 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я',
//               'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
// int count = 0;

// foreach (char ch in word)
// {
//     foreach (char v in wl)
//     {
//         if (ch == v)
//         {
//             count += 1;
//         }
//     }
// }

// Console.WriteLine(count);


// //Задача Г
// int[] grades = { 4, 5, 3, 5, 2, 4, 3 };
// int max = grades[0];

// foreach (int g in grades)
// {
//     if (g > max)
//     {
//         max = g;
//     }
// }

// Console.WriteLine(max);


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");



// //Вариант 3. Подсчёт согласных букв

// string word = "программирование";
// int count = 0;

// foreach (char ch in word)
// {
//     if (ch != 'а' && ch != 'е' && ch != 'ё' && ch != 'и' && ch != 'о' &&
//         ch != 'у' && ch != 'ы' && ch != 'э' && ch != 'ю' && ch != 'я')
//     {
//         count += 1;
//     }
// }

// Console.WriteLine(count);


// // Вариант 4. Дорогие товары
int[] gd = { 250, 500, 601, 143, 1500, 855 };
int sum = 0;
int count = 0;
foreach (int mn in gd)
{
    sum += mn;
    if (mn > 500)
    {
        count += 1;
    }
}
Console.WriteLine($"Общая сумма: {sum}, Количество товаров дороже 500р: {count}");