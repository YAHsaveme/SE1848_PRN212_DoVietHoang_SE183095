using Lucy_SalesDataManagement;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;
//khai báo chuỗi kết nối tới CSDL:
string connectionString = @"server=THANHTRAN;database=Lucy_SalesData;uid=sa;pwd=123456";
Lucy_SalesDataDataContext context=new 
                    Lucy_SalesDataDataContext(connectionString);
//Câu 1: Lọc ra toàn bộ khách hàng
var dskh = context.Customers.ToList();
Console.WriteLine("--danh sách khách hàng---");
foreach (var d in dskh)
    Console.WriteLine(d.CustomerID+"\t"+d.ContactName);
//Câu 2: Tìm chi tiết thông tin khách hàng
//khi biết mã khách hàng
int mkh = 10;
Customer cust = context.Customers
    .FirstOrDefault(c => c.CustomerID == mkh);
if(cust!=null)
{
    Console.WriteLine("---Chi tiết thông tin khách hàng mã="+mkh);
    Console.WriteLine(cust.CustomerID + "\t" + cust.ContactName);
}
//Câu 3: Từ kết quả của câu 2:
//Lọc ra danh sách các hóa đơn của Khách hàng
//các cột dữ liệu gồm: Mã hóa đơn + Ngày Hóa đơn
if(cust!=null)
{
    var dshd = cust.Orders.Select(od=>new {od.OrderID,od.OrderDate} );
    var dshd2 = from od in cust.Orders
                select new { od.OrderID, od.OrderDate };
    Console.WriteLine("Danh sách hóa đơn của khách hàng:");
    foreach(var od in dshd)
    {
        Console.WriteLine(od.OrderID+"\t"+od.OrderDate.ToString("dd/MM/yyyy"));
    }    
}
//Câu 4: từ kết quả của câu 3
//Bổ sung thêm cột Trị giá của đơn hàng cho mỗi hóa đơn
if (cust != null)
{
    var dshd = cust.Orders
        .Select(od => new { od.OrderID, od.OrderDate,
            TotalValue=od.Order_Details
                        .Sum(odd=>odd.Quantity*odd.UnitPrice*(1-(decimal)odd.Discount)) });
   
    Console.WriteLine("Danh sách hóa đơn của khách hàng:");
    foreach (var od in dshd)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy")+"\t"+od.TotalValue);
    }
}