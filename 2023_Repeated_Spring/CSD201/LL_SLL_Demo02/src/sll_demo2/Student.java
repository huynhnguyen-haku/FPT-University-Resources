/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sll_demo2;

import java.util.Objects;

/**
 *
 * @author Huynh Nguyen
 */
public class Student implements Comparable<Student> {
    String ID;
    String name ="";
    int mark = 0;

    public Student(String ID) {
        this.ID = ID;
    }

    public Student(String ID, String name, int mark){
        this.ID = ID;
        this.name = name;
        this.mark = mark;
    }
    

    @Override
    public int compareTo(Student o) {
        int d = this.mark - o.mark;
        return (d>0)? -1 : (d<0)? 1: this.ID.compareTo(o.ID);
    }
    @Override
    public String toString(){
        return ID + "," + name + "," + mark;
    }
    public boolean equals(Object obj){
        if (this==obj) return true;
        if (obj == null) return false;
        if (getClass()!=obj.getClass()) return false;
        final Student other = (Student) obj;
        if (!Objects.equals(this.ID, other.ID)) return false;
        return true;
    }
}
