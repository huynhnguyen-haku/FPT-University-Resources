/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tools;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Huynh Nguyen
 */
public class Menu extends ArrayList<String> {
    static Scanner sc = new Scanner(System.in);
    public Menu(){
        super();
    }
    // Lay lua chon tu nguoi dung
    public int getCghoice(){
        int i = 1;
        for (String option: this){
            System.out.println((i++) + "-" + option);
        }
        System.out.println("Choose ");
        return Integer.parseInt(sc.nextLine());
    }
}
