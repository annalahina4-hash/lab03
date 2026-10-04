Console.WriteLine( "Банковский счёт");
double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");
balance += 500; // пополнение
Console.WriteLine($"После пополнения на 500: {balance}");
balance -= 200; // покупка
Console.WriteLine($"После покупки на 200: {balance}");
balance *= 1.05; // начисление 5% процентов
Console.WriteLine($"После начисления 5%: {balance}");
balance /= 2; // разделили счёт пополам с партнёром
Console.WriteLine($"После деления пополам: {balance}");

Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");
int lessonNumber = 1;
Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
Console.WriteLine($"После этого lessonNumber = {lessonNumber}");
int weekNumber = 1;
Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
Console.WriteLine($"После этого weekNumber = {weekNumber}");

Console.WriteLine();
Console.WriteLine("Практическая ловушка");
int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");

//step13
Console.WriteLine();
Console.WriteLine( "Логические операторы");
bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;
bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;
Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
Console.WriteLine($"Нет долгов: {isDebtFree}");

Console.WriteLine();
Console.WriteLine("Короткое замыкание");
bool CheckAndPrint(string label, bool value) {
Console.WriteLine($"Вычисляется: {label}");
return value;
}
Console.WriteLine("Проверяем && (первый операнд false):");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

//самостоятельные
//1
Console.WriteLine();
Console.WriteLine("Чётное или нечётное");
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine($"Число {number} чётное: {isEven}");

//2
Console.WriteLine();
Console.WriteLine("Инкремент в выражении");
//Случай 1: постфикс в отдельной строке
int a = 5;
int b = a++;
//a++ сначала отдаёт старое значение в b, потом увеличивает a
Console.WriteLine($"a = {a}, b = {b}"); // a = 6, b = 5

//Случай 2: префикс в отдельной строке
int c = 5;
int d = ++c;
//++c сначала увеличивает c, потом отдаёт новое значение d
Console.WriteLine($"c = {c}, d = {d}"); // c = 6, d = 6

//Случай 3: постфикс прямо внутри вывода
int e = 10;
Console.WriteLine($"e++ выводит: {e++}");
Console.WriteLine($"После этого e = {e}");

//3
Console.WriteLine();
Console.WriteLine("Калькулятор скидки");

Console.Write("Введите сумму покупки: ");
double total = double.Parse(Console.ReadLine());
Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
int cardInput = int.Parse(Console.ReadLine());
bool hasCard = (cardInput == 1);
Console.Write("Введите количество товаров в чеке: ");
int itemsCount = int.Parse(Console.ReadLine());
bool condition1 = total >= 3000 && itemsCount >= 3;
bool condition2 = hasCard;
bool eligibleForDiscount = condition1 || condition2;

Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Сумма >= 3000 и товаров >= 3: {condition1}");
Console.WriteLine($"Есть карта постоянного клиента: {condition2}");
Console.WriteLine($"Скидка положена: {eligibleForDiscount}");
