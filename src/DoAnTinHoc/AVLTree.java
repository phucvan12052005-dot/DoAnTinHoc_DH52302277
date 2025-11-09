package DoAnTinHoc;

import java.util.*;
import java.util.function.Predicate;

/**
 * @param <T> kiểu dữ liệu được lưu trong cây AVL
 * @author TRAN PHUC VAN
 */
public class AVLTree<T> {
    private class Node {
        T data;
        Node left, right;
        int height;

        Node(T data) {
            this.data = data;
            height = 1;
        }
    }

    private Node root;
    private Comparator<T> comparator;

    public AVLTree(Comparator<T> comparator) {
        this.comparator = comparator;
    }

    public void insert(T data) {
        root = insert(root, data);
    }

    public void delete(T data) {
        root = delete(root, data);
    }

    public List<T> search(Predicate<T> condition) {
        List<T> result = new ArrayList<>();
        search(root, condition, result);
        return result;
    }

    public List<T> inOrder() {
        List<T> result = new ArrayList<>();
        inOrderTraversal(root, result);
        return result;
    }

    // ================= Internal =================

    private Node insert(Node node, T data) {
        if (node == null) return new Node(data);
        int cmp = comparator.compare(data, node.data);
        if (cmp < 0) node.left = insert(node.left, data);
        else if (cmp > 0) node.right = insert(node.right, data);
        else return node;

        updateHeight(node);
        return balance(node);
    }

    private Node delete(Node node, T data) {
        if (node == null) return null;
        int cmp = comparator.compare(data, node.data);
        if (cmp < 0) node.left = delete(node.left, data);
        else if (cmp > 0) node.right = delete(node.right, data);
        else {
            if (node.left == null || node.right == null)
                return (node.left != null) ? node.left : node.right;
            Node minNode = getMin(node.right);
            node.data = minNode.data;
            node.right = delete(node.right, minNode.data);
        }

        updateHeight(node);
        return balance(node);
    }

    private void search(Node node, Predicate<T> condition, List<T> result) {
        if (node != null) {
            search(node.left, condition, result);
            if (condition.test(node.data)) result.add(node.data);
            search(node.right, condition, result);
        }
    }

    private Node getMin(Node node) {
        while (node.left != null) node = node.left;
        return node;
    }

    private void updateHeight(Node node) {
        node.height = 1 + Math.max(height(node.left), height(node.right));
    }

    private int height(Node node) {
        return node == null ? 0 : node.height;
    }

    private int getBalance(Node node) {
        return node == null ? 0 : height(node.left) - height(node.right);
    }

    private Node balance(Node node) {
        int balance = getBalance(node);
        if (balance > 1) {
            if (getBalance(node.left) < 0) node.left = rotateLeft(node.left);
            return rotateRight(node);
        }
        if (balance < -1) {
            if (getBalance(node.right) > 0) node.right = rotateRight(node.right);
            return rotateLeft(node);
        }
        return node;
    }

    private Node rotateRight(Node y) {
        Node x = y.left;
        Node T2 = x.right;
        x.right = y;
        y.left = T2;
        updateHeight(y);
        updateHeight(x);
        return x;
    }

    private Node rotateLeft(Node x) {
        Node y = x.right;
        Node T2 = y.left;
        y.left = x;
        x.right = T2;
        updateHeight(x);
        updateHeight(y);
        return y;
    }

    private void inOrderTraversal(Node node, List<T> result) {
        if (node == null) return;
        inOrderTraversal(node.left, result);
        result.add(node.data);
        inOrderTraversal(node.right, result);
    }

    // ================= Phân tích theo năm phát hành =================

    public void phanTichCayTheoNam() {
        if (root == null) {
            System.out.println("Cây rỗng.");
            return;
        }

        Map<Integer, List<Integer>> tangMap = new TreeMap<>();

        System.out.println("In-order:");
        List<Integer> danhSachNam = new ArrayList<>();
        inOrderNam(root, danhSachNam);
        for (Integer nam : danhSachNam) {
            System.out.println("→ " + nam);
        }

        System.out.println(" Thông tin từng node:");
        inThongTinTheoNam(root, 0, tangMap);

        System.out.println("Tổng kết theo tầng:");
        for (Map.Entry<Integer, List<Integer>> entry : tangMap.entrySet()) {
            System.out.print("Tầng " + entry.getKey() + " có: ");
            for (Integer nam : entry.getValue()) {
                System.out.print(nam + " | ");
            }
            System.out.println();
        }
    }

    private void inOrderNam(Node node, List<Integer> result) {
        if (node != null) {
            inOrderNam(node.left, result);
            result.add(((GPUClass) node.data).releaseYear);
            inOrderNam(node.right, result);
        }
    }

    private void inThongTinTheoNam(Node node, int depth, Map<Integer, List<Integer>> tangMap) {
        if (node == null) return;

        inThongTinTheoNam(node.left, depth + 1, tangMap);

        GPUClass gpu = (GPUClass) node.data;
        String loaiNode;
        if (node == root) {
            loaiNode = "Node gốc";
        } else if (node.left == null && node.right == null) {
            loaiNode = "Node lá";
        } else if (node.left == null || node.right == null) {
            loaiNode = "Node có 1 cây con";
        } else {
            loaiNode = "Node có 2 cây con";
        }

        System.out.println("Năm phát hành: " + gpu.releaseYear);
        System.out.println(" → Tầng: " + depth);
        System.out.println(" → Loại: " + loaiNode);
        System.out.println("---------------------------");

        tangMap.computeIfAbsent(depth, k -> new ArrayList<>()).add(gpu.releaseYear);

        inThongTinTheoNam(node.right, depth + 1, tangMap);
    }
}
