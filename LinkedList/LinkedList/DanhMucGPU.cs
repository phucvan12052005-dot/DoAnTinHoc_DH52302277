using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.LinkedList;

namespace LinkedList
{
    public class DanhMucGPU
    {
        private LinkedList.Linkedlist<GPUClass> dsGPU;
        public DanhMucGPU()
        {
            this.dsGPU= new LinkedList.Linkedlist<GPUClass>();
        }
         public LinkedList.Linkedlist<GPUClass>DanhSachGPU
        {
            get { return dsGPU; }
            set { dsGPU= value; }
        }

        public void ThemGPU(GPUClass gpu)
        {
            dsGPU.AddLast(gpu);
        }

        public bool XoaGPU(GPUClass gpu)
        {
            return dsGPU.Remove(gpu);
        }

        public void DuyetDanhSach()
        {
            dsGPU.traverse();
        }

        public int SoLuong()
        {
            return dsGPU.Count();
        }

        public void DocTuFileCSV(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isFirstLine = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    string[] parts = line.Split(',');

                    // Đảm bảo có đúng 16 phần tử, nếu thiếu thì thêm "\"
                    if (parts.Length < 16)
                    {
                        Array.Resize(ref parts, 16);
                        for (int i = 0; i < parts.Length; i++)
                        {
                            if (string.IsNullOrWhiteSpace(parts[i]))
                                parts[i] = "\\";
                        }
                    }

                    try
                    {
                        GPUClass gpu = new GPUClass(
                            parts[0],
                            parts[1],
                            parts[13],
                            parts[14],
                            parts[15],
                            float.TryParse(parts[2], out float releaseYear) ? releaseYear : 0,
                            float.TryParse(parts[3], out float memSize) ? memSize : 0,
                            float.TryParse(parts[4], out float memBusWidth) ? memBusWidth : 0,
                            float.TryParse(parts[5], out float gpuClock) ? gpuClock : 0,
                            float.TryParse(parts[6], out float memClock) ? memClock : 0,
                            float.TryParse(parts[7], out float unifiedShader) ? unifiedShader : 0,
                            float.TryParse(parts[8], out float tmu) ? tmu : 0,
                            float.TryParse(parts[9], out float rop) ? rop : 0,
                            float.TryParse(parts[10], out float pixelShader) ? pixelShader : 0,
                            float.TryParse(parts[11], out float vertexShader) ? vertexShader : 0,
                            parts[12].Trim().ToLower() == "yes"
                        );

                        dsGPU.AddLast(gpu);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi khi đọc dòng: " + line);
                        Console.WriteLine("Chi tiết lỗi: " + ex.Message);
                    }
                }
            }
        }

        public void GhiRaFileCSV(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Ghi dòng tiêu đề
                writer.WriteLine("manufacturer,productName,releaseYear,memSize,memBusWidth,gpuClock,memClock,unifiedShader,tmu,rop,pixelShader,vertexShader,igp,bus,memType,gpuChip");

                var current = dsGPU.GetHead();

                while (current != null)
                {
                    GPUClass gpu = current.Data;

                    string line = string.Join(",",
                        gpu.Manufacturer,
                        gpu.ProductName,
                        gpu.ReleaseYear.ToString(),
                        gpu.MemSize.ToString(),
                        gpu.MemBusWidth.ToString(),
                        gpu.GpuClock.ToString(),
                        gpu.MemClock.ToString(),
                        gpu.UnifiedShader.ToString(),
                        gpu.Tmu.ToString(),
                        gpu.Rop.ToString(),
                        gpu.PixelShader == 0 ? "" : gpu.PixelShader.ToString(),
                        gpu.VertexShader == 0 ? "" : gpu.VertexShader.ToString(),
                        gpu.Igp ? "Yes" : "No",
                        gpu.Bus,
                        gpu.MemType,
                        gpu.GpuChip
                    );

                    writer.WriteLine(line);
                    current = current.Next;
                }
            }
        }

        public bool SuaGPU(GPUClass gpuCu, GPUClass thongTinMoi)
        {
            var current = dsGPU.GetHead();

            while (current != null)
            {
                if (current.Data == gpuCu) // so sánh tham chiếu
                {
                    current.Data = thongTinMoi;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void XoaToanBo()
        {
            dsGPU.Clear();
        }



        public void SapXepTheoThuocTinh(Func<GPUClass, IComparable> chonThuocTinh, bool tangDan = true)
        {
            if (dsGPU.IsEmpty() || dsGPU.Count() == 1) return;

            Node<GPUClass> dummy = new Node<GPUClass>(default(GPUClass));
            dummy.Next = dsGPU.GetHead();

            int n = dsGPU.Count();
            for (int step = 1; step < n; step *= 2)
            {
                Node<GPUClass> prev = dummy;
                Node<GPUClass> curr = dummy.Next;

                while (curr != null)
                {
                    Node<GPUClass> left = curr;
                    Node<GPUClass> right = Split(left, step);
                    curr = Split(right, step);

                    Node<GPUClass> merged = SortedMerge(left, right, chonThuocTinh, tangDan);
                    prev.Next = merged;

                    while (prev.Next != null)
                        prev = prev.Next;
                }
            }

            dsGPU.SetHead(dummy.Next);
        }

        public Node<GPUClass> Split(Node<GPUClass> head, int size)
        {
            for (int i = 1; head != null && i < size; i++)
                head = head.Next;

            if (head == null) return null;

            Node<GPUClass> next = head.Next;
            head.Next = null;
            return next;
        }

        public Node<GPUClass> SortedMerge(Node<GPUClass> a, Node<GPUClass> b, Func<GPUClass, IComparable> chonThuocTinh, bool tangDan)
        {
            Node<GPUClass> dummy = new Node<GPUClass>(default(GPUClass));
            Node<GPUClass> tail = dummy;

            while (a != null && b != null)
            {
                int cmp = chonThuocTinh(a.Data).CompareTo(chonThuocTinh(b.Data));
                if ((tangDan && cmp <= 0) || (!tangDan && cmp > 0))
                {
                    tail.Next = a;
                    a = a.Next;
                }
                else
                {
                    tail.Next = b;
                    b = b.Next;
                }
                tail = tail.Next;
            }

            tail.Next = (a != null) ? a : b;
            return dummy.Next;
        }

        public LinkedList.Linkedlist<GPUClass> TimKiemTheoHang(string tenHang)
        {
            var ketQua = new LinkedList.Linkedlist<GPUClass>();

            var current = dsGPU.GetHead();
            while (current != null)
            {
                if (!string.IsNullOrEmpty(current.Data.Manufacturer) &&
                    current.Data.Manufacturer.Equals(tenHang, StringComparison.OrdinalIgnoreCase))
                {
                    ketQua.AddLast(current.Data);
                }

                current = current.Next;
            }

            return ketQua;
        }

        public LinkedList.Linkedlist<GPUClass> TimKiemTheoTen(string tenSanPham)
        {
            // Tạo danh sách kết quả rỗng
            var ketQua = new LinkedList.Linkedlist<GPUClass>();

            // Duyệt toàn bộ danh sách gốc
            var current = dsGPU.GetHead();
            while (current != null)
            {
                // So sánh tên sản phẩm (không phân biệt hoa thường)
                if (!string.IsNullOrEmpty(current.Data.ProductName) &&
                    current.Data.ProductName.IndexOf(tenSanPham, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    ketQua.AddLast(current.Data);
                }

                current = current.Next;
            }

            return ketQua; // trả về DSLK kết quả
        }

        public LinkedList.Linkedlist<GPUClass> TimKiemTheoNam(float namPhatHanh)
        {
            var ketQua = new LinkedList.Linkedlist<GPUClass>();

            var current = dsGPU.GetHead();
            while (current != null)
            {
                if (current.Data.ReleaseYear == namPhatHanh)
                {
                    ketQua.AddLast(current.Data);
                }
                current = current.Next;
            }

            return ketQua;
        }



    }
}
