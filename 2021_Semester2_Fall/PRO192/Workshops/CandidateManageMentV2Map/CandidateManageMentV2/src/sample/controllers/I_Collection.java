package sample.controllers;

import sample.dtos.Candidate;

public interface I_Collection {

    public boolean add();

    public boolean delete();

    public boolean update();

    public Candidate search(String id);

    public void showInfor();

    public boolean sort();

}
