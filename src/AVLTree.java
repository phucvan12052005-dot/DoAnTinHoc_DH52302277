import java.util.ArrayList;
import java.util.List;

public class AVLTree {
    public static class AVLNode {
        int releaseYear;
        List<GraphicsCard> cards;
        AVLNode left, right;
        int height;

        AVLNode(GraphicsCard card) {
            this.releaseYear = card.releaseYear;
            this.cards = new ArrayList<>();
            this.cards.add(card);
            this.height = 1;
        }
    }

    private AVLNode root;

    // ======= INSERT =======
    public void insert(GraphicsCard card) {
        root = insertRecursive(root, card);
    }

    private AVLNode insertRecursive(AVLNode node, GraphicsCard card) {
        if (node == null) return new AVLNode(card);

        if (card.releaseYear < node.releaseYear)
            node.left = insertRecursive(node.left, card);
        else if (card.releaseYear > node.releaseYear)
            node.right = insertRecursive(node.right, card);
        else {
            node.cards.add(card);
            return node;
        }

        updateHeight(node);
        return balance(node, card.releaseYear);
    }

    // ======= DELETE =======
    public void delete(int releaseYear) {
        root = deleteRecursive(root, releaseYear);
    }

    private AVLNode deleteRecursive(AVLNode node, int key) {
        if (node == null) return null;

        if (key < node.releaseYear)
            node.left = deleteRecursive(node.left, key);
        else if (key > node.releaseYear)
            node.right = deleteRecursive(node.right, key);
        else {
            if (node.left == null || node.right == null)
                node = (node.left != null) ? node.left : node.right;
            else {
                AVLNode minNode = getMinValueNode(node.right);
                node.releaseYear = minNode.releaseYear;
                node.cards = minNode.cards;
                node.right = deleteRecursive(node.right, minNode.releaseYear);
            }
        }

        if (node == null) return null;
        updateHeight(node);
        return balanceAfterDelete(node);
    }

    private AVLNode getMinValueNode(AVLNode node) {
        while (node.left != null) node = node.left;
        return node;
    }

    // ======= SEARCH =======
    public List<GraphicsCard> searchByReleaseYear(int year) {
        List<GraphicsCard> result = new ArrayList<>();
        searchRecursive(root, year, result);
        return result;
    }

    private void searchRecursive(AVLNode node, int year, List<GraphicsCard> result) {
        if (node == null) return;
        if (year < node.releaseYear)
            searchRecursive(node.left, year, result);
        else if (year > node.releaseYear)
            searchRecursive(node.right, year, result);
        else
            result.addAll(node.cards);
    }

    // ======= TRAVERSAL =======
    public List<GraphicsCard> layTatCaCard() {
        List<GraphicsCard> result = new ArrayList<>();
        duyetInOrder(root, result);
        return result;
    }

    private void duyetInOrder(AVLNode node, List<GraphicsCard> result) {
        if (node == null) return;
        duyetInOrder(node.left, result);
        result.addAll(node.cards);
        duyetInOrder(node.right, result);
    }

    public List<GraphicsCard> layDanhSachCardTheoNamGiamDan() {
        List<GraphicsCard> result = new ArrayList<>();
        duyetGiamDan(root, result);
        return result;
    }

    private void duyetGiamDan(AVLNode node, List<GraphicsCard> result) {
        if (node == null) return;
        duyetGiamDan(node.right, result);
        result.addAll(node.cards);
        duyetGiamDan(node.left, result);
    }

    public List<GraphicsCard> layDanhSachCardTheoTenSanPhamTangDan() {
        List<GraphicsCard> result = layTatCaCard();
        result.sort((a, b) -> a.productName.compareToIgnoreCase(b.productName));
        return result;
    }

    // ======= THỐNG KÊ CÂY =======
    public GraphicsCard getRootCard() {
        return (root != null && !root.cards.isEmpty()) ? root.cards.get(0) : null;
    }

    public int getHeight() {
        return height(root);
    }

    public int demNodeHaiLa() {
        return demHaiLa(root);
    }

    public int demNodeMotLa() {
        return demMotLa(root);
    }

    public int demNodeChiTrai() {
        return demChiTrai(root);
    }

    public int demNodeChiPhai() {
        return demChiPhai(root);
    }

    private int demHaiLa(AVLNode node) {
        if (node == null) return 0;
        int count = (node.left != null && node.right != null) ? 1 : 0;
        return count + demHaiLa(node.left) + demHaiLa(node.right);
    }

    private int demMotLa(AVLNode node) {
        if (node == null) return 0;
        boolean coTrai = node.left != null;
        boolean coPhai = node.right != null;
        int count = (!coTrai && !coPhai) ? 1 : 0;
        return count + demMotLa(node.left) + demMotLa(node.right);
    }

    private int demChiTrai(AVLNode node) {
        if (node == null) return 0;
        int count = (node.left != null && node.right == null) ? 1 : 0;
        return count + demChiTrai(node.left) + demChiTrai(node.right);
    }

    private int demChiPhai(AVLNode node) {
        if (node == null) return 0;
        int count = (node.right != null && node.left == null) ? 1 : 0;
        return count + demChiPhai(node.left) + demChiPhai(node.right);
    }

    // ======= HỖ TRỢ AVL =======
    private int height(AVLNode node) {
        return (node == null) ? 0 : node.height;
    }

    private void updateHeight(AVLNode node) {
        node.height = 1 + Math.max(height(node.left), height(node.right));
    }

    private int getBalance(AVLNode node) {
        return height(node.left) - height(node.right);
    }

    private AVLNode balance(AVLNode node, int key) {
        int balance = getBalance(node);

        if (balance > 1 && key < node.left.releaseYear)
            return rotateRight(node);
        if (balance < -1 && key > node.right.releaseYear)
            return rotateLeft(node);
        if (balance > 1 && key > node.left.releaseYear) {
            node.left = rotateLeft(node.left);
            return rotateRight(node);
        }
        if (balance < -1 && key < node.right.releaseYear) {
            node.right = rotateRight(node.right);
            return rotateLeft(node);
        }

        return node;
    }

    private AVLNode balanceAfterDelete(AVLNode node) {
        int balance = getBalance(node);

        if (balance > 1 && getBalance(node.left) >= 0)
            return rotateRight(node);
        if (balance > 1 && getBalance(node.left) < 0) {
            node.left = rotateLeft(node.left);
            return rotateRight(node);
        }
        if (balance < -1 && getBalance(node.right) <= 0)
            return rotateLeft(node);
        if (balance < -1 && getBalance(node.right) > 0) {
            node.right = rotateRight(node.right);
            return rotateLeft(node);
        }

        return node;
    }

    private AVLNode rotateRight(AVLNode y) {
        AVLNode x = y.left;
        AVLNode T2 = x.right;

        x.right = y;
        y.left = T2;

        updateHeight(y);
        updateHeight(x);

        return x;
    }

    private AVLNode rotateLeft(AVLNode x) {
        AVLNode y = x.right;
        AVLNode T2 = y.left;

        y.left = x;
        x.right = T2;

        updateHeight(x);
        updateHeight(y);

        return y;
    }

    // Truy cập gốc nếu cần
    public AVLNode getRoot() {
        return root;
    }
}
