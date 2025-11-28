using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedList.GPUClass;
using static LinkedList.LinkedList;

namespace LinkedList
{
    public class DanhMucGPU
    {
        #region Khởi Tạo
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
        #endregion

        #region Phương thức
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
        #endregion

        #region Đọc File/Ghi File
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

                    if (parts.Length < 16)
                        Array.Resize(ref parts, 16);

                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (string.IsNullOrWhiteSpace(parts[i]))
                            parts[i] = "N/A";
                        else
                            parts[i] = parts[i].Trim();
                    }

                    try
                    {
                        float releaseYear = float.TryParse(parts[2], out float ry) ? ry : 0;
                        float memSize = float.TryParse(parts[3], out float ms) ? ms : 0;
                        float memBusWidth = float.TryParse(parts[4], out float mbw) ? mbw : 0;
                        float gpuClock = float.TryParse(parts[5], out float gc) ? gc : 0;
                        float memClock = float.TryParse(parts[6], out float mc) ? mc : 0;
                        float unifiedShader = float.TryParse(parts[7], out float us) ? us : 0;
                        float tmu = float.TryParse(parts[8], out float t) ? t : 0;
                        float rop = float.TryParse(parts[9], out float r) ? r : 0;
                        float pixelShader = float.TryParse(parts[10], out float ps) ? ps : 0;
                        float vertexShader = float.TryParse(parts[11], out float vs) ? vs : 0;
                        bool igp = parts[12].ToLower() == "yes";

                        GPUClass gpu = new GPUClass(
                            parts[0],
                            parts[1],
                            parts[13],
                            parts[14],
                            parts[15],
                            releaseYear,
                            memSize,
                            memBusWidth,
                            gpuClock,
                            memClock,
                            unifiedShader,
                            tmu,
                            rop,
                            pixelShader,
                            vertexShader,
                            igp
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
        #endregion

        #region Sắp Xếp (Merge sort)
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
        #endregion

        #region Tìm Kiếm 
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
        #endregion

        #region Lọc Danh Sách
        public LinkedList.Linkedlist<GPUClass> LocKhongTrungTheoThuocTinh(string tenThuocTinh)
        {
            var ketQua = new LinkedList.Linkedlist<GPUClass>();
            var current = dsGPU.GetHead();

            // HashSet để lưu giá trị đã gặp
            HashSet<string> seenValues = new HashSet<string>();

            while (current != null)
            {
                GPUClass gpu = current.Data;
                string value = "";

                switch (tenThuocTinh.ToLower())
                {
                    case "manufacturer":
                        value = gpu.Manufacturer;
                        break;
                    case "productname":
                        value = gpu.ProductName;
                        break;
                    case "bus":
                        value = gpu.Bus;
                        break;
                    case "memtype":
                        value = gpu.MemType;
                        break;
                    case "gpuchip":
                        value = gpu.GpuChip;
                        break;
                    case "releaseyear":
                        value = gpu.ReleaseYear.ToString();
                        break;
                    case "memsize":
                        value = gpu.MemSize.ToString();
                        break;
                    case "membuswidth":
                        value = gpu.MemBusWidth.ToString();
                        break;
                    case "gpuclock":
                        value = gpu.GpuClock.ToString();
                        break;
                    case "memclock":
                        value = gpu.MemClock.ToString();
                        break;
                    case "unifiedshader":
                        value = gpu.UnifiedShader.ToString();
                        break;
                    case "tmu":
                        value = gpu.Tmu.ToString();
                        break;
                    case "rop":
                        value = gpu.Rop.ToString();
                        break;
                    case "pixelshader":
                        value = gpu.PixelShader.ToString();
                        break;
                    case "vertexshader":
                        value = gpu.VertexShader.ToString();
                        break;
                    case "igp":
                        value = gpu.Igp.ToString();
                        break;
                }

                // Nếu chưa gặp giá trị này thì thêm vào kết quả
                if (!seenValues.Contains(value))
                {
                    seenValues.Add(value);
                    ketQua.AddLast(gpu);
                }

                current = current.Next;
            }

            return ketQua;
        }


        public LinkedList.Linkedlist<GPUClass> LocTrungTheoThuocTinh(string tenThuocTinh)
        {
            var ketQua = new LinkedList.Linkedlist<GPUClass>();
            var current = dsGPU.GetHead();

            // Gom nhóm theo giá trị thuộc tính
            Dictionary<string, List<GPUClass>> groups = new Dictionary<string, List<GPUClass>>();

            while (current != null)
            {
                GPUClass gpu = current.Data;
                string value = "";

                switch (tenThuocTinh.ToLower())
                {
                    case "manufacturer": value = gpu.Manufacturer; break;
                    case "productname": value = gpu.ProductName; break;
                    case "bus": value = gpu.Bus; break;
                    case "memtype": value = gpu.MemType; break;
                    case "gpuchip": value = gpu.GpuChip; break;
                    case "releaseyear": value = gpu.ReleaseYear.ToString(); break;
                    case "memsize": value = gpu.MemSize.ToString(); break;
                    case "membuswidth": value = gpu.MemBusWidth.ToString(); break;
                    case "gpuclock": value = gpu.GpuClock.ToString(); break;
                    case "memclock": value = gpu.MemClock.ToString(); break;
                    case "unifiedshader": value = gpu.UnifiedShader.ToString(); break;
                    case "tmu": value = gpu.Tmu.ToString(); break;
                    case "rop": value = gpu.Rop.ToString(); break;
                    case "pixelshader": value = gpu.PixelShader.ToString(); break;
                    case "vertexshader": value = gpu.VertexShader.ToString(); break;
                    case "igp": value = gpu.Igp.ToString(); break;
                }

                if (!groups.ContainsKey(value))
                    groups[value] = new List<GPUClass>();

                groups[value].Add(gpu);

                current = current.Next;
            }

            // Chỉ lấy những nhóm có số lượng > 1
            foreach (var group in groups.Values)
            {
                if (group.Count > 1)
                {
                    foreach (var gpu in group)
                    {
                        ketQua.AddLast(gpu);
                    }
                }
            }

            return ketQua;
        }

        public List<GPUThongKe> LocTrungTheoThuocTinhDistinct(string tenThuocTinh)
        {
            var current = dsGPU.GetHead();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            while (current != null)
            {
                GPUClass gpu = current.Data;
                string value = "";

                switch (tenThuocTinh.ToLower())
                {
                    case "manufacturer": value = gpu.Manufacturer; break;
                    case "productname": value = gpu.ProductName; break;
                    case "bus": value = gpu.Bus; break;
                    case "memtype": value = gpu.MemType; break;
                    case "gpuchip": value = gpu.GpuChip; break;
                    case "releaseyear": value = gpu.ReleaseYear.ToString(); break;
                    case "memsize": value = gpu.MemSize.ToString(); break;
                    case "membuswidth": value = gpu.MemBusWidth.ToString(); break;
                    case "gpuclock": value = gpu.GpuClock.ToString(); break;
                    case "memclock": value = gpu.MemClock.ToString(); break;
                    case "unifiedshader": value = gpu.UnifiedShader.ToString(); break;
                    case "tmu": value = gpu.Tmu.ToString(); break;
                    case "rop": value = gpu.Rop.ToString(); break;
                    case "pixelshader": value = gpu.PixelShader.ToString(); break;
                    case "vertexshader": value = gpu.VertexShader.ToString(); break;
                    case "igp": value = gpu.Igp.ToString(); break;
                }

                if (!counts.ContainsKey(value))
                    counts[value] = 0;
                counts[value]++;

                current = current.Next;
            }

            // Tạo danh sách kết quả distinct
            List<GPUThongKe> ketQua = new List<GPUThongKe>();
            foreach (var kvp in counts)
            {
                ketQua.Add(new GPUThongKe
                {
                    GiaTri = kvp.Key,
                    SoLanLap = kvp.Value
                });
            }

            return ketQua;
        }

        public List<GPUThongKe> TimTatCaMaxTheoThuocTinh(string tenThuocTinh)
        {
            var dsThongKe = LocTrungTheoThuocTinhDistinct(tenThuocTinh);
            if (dsThongKe.Count == 0)
                return new List<GPUThongKe>();
            int maxLap = dsThongKe.Max(x => x.SoLanLap);
            List<GPUThongKe> ketQua = new List<GPUThongKe>();
            foreach (var item in dsThongKe)
            {
                if (item.SoLanLap == maxLap)
                    ketQua.Add(item);
            }
            return ketQua;
        }

        public List<GPUThongKe> TimTatCaMinTheoThuocTinh(string tenThuocTinh)
        {
            var dsThongKe = LocTrungTheoThuocTinhDistinct(tenThuocTinh);

            if (dsThongKe.Count == 0)
                return new List<GPUThongKe>();
            int minLap = dsThongKe.Min(x => x.SoLanLap);
            List<GPUThongKe> ketQua = new List<GPUThongKe>();
            foreach (var item in dsThongKe)
            {
                if (item.SoLanLap == minLap)
                    ketQua.Add(item);
            }

            return ketQua;
        }

        #endregion
    }
}
