package sample.controllers;

import java.util.ArrayList;

public class Menu extends ArrayList<String> implements I_Menu {

    @Override
    public void addItem(String item) {
        add(item);
    }

    @Override
    public void showMenu() {
        for (String item : this) {
            System.out.println(item);
        }
    }

}
