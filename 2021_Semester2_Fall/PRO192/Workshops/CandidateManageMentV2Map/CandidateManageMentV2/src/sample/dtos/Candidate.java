package sample.dtos;
import sample.utils.Tools;

public abstract class Candidate implements Comparable<Candidate> {

    private String id;
    private String name;
    private String address;
    private int type;

    public Candidate(int type, String id) {
        this.type = type;
        this.id = id;
    }

    public Candidate(String id, String name, String address, int type) {
        this.id = id;
        this.name = name;
        this.address = address;
        this.type = type;
    }

    public String getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public int getType() {
        return type;
    }

    public boolean setInformation() {
        name = Tools.getString("Enter candidate's name: ", false);
        address = Tools.getString("Enter candidate's address: ", false);
        return true;
    }

    public boolean updateInformation() {
        String newName = Tools.getString("Enter candidate's name: ", true);
        String newAddress = Tools.getString("Enter candidate's address: ", true);
        if (newName != null) {
            setName(newName);
        }
        if (newAddress != null) {
            setAddress(newAddress);
        }
        return true;

    }

    public abstract void showProfile();

    
    @Override
    public int compareTo(Candidate o) {
       // return this.name.compareTo(o.name);
        return o.name.compareTo(this.name);
    }

}
