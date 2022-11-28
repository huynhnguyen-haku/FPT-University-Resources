package sll_demo2;

import java.util.Comparator;
import java.util.Iterator;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author Huynh Nguyen
 */
public class SinglyLinkedList<E> {

    private class Node<E> {

        E data;
        Node next;

        public Node(E data) {
            this.data = data;
            next = null;
        }

        public Node(E data, Node after) {
            this.data = data;
            next = after;
        }

        public E getData() {
            return data;
        }

        public void setData(E data) {
            this.data = data;
        }

        public Node getNext() {
            return next;
        }

        public void setNext(Node next) {
            this.next = next;
        }
    }
    Node head = null;
    Node tail = null;
    int size = 0;
    Comparator<E> compareObj;

    public SinglyLinkedList() {
    }

    public void setCompareObj(Comparator<E> compareObj) {
        this.compareObj = compareObj;
    }

    public int size() {
        return size;
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public Node moveto(int index) {
        if (index < 0 || index >= size) {
            return null;
        }
        Node t = head;
        for (int i = 1; i <= index; i++) {
            t = t.next;
        }
        return t;
    }

    public E first() {
        return head == null ? null : (E) head.getData();
    }

    public E last() {
        return tail == null ? null : (E) tail.getData();
    }

    public E get(int index) {
        Node t = moveto(index);
        return t == null ? null : (E) t.getData();
    }

    public void addFirst(E data) {
        head = new Node(data, head);
        if (size == 0) {
            tail = head;
        }
        size++;
    }

    public void addLast(E data) {
        Node newNode = new Node(data, null);
        if (size == 0) {
            tail = head = newNode;
        } else {
            tail.setNext(newNode);
        }
        tail = newNode;
        size++;
    }
    public void addData(E data, int index){
        if (this.size == 0) addFirst(data);
        if (index >= size) addLast(data);
        Node before = moveto(index-1);
        Node after = before.next;
        Node newNode = new Node(data, after);
        before.next = newNode;
        size++;
    }
    public int search(E data){
        int index = 0;
        for (Node t = head; t!= null; t=t.next){
            if (t.getData().equals(data)) return index;
            index++;
        }
        return -1;
    }
    private Node searchNode(E data){
        for (Node t = head; t!=null; t=t.next)
            if (t.getData().equals(data)) return t;
        return null;
    }
    public E removeFirst(){
        if (size == 0) return null;
        E result = (E)head.getNext();
        head = head.next;
        if (head == null) tail = null;
        size --;
        return result;
    }
    public E removeLast(){
        if (size == 0) return null;
        if (size == 1) return removeFirst();
        E result = (E)tail.getData();
        Node newTail = moveto(size-2);
        newTail.setNext(null);
        tail = newTail;
        size--;
        return result;
    }
    public E remove(int index){
        if (index <0 || index >=size) return null;
        if (index == 0) return (E)removeFirst();
        if (index == size-1) return removeLast();
        Node before = moveto(index-1);
        Node delNode = before.next;
        Node after = delNode.next;
        before.setNext(after);
        size--;
        return (E)delNode.getData();
    }
    public void set(int index, E newData){
        Node updateNode = moveto(index);
        if (updateNode!=null) updateNode.setData(newData);
    }
    public void print(){
        if(this.size==0) System.out.println("Empty List");
        else{
            for (Node t = head; t!=null; t=t.next)
                System.out.print(t.getData() + " ");
        }
    }
    private class Traverser<E> implements Iterator<E>{
        Node t;
        Traverser(SinglyLinkedList<E>sll){
        t = new Node(null, sll.head);
    }
        @Override
        public boolean hasNext(){
            return t.next != null;
        }
        @Override
        public E next(){
            t = t.next;
            return (E)t.getData();
        }
    }
    public Iterator iterator(){
        return new Traverser(this);
    }
    public void ascSort(){
        if (size<=0) return;
        for (Node t1 = head; t1!=tail;t1=t1.next)
            for (Node t2 = t1.next; t2!=null; t2 = t2.next){
                E data1 = (E)t1.getData();
                E data2 = (E)t2.getData();
                if (this.compareObj.compare(data1, data2)>0){
                    E tmp = data1;
                    t1.data = t2.data;
                    t2.data = tmp;
                }
            }
    }
}
