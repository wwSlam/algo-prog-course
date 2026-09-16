Console.WriteLine("================================");
Console.WriteLine("        визитка студента"        );
Console.WriteLine("================================");

string fullName = "Подлобков Максим"; // ФИО
string group = "ISP-252"; // группа 
int course = 2; // на каком курсе учиться
double rab1 = 5; //оценка за первую работу
double rab2 = 4; //оценка за вторую работу
double rab3 = 2; //оценка за третью работу
const double stepend = 4; // минимальный балл для стипендии 
bool dasd = true; // бюджетное место
double srAr = (rab1 + rab2 + rab3) / 3; // средний балл работы
bool rrr = srAr >= stepend && dasd; // положена ли стипендия
Console.WriteLine($"ФИО:                        {fullName}");
Console.WriteLine($"Группа:                     {group}");
Console.WriteLine($"Курс:                       {course}");
Console.WriteLine($"----------------------------------");
Console.WriteLine($"Средний балл за три работы: {srAr}");
Console.WriteLine($"Стипендия положена:         {rrr}");
Console.WriteLine($"==================================");