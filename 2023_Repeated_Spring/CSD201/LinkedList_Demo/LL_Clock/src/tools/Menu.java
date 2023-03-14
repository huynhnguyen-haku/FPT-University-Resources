package tools;

import java.util.ArrayList;
import java.util.Scanner;

public class Menu extends ArrayList<String> {

    static Scanner sc = new Scanner(System.in);

    public Menu() {
        super();
    }

    // Lay lua chon tu nguoi dung
    public int getChoice() {
        int i = 1;
        for (String option : this) {
            System.out.println((i++) + "-" + option);
        }
        System.out.println("Choose ");
        return Integer.parseInt(sc.nextLine());
    }
}
