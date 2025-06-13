using OOP2;
using OOP4_Reuse_OOP2;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;

FulltimeEmployee fe=new FulltimeEmployee();
fe.Id = 1;
fe.Name = "Putin";
fe.IdCard = "12345";
fe.Birthday = new DateTime(1952, 12, 25);
Console.WriteLine(fe);
Console.WriteLine("=>AGE=" + fe.Tuoi());