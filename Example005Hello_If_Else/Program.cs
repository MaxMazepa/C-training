Console.WriteLine ("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
Console.WriteLine("Привет, Маша! Как ты вообще? Норм?");    
}
else
{
    Console.Write("Проваливай в ебеня, ");
    Console.WriteLine(username);
}