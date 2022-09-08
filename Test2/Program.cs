Console.WriteLine("Введите трехзначное число");
string treeNum = Console.ReadLine();
if(treeNum.Length != 3)
{
   Console.WriteLine("Третьей цифры нет"); 
}
else
{
    //int Number = int.Parse(treeNum);
    Console.WriteLine("Третья цифра" + (treeNum[2]));
}