using Project;
using System.Globalization;

Console.Write("podaj ilość użytkowników: ");
var number = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbę ocen: ");
var notes = int.Parse(Console.ReadLine());
List<Employee> userList = new List<Employee>();
int[] score = new int[number];
for (int i = 0; i < number; i++)
{
    var n = i + 1;
    Console.WriteLine("Podaj dane " + n + " użytkownika:");
    Console.Write("Imię: ");
    var name = Console.ReadLine();
    Console.Write("Nazwisko: ");
    var surname = Console.ReadLine();
    Console.Write("Wiek w latach: ");
    var age = int.Parse(Console.ReadLine());
    userList.Add(new Employee(i, name, surname, age));
    Console.Write("Wprowadź kolejno " + notes + " ocen/y pracownika, wartości całkowite w skali od 1 do 10: ");
    for (int j = 0; j < notes; j++)
    {
        userList[i].AddScore(int.Parse(Console.ReadLine()));
        Console.Write(" ");
    }
    score[i] = userList[i].Result;
}
var value = 0;
var k = 0;
for (int i = 0; i < number; i++)
{
    if (score[i] > value)
    {
        value = score[i];
        k = i;
    }
}
Console.WriteLine("Najwięcej punktów: " + userList[k].Result + ", otrzymał/a " + userList[k].Name + " " + userList[k].Surname + ", lat " + userList[k].Age);
Console.WriteLine("Naciśnij dowolny klawisz");
Console.ReadKey();
