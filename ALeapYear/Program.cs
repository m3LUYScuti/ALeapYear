Console.WriteLine("Sheiyvanet weli nakianobis gasagebad:");


            int Weli = int.Parse(Console.ReadLine());

if (Weli % 4 == 0)
{
    Console.WriteLine($"{Weli} aris nakiani weli");
}
else if (Weli % 100 != 0)
{
    Console.WriteLine($"{Weli} ar aris nakiani weli");
}
else if (Weli % 400 != 0)
{
    Console.WriteLine($"{Weli} ar aris nakiani weli");
}
else if (Weli % 4 != 0)
{
    Console.WriteLine($"{Weli} ar aris nakiani weli");
}
else
{
    Console.WriteLine("Araswori tarigi");
}
   

        Console.ReadLine();
