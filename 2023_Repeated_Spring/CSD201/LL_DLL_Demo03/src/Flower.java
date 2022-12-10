
public class Flower {

    String name;
    String original = null;
    int price = 0;

    public Flower() {
    }

    public Flower(String name, String original, int price) {
        this.name = name;
        this.original = original;
        this.price = price;
    }

    Flower(String flowerName) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public boolean equals(Object obj) {
        Flower f = (Flower) obj;
        return this.name.equals(f.name);
    }

    @Override
    public String toString() {
        return name + "," + original + "," + price;
    }
}
