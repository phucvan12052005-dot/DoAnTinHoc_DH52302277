using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class GPUClass
    {
        private string manufacturer, productName, bus, memType, gpuChip;
        private float releaseYear,memSize,memBusWidth,gpuClock,memClock,unifiedShader,tmu,rop,pixelShader,vertexShader;
        private bool igp;

        public GPUClass()
        {
            manufacturer = "";
            productName = "";
            bus = "";
            memType = "";
            gpuChip = "";
            releaseYear = 0;
            memSize = 0;
            memBusWidth = 0;
            gpuClock = 0;
            memClock = 0;
            unifiedShader = 0;
            tmu = 0;
            rop = 0;
            pixelShader = 0;
            vertexShader = 0;
            igp = false;
        } 

        public GPUClass(string manufacturer, string productName, string bus, string memType, string gpuChip, float releaseYear, float memSize, float memBusWidth, float gpuClock, float memClock, float unifiedShader, float tmu, float rop, float pixelShader, float vertexShader, bool igp)
        {
            this.manufacturer = manufacturer;
            this.productName = productName;
            this.bus = bus;
            this.memType = memType;
            this.gpuChip = gpuChip;
            this.releaseYear = releaseYear;
            this.memSize = memSize;
            this.memBusWidth = memBusWidth;
            this.gpuClock = gpuClock;
            this.memClock = memClock;
            this.unifiedShader = unifiedShader;
            this.tmu = tmu;
            this.rop = rop;
            this.pixelShader = pixelShader;
            this.vertexShader = vertexShader;
            this.igp = igp;
        }

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Bus { get => bus; set => bus = value; }
        public string MemType { get => memType; set => memType = value; }
        public string GpuChip { get => gpuChip; set => gpuChip = value; }
        public float ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public float MemSize { get => memSize; set => memSize = value; }
        public float MemBusWidth { get => memBusWidth; set => memBusWidth = value; }
        public float GpuClock { get => gpuClock; set => gpuClock = value; }
        public float MemClock { get => memClock; set => memClock = value; }
        public float UnifiedShader { get => unifiedShader; set => unifiedShader = value; }
        public float Tmu { get => tmu; set => tmu = value; }
        public float Rop { get => rop; set => rop = value; }
        public float PixelShader { get => pixelShader; set => pixelShader = value; }
        public float VertexShader { get => vertexShader; set => vertexShader = value; }
        public bool Igp { get => igp; set => igp = value; }



    }
}
