/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sll_demo2;

import java.util.Comparator;
import java.util.Iterator;

/**
 *
 * @author Huynh Nguyen
 */
public class StudentMng {
    public static void main(String[] args) {
        Comparator<Student> comp = new Comparator<Student>() {
            @Override
            public int compare(Student o1, Student o2){
                return o1.compareTo(o2);
            }
        };
        SinglyLinkedList<Student> list = new SinglyLinkedList<>();
        list.setCompareObj(comp);
        Student st = new Student ("SE123456", "Hoa", 7);
        list.addFirst(st);
        st = new Student("SE151222", "Hoang", 7);
        list.addLast(st);
        st = new Student("SE61098", "Chien", 8);
        list.addFirst(st);
        st = new Student("SE405211", "William", 4);
        Iterator it = list.iterator();
        while (it.hasNext())System.out.println(it.next());
        
        String ID = "SE405211";
        int pos = list.search( new Student(ID));
        if (pos>=0) System.out.println(ID + ": found.");
        else System.out.println(ID + ":not found!");
        
        ID = "SE499999";
        pos = list.search( new Student(ID));
        if (pos>=0) System.out.println(ID + ": found.");
        else System.out.println(ID + ":not found!");
        System.out.println("********** SOIRT");
        
        list.ascSort();
        it = list.iterator();
        while (it.hasNext())System.out.println(it.next());
    }
}
