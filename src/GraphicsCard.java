/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author TRAN PHUC VAN
 */
public class GraphicsCard {
    public String manufacturer;
    public String productName;
    public int releaseYear;
    public double memSize;
    public int memBusWidth;
    public int gpuClock;
    public int memClock;
    public int unifiedShader;
    public int tmu;
    public int rop;
    public int pixelShader;
    public int vertexShader;
    public boolean igp;
    public String bus;
    public String memType;
    public String gpuChip;
    
    private boolean isNumeric(String str) {
    return str != null && !str.isEmpty() && str.matches("\\d+");
}

    private int parseIntSafe(String value) {
    try {
        return Integer.parseInt(value.trim());
    } catch (Exception e) {
        return 0; // hoặc giá trị mặc định khác
    }
}

    
    public GraphicsCard(String[] data){
        this.manufacturer=data[0];
        this.productName=data[1];
        this.releaseYear= isNumeric(data[2]) ? Integer.parseInt(data[2]) : 0;
        this.memSize=Double.parseDouble(data[3]);
        this.memBusWidth=parseIntSafe(data[4]);
        this.gpuClock=parseIntSafe(data[5]);
        this.memClock=parseIntSafe(data[6]);
        this.unifiedShader=parseIntSafe(data[7]);
        this.tmu=parseIntSafe(data[8]);
        this.rop=parseIntSafe(data[9]);
        this.pixelShader=parseIntSafe(data[10]);
        this.vertexShader=parseIntSafe(data[11]);
        this.igp=Boolean.parseBoolean(data[12]);
        this.bus=data[13];
        this.memType=data[14];
        this.gpuChip=data[15];       
    }     
    
    public String toString() {
        return productName + " (" + manufacturer + ")";
    }
}
