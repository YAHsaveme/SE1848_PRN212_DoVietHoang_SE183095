using DemoLINQ2ObjectModelClass;
using System.Security.Cryptography;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;

ListProduct lp=new ListProduct();
lp.gen_products();

/*Câu 1: Lọc ra các sản phẩm có giá từ a tới b
 */
var result = lp.FilterProductsByPrice(100, 200);
Console.WriteLine("Các sản phẩm có giá từ 100 ->200:");
result.ForEach(x => Console.WriteLine(x));

/*
 * Câu 2: Sắp xếp sản phẩm theo đơn giá tăng dần
 */
var result2 = lp.SortProductsByPriceAsc2();
Console.WriteLine("Các sản phẩm sau khi sắp xếp giá tăng dần:");
result2.ForEach(x => Console.WriteLine(x));
/*
 * Câu 3: Sắp xếp sản phẩm theo đơn giá giảm dần
 */
var result3=lp.SortProductsByPriceDesc();
Console.WriteLine("Các sản phẩm sau khi sắp xếp giá giảm dần:");
result3.ForEach(x => Console.WriteLine(x));

/*Câu 4: Tính tổng giá trị các sản phẩm trong kho hàng
 */
Console.WriteLine("Tổng giá trị kho hàng = "+lp.SumOfValue());

/*
 * Câu 5: Tìm chi tiết sản phẩm khi biết mã sản phẩm:
 */
Product p = lp.SearchProductDetail(30);
if(p!=null )
{
    Console.WriteLine("Tìm thấy sản phẩm, thông tin chi tiết:");
    Console.WriteLine(p);
}
else
{
    Console.WriteLine("Không tìm thấy sản phẩm");
}
/*Câu 6: Viết hàm lọc ra TOP N sản phẩm có trị giá lớn nhất
 */
var result4 = lp.GetTopProducts(3);
Console.WriteLine("Danh sách sản phẩm có trị giá lớn nhất:");
result4.ForEach(x => Console.WriteLine(x+"=>"+x.Quantity*x.Price));