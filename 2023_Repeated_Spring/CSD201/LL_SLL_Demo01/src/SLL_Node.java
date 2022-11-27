public class SLL_Node {

    SoftDrink data; // a soft drink
    SLL_Node next; //reference to the next node in a singly linked list

    public SLL_Node(SoftDrink aSD) {
        this.data = aSD;
        next = null;
    }

    public SLL_Node(String productLine, String company, int volume, int price) {
        SoftDrink aSD = new SoftDrink(productLine, company, volume, price);
        this.data = aSD;
        next = null;
    }
}
