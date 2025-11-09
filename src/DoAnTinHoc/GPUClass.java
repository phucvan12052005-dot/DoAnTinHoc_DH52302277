/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DoAnTinHoc;

/**
 *
 * @author TRAN PHUC VAN
 */
public class GPUClass {
    public String manufacturer, productName, bus, memType, gpuChip;
    public int releaseYear, memSize, memBusWidth, gpuClock, memClock, unifiedShader, tmu, rop;
    public String pixelShader, vertexShader;
    public boolean igp;

    private boolean isNumeric(String str) {
        return str != null && !str.isEmpty() && str.matches("\\d+");
    }

    public GPUClass(String[] fields) {
        manufacturer = fields[0];
        productName = fields[1];
        releaseYear = isNumeric(fields[2]) ? Integer.parseInt(fields[2]) : 0;
        memSize = isNumeric(fields[3]) ? Integer.parseInt(fields[3]) : 0;
        memBusWidth = isNumeric(fields[4]) ? Integer.parseInt(fields[4]) : 0;
        gpuClock = isNumeric(fields[5]) ? Integer.parseInt(fields[5]) : 0;
        memClock = isNumeric(fields[6]) ? Integer.parseInt(fields[6]) : 0;
        unifiedShader = isNumeric(fields[7]) ? Integer.parseInt(fields[7]) : 0;
        tmu = isNumeric(fields[8]) ? Integer.parseInt(fields[8]) : 0;
        rop = isNumeric(fields[9]) ? Integer.parseInt(fields[9]) : 0;
        pixelShader = fields[10];
        vertexShader = fields[11];
        igp = fields[12].equalsIgnoreCase("Yes");
        bus = fields[13];
        memType = fields[14];
        gpuChip = fields[15];
    }

    public Object[] toRow() {
        return new Object[] {
            manufacturer, productName, releaseYear, memSize, memBusWidth,
            gpuClock, memClock, unifiedShader, tmu, rop, pixelShader,
            vertexShader, igp, bus, memType, gpuChip
        };
    }

    public String toCSV() {
        return String.join(",",
            manufacturer,
            productName,
            String.valueOf(releaseYear),
            String.valueOf(memSize),
            String.valueOf(memBusWidth),
            String.valueOf(gpuClock),
            String.valueOf(memClock),
            String.valueOf(unifiedShader),
            String.valueOf(tmu),
            String.valueOf(rop),
            String.valueOf(pixelShader),
            String.valueOf(vertexShader),
            igp ? "Yes" : "No",
            bus,
            memType,
            gpuChip
        );
    }
}
