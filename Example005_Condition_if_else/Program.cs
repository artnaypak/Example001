﻿Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{ 
    Console.WriteLine("Ура, это же Маша!");
} 
else 
{
    Console.WriteLine("Здравствуй, ");
    Console.Write(username);    
}
