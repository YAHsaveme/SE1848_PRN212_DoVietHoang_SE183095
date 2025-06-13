using OOP1;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;
//Tạo đối được Category 1:
Category c1=new Category();
c1.Id = 1;
c1.Name = "Nước mắm";
//xuất thông tin bằng cách gọi hàm:
c1.PrintInfor();
//giả sử ta đổi giá trị trong ô nhớ đó:
c1.Name = "Thuốc trị hôi nách";
Console.WriteLine("Sau khi đổi giá trị:");
c1.PrintInfor();
//Sử dụng lớp Employee
Console.WriteLine("---------EMPLOYEE--------");
Employee e1=new Employee(); 
e1.Id = 1;//gọi setter property của Id
e1.IdCard = "001";//gọi setter property của IdCard
e1.Name = "Tèo";//gọi setter property của Name
e1.Email = "teo@gmail.com";//gọi setter property của Email
e1.Phone = "0981234567";//gọi setter property của Phone
//xuất thông tin:
e1.PrintInfor();
Employee e2 = new Employee()
{
    Id = 2,
    IdCard="001",
    Name="Tý",
    Email="ty@hotmail.com",
    Phone="0913452240"
};
Console.WriteLine("=------Employee 2---------=");
e2.PrintInfor();

Employee e3 = new Employee();
Console.WriteLine("=------Employee 3---------=");
e3.PrintInfor();

//tạo Employee 4:
Console.WriteLine("=------Employee 4---------=");
Employee e4 = new Employee(4, "004", "Tủn", "tun@gmail.com", "0101010101");
e4.PrintInfor();
Console.WriteLine("=------Employee 4 cách 2---------=");
Console.WriteLine(e4);//tự động gọi hàm ToString()

Console.WriteLine("===========CUSTOMER 1=============");
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Nguyễn Thị Lung Linh",
    Email = "lunglinh@gmail.com",
    Phone = "0980000112",
    Address = "Số 1 - Đinh Tiên Hoàng - Quận 1 -HCM"
};
cus1.PrintInfor();
cus1.Address = "Số 2 - Võ Nguyên Giáp - Thủ Đức";
Console.WriteLine("Customer sau khi sửa địa chỉ:");
cus1.PrintInfor();