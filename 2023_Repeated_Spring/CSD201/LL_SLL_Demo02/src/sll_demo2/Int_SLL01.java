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
public class Int_SLL01 {
    public static void main(String[] args) {
        SinglyLinkedList<Integer> list = new SinglyLinkedList();
        list.addFirst(3);
        list.addFirst(2);
        list.addFirst(4);
        list.addFirst(1);
        list.print();
        System.out.println();
        list.addLast(12);
        list.addLast(9);
        list.addLast(11);
        list.addLast(10);
        list.print();
        System.out.println();
        list.addData(7, 5);
        list.addData(12, 5);
        System.out.println("Using iterator for traversing:");
        Iterator it = list.iterator();
        while (it.hasNext()) System.out.print(it.next() + " ");
        System.out.println("");
        int val = 100;
        int index = list.search(val);
        System.out.println("Index of" + val + ":" + index );
        val = 7;
        System.out.println("Index of" + val + ":" + index);
        list.set(index, 70);
        System.out.println("Change 7 to 70");
        list.print();
        System.out.println("nRemove 12, 70:");
        list.remove(5);
        list.remove(5);
        it = list.iterator();
        while (it.hasNext()) System.out.print(it.next() + " ");
        System.out.println("Size" + list.size());
        System.out.println("After ascending sort:");
        Comparator comp = new Comparator(){
            public int compare(Object o1, Object o2){
                Integer i1 = (Integer)o1;
                Integer i2 = (Integer)o2;
                return i1.compareTo(i2);
            }
        };
        list.setCompareObj(comp);
        list.ascSort();
        list.print();
        System.out.println();
    }
}
