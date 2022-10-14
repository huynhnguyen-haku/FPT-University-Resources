package sample.controllers;

import java.util.HashMap;
import sample.dtos.Candidate;
import sample.dtos.Experience;
import sample.dtos.Fresher;
import sample.dtos.Intern;
import sample.utils.Tools;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
//key    value

public class CandidateCollection extends HashMap<String, Candidate> implements I_Collection {

    @Override
    public boolean add() {
        boolean result = false;
        Candidate tempCand = null;
        int type = candidateType();
        String id = Tools.getString("Enter candidate id: ", false);
        if (this.search(id) != null) {
            System.out.println("ID has exist!");
            result = false;
        }
        switch (type) {
            case 0:
                tempCand = new Experience(type, id);
                break;
            case 1:
                tempCand = new Fresher(type, id);
                break;
            case 2:
                tempCand = new Intern(type, id);
                break;
        }
        if (tempCand.setInformation()) {
            this.put(id, tempCand);
            result = true;
        }
        return result;

    }

    @Override
    public boolean delete() {
        boolean result = false;
        String id = Tools.getString("Enter candidate id: ", false);
        Candidate tempCand = this.search(id);
        if (tempCand == null) {
            System.out.println("Not found!");
        } else {
            String choice = Tools.getString("Are you sure?(Y/N)", false);
            if("N".equalsIgnoreCase(choice)){
                System.out.println("Continue!");
            } else {
                this.remove(id);
                result = true;
            }
        }
        return result;
    }

    @Override
    public boolean update() {
        boolean result = false;
        String id = Tools.getString("Enter candidate id: ", false);
        Candidate tempCand = search(id);
        if (tempCand == null) {
            System.out.println("Not found!");
        } else {
            tempCand.updateInformation();
            result = true;
        }
        return result;
    }

    @Override
    public Candidate search(String id) {
        Candidate tempCan = null;
        if (this.containsKey(id)) {
            tempCan = this.get(id);
        }
        return tempCan;
    }

    public int candidateType() {
        int choice;
        Menu subMenu = new Menu();
        subMenu.add("Enter candidate type: ");
        subMenu.add("1. Experience");
        subMenu.add("2. Fresher");
        subMenu.add("3. Intern");
        choice = Tools.getInt("Select your choice: ", 1, subMenu.size() - 1);
        return choice;

    }

    @Override
    public void showInfor() {
        for (String element : this.keySet()) {
            get(element).showProfile();
        }
    }

    @Override
    public boolean sort() {
        List<Candidate> list = new ArrayList<>(this.values());
        Collections.sort(list);
        for (Candidate candidate : list) {
            candidate.showProfile();
        }
        return true;
    }
}
