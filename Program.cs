using System;

namespace thuchanhcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Quanlysanpham quanlysanpham = new Quanlysanpham();

            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("MENU");
                Console.WriteLine("1. Them san pham.");
                Console.WriteLine("2. Hien thi san pham.");
                Console.WriteLine("3. Xoa san pham.");
                Console.WriteLine("4. Thoat.");

                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them san pham.");
                        quanlysanpham.Nhapsanpham();
                        Console.WriteLine("\nThem san pham thanh cong!");
                        break;
                    case 2:
                        if (quanlysanpham.SoLuongSanPham() > 0)
                        {
                            Console.WriteLine("\nHien thi danh sach san pham");
                            quanlysanpham.ShowSanPham(quanlysanpham.getListSanPham());
                        }
                        else
                        {
                            Console.WriteLine("\nkhong co san pham trong danh sach!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nxóa sản phẩm");
                        quanlysanpham.XoaSanPhamm();
                        Console.WriteLine("\nxóa sản phẩm thành công!");
                        break;
                    case 4:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}