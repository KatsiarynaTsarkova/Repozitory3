Console.WriteLine("Ведите цифру, обозначающую день недели");
int week = int.Parse(Console.ReadLine());
if (week== 6  || week==7)
{
    Console.WriteLine("Выходной");
}
else
{
     Console.WriteLine("Будний");
}