Console.Write(" ВВедите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Паша");
{
    Console.WriteLine("Ура это же Паша !"); 
} 
else  
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}