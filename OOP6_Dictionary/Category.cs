using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Dictionary<int,Product> Products { get; set; }

        public Category() { 
            Products = new Dictionary<int,Product>();
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
        /*Khi quản lý mọi đối tượng ta đều phải đáp ứng
         * đầy đủ tính năng CRUD
         */
        public void AddProduct(Product p)
        {
            //kiểm tra nếu Id của Product chưa tồn tại
            //thì thêm mới:
            if (p== null)
            {
                return;//dữ liệu đầu vào null
            }
            if (Products.ContainsKey(p.Id))
            {
                return;//Id đã tồn tại thì ko thêm
            }
            //thêm mới Product vào Dictionary
            Products.Add(p.Id, p);
        }
        //Xuất toàn bộ Sản phẩm:
        public void PrintAllProducts()
        {
            foreach(KeyValuePair<int,Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }    
        }
        //Lọc các sản phẩm có giá từ min tới max
        public Dictionary<int,Product>
            FilterProductsByPrice(double min, double max)
        {
            return Products
                .Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
        }
        //Sắp xếp sản phẩm theo đơn giá tăng dần:
        public Dictionary<int,Product> SortProductByPrice()
        {
            return Products
                        .OrderBy(item => item.Value.Price)
                        .ToDictionary<int,Product>();
        }
        public Dictionary<int,Product>SortComplex()
        {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item=>item.Value.Price)                
                .ToDictionary<int, Product>();
        }
        public bool UpdateProduct(Product p)
        {
            if(p==null)
                return false;//nhập null sao mà sửa
            if (Products.ContainsKey(p.Id)==false) 
            { 
                return false; //ko thấy sao mà sửa
            }
            //cập nhật giá trị tại ô nhớ chưa p.Id
            Products[p.Id] = p;
            return true;//đánh dấu là sửa thành công
        }
        public bool RemoveProduct(int id)
        {
            if(Products.ContainsKey(id)==false)
                return false;//ko tìm thấy id để xóa
            Products.Remove(id);
            return true;
        }
    }
}
