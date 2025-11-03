/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author TRAN PHUC VAN
 */
public class AVLNode {
    public GraphicsCard data;
    public AVLNode left, right;
    public int height;

    public AVLNode(GraphicsCard data) {
        this.data = data;
        this.height = 1;
    }
}
