using System;
using System.Collections.Generic;

namespace thuchanhcsharp
{
    class Quanlysanpham
    {
        private List<Sanpham> Listsanpham = null;

        public Quanlysanpham()
        {
            Listsanpham = new List<Sanpham>();
        }

        public int SoLuongSanPham()
        {
            int Count = 0;
            if (Listsanpham != null)
            {
                Count = Listsanpham.Count;
            }
            return Count;
        }

        public void Nhapsanpham()
        {
            Sanpham sp = new Sanpham();

            Console.Write("Nhap id san pham: ");
            sp.ID = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten san pham: ");
            sp.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap gia san pham ");
            sp.Price = Convert.ToString(Console.ReadLine());

            Listsanpham.Add(sp);

        }
        public void ShowSanPham(List<Sanpham> listSP)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} ",
                  "ID", "Name", "Price");
            // hien thi danh sach sinh vien
            if (listSP != null && listSP.Count > 0)
            {
                foreach (Sanpham sp in listSP)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} ",
                                      sp.ID, sp.Name, sp.Price);
                }
            }
            Console.WriteLine();
        }

        public void XoaSanPhamm()
        {
            Console.WriteLine("ID sản phẩm cần xóa là");
            Sanpham sp = new Sanpham();
            sp.ID = Convert.ToString(Console.ReadLine());
            Listsanpham.Remove(sp);
        }
        public List<Sanpham> getListSanPham()
        {
            return Listsanpham;
        }


    }
}
