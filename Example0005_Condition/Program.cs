Console.Write("Как тебя зовут дружище? Напиши: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Машкаааа, привеет!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}