Console.WriteLine("Введите трехзначное число");
string treeNum = Console.ReadLine();
if(treeNum.Length != 3)
{
   Console.WriteLine("Неправильное количество символов"); 
}
else
{
    //int Number = int.Parse(treeNum);
    Console.WriteLine("Вторая цифра" + (treeNum[1]));
}