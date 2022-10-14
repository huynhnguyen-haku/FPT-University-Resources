package sample.view;

import java.util.ArrayList;
import sample.controllers.CandidateCollection;
import sample.controllers.Menu;
import sample.utils.Tools;
import sample.dtos.Candidate;

public class CandidateManageMentV2 {

    public static void main(String[] args) {

        Menu menu = new Menu();
        menu.addItem("Candidate Management V2 <SE2021>");
        menu.addItem("1. Add candidate");
        menu.addItem("2. Delete candidate");
        menu.addItem("3. Update candiate");
        menu.addItem("4. Search candidate");
        menu.addItem("5. Show all candidate");
        menu.addItem("6. Sort candidate");
        menu.addItem("7. Quit");
        CandidateCollection candidateMap = new CandidateCollection();
        int choice;
        do {
            menu.showMenu();
            choice = Tools.getInt("Select your choice: ", 1, menu.size() - 1);
            switch (choice) {
                case 1:
                    if (candidateMap.add()) {
                        System.out.println("Successful!");
                    } else {
                        System.out.println("Unsuceessful!");
                    }
                    break;
                case 2:
                    if (candidateMap.delete()) {
                        System.out.println("Successful!");
                    } else {
                        System.out.println("Unsuceessful!");
                    }
                    break;
                case 3:
                    if (candidateMap.update()) {
                        System.out.println("Successful!");
                    } else {
                        System.out.println("Unsuceessful!");
                    }
                    break;

                case 4:
                    String id = Tools.getString("Enter id to search", false);
                    Candidate temp = candidateMap.search(id);
                    if (temp != null) {
                        temp.showProfile();
                    } else {
                        System.out.println("Not found!");
                    }
                    break;
                case 5:
                    candidateMap.showInfor();
                    break;
                case 6:
                    candidateMap.sort();
                    break;
            }

        } while (choice != 7);
    }

}
