using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // 1) Chuyển linked list sang List
            var tempList = new List<GPUClass>();
            var current = dsGPU.GetHead();
            while (current != null)
            {
                tempList.Add(current.Data);
                current = current.Next;
            }

            // 2) Sắp xếp
            if (tangDan)
                tempList.Sort((a, b) =>
                {
                    var va = chonThuocTinh(a);
                    var vb = chonThuocTinh(b);
                    // xử lý null an toàn
                    if (va == null && vb == null) return 0;
                    if (va == null) return -1;
                    if (vb == null) return 1;
                    return va.CompareTo(vb);
                });
            else
                tempList.Sort((a, b) =>
                {
                    var va = chonThuocTinh(a);
                    var vb = chonThuocTinh(b);
                    if (va == null && vb == null) return 0;
                    if (va == null) return 1;
                    if (vb == null) return -1;
                    return vb.CompareTo(va);
                });

            // 3) Ghi lại vào linked list
            dsGPU.Clear();
            foreach (var gpu in tempList)
                dsGPU.AddLast(gpu);
        }





    }
}
