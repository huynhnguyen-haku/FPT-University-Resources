package sample.utils;

import java.util.Scanner;

public class Tools {

    public static String getString(String msg, boolean mayEmpty) {
        Scanner sc = new Scanner(System.in);
        String result = null;
        boolean flag = true;
        while (flag) {
            try {
                System.out.print(msg + "(Can empty = " + mayEmpty + ")  ");
                result = sc.nextLine();
                if (result.isEmpty()) {
                    result = null;
                }
            } catch (Exception e) {
                System.out.println(e.getMessage());
                System.out.println("Try again!");
            }
            if (mayEmpty) {
                flag = false;
            }
            if (mayEmpty == false && result != null) {
                flag = false;
            }
        }
        return result;
    }

    public static int getInt(String msg, int min, int max) {
        Scanner sc = new Scanner(System.in);
        int result = Integer.MIN_VALUE;
        while (result < min || result > max) {
            try {
                System.out.print(msg + "(from " + min + " to " + max + ")   ");
                result = Integer.parseInt(sc.nextLine());
            } catch (Exception e) {
                System.out.println(e.getMessage());
                System.out.println("Try again!");
            }

        }
        return result;
    }

}
