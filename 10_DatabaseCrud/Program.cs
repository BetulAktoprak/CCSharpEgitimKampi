using System;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GQ3I60J\\MSSQLSERVER01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Category (CategoryName) values (@p1)", connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //Console.Write("Ürün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GQ3I60J\\MSSQLSERVER01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Product (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);

            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p1", productPrice);
            //command.Parameters.AddWithValue("@p1", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GQ3I60J\\MSSQLSERVER01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("select *from Product", connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable dataTable = new DataTable();

            //adapter.Fill(dataTable);
            //connection.Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün id: ");
            //int productId = int.Parse(Console.ReadLine());  

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GQ3I60J\\MSSQLSERVER01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From Product where ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi başarılı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürün id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GQ3I60J\\MSSQLSERVER01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("update Product set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Günceleme işlemi başarılı");

            #endregion

            Console.ReadLine();
        }
    }
}
