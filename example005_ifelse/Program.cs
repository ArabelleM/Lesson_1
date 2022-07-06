Console.Write("Enter user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Это же Маша");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}cs