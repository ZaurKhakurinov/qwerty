Console.WriteLine("введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Сonsole.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
