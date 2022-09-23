// 15

Console.WriteLine("Введите цифру, обозначающую день недели:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
string isWeekend = (dayOfWeek > 0 && dayOfWeek < 8) 
    ? (dayOfWeek == 6 || dayOfWeek == 7) ? "да" : "нет"
    : "Это не день недели:(";

Console.WriteLine($"{dayOfWeek} -> {isWeekend}");
