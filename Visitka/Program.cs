// Личные данные студента
const string FullName = "Коновалов Александр";
string NameGroup = "ИСП-254";
string spec = "09.02.07";
int course = 2;

// Оценки за 3 работы, нужны для расчёта средней оценки
int firstGrade = 4;
int secondGrade = 5;
int threeGrade = 4;
double averageGrade = (firstGrade + secondGrade + threeGrade) / 3.0;

// Стипендия
const double scholarshipGrade = 4.2;
bool scholarship = averageGrade >= scholarshipGrade;

// Недели
int allWeek = 16;
int pastWeek = 2;

Console.WriteLine("=======ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА=======");
Console.WriteLine($"ФИО: {FullName}");
Console.WriteLine($"Группа: {NameGroup}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Специальность: {spec}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {(int)(averageGrade * 100) / 100.0}"); // умножаем на 100, благодоря int убираем дробную часть, и после делим на 100 и получаем два знака после запятой
Console.WriteLine($"Стипендия положена (>= {scholarshipGrade}): {scholarship}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {allWeek - pastWeek}");
Console.WriteLine("========================================");
