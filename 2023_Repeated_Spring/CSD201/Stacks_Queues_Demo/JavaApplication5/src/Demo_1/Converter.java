package Demo_1;


import java.util.Stack;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Huynh Nguyen
 */
public class Converter {
    public static String convert(int n, int base){
        String result = "";
        Stack<Integer> stk = new Stack();
        do {
            stk.push(n%base);
            n /=  base;
        }
        while (n > 0);
        while (!stk.empty()){
            int value = stk.pop();
            result += Character.forDigit(value, base);
        }
        return result;
    }
    public static void main(String[] args) {
        int n = 106;
        System.out.println(convert(n,2) + "b");
        System.out.println(convert(n,8) + "q");
        System.out.println(convert(n,10) + "d");
        System.out.println(convert(n,16) + "h");
    }
}
