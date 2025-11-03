import java.util.ArrayList;
import java.util.List;

public class AVLTreetheoTenCard {
    public static class AVLNode {
        String productName;
        List<GraphicsCard> cards;
        AVLNode left, right;
        int height;

        AVLNode(GraphicsCard card) {
            this.productName = card.productName;
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

        int cmp = card.productName.compareToIgnoreCase(node.productName);
        if (cmp < 0)
            node.left = insertRecursive(node.left, card);
        else if (cmp > 0)
            node.right = insertRecursive(node.right, card);
        else {
            node.cards.add(card);
            return node;
        }

        updateHeight(node);
        return balance(node, card.productName);
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

    // ======= THỐNG KÊ =======
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

    private AVLNode balance(AVLNode node, String key) {
        int cmpLeft = (node.left != null) ? key.compareToIgnoreCase(node.left.productName) : 0;
        int cmpRight = (node.right != null) ? key.compareToIgnoreCase(node.right.productName) : 0;
        int balance = getBalance(node);

        if (balance > 1 && cmpLeft < 0)
            return rotateRight(node);
        if (balance < -1 && cmpRight > 0)
            return rotateLeft(node);
        if (balance > 1 && cmpLeft > 0) {
            node.left = rotateLeft(node.left);
            return rotateRight(node);
        }
        if (balance < -1 && cmpRight < 0) {
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
}
