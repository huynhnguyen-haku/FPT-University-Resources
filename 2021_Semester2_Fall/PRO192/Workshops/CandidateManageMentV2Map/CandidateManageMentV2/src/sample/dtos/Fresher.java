package sample.dtos;

import sample.utils.Tools;

public class Fresher extends Candidate {

    private String graduationTime;
    private String graduationRank;
    private String university;

    public Fresher(int type, String id) {
        super(type, id);
    }

    public Fresher(String id, String name, String address, int type, String graduationTime, String graduationRank, String university) {
        super(id, name, address, type);
        this.graduationTime = graduationTime;
        this.graduationRank = graduationRank;
        this.university = university;
    }

    public String getGraduationTime() {
        return graduationTime;
    }

    public void setGraduationTime(String graduationTime) {
        this.graduationTime = graduationTime;
    }

    public String getGraduationRank() {
        return graduationRank;
    }

    public void setGraduationRank(String graduationRank) {
        this.graduationRank = graduationRank;
    }

    public String getUniversity() {
        return university;
    }

    public void setUniversity(String university) {
        this.university = university;
    }
        
    
    @Override
    public boolean setInformation() {
        super.setInformation();
        graduationTime = Tools.getString("Gradiation time: ", false);
        graduationRank = Tools.getString("Gradiation rank: ", false);
        university = Tools.getString("University: ", false);
        return true;
    }

    @Override
    public boolean updateInformation() {
        super.updateInformation();
        String newGraduationTime = Tools.getString("Gradiation time: ", true);
        String newGraduationRank = Tools.getString("Gradiation rank: ", true);
        String newUniversity = Tools.getString("University: ", true);
        if (newGraduationTime != null) {
            setGraduationTime(newGraduationTime);
        }
        if (newGraduationRank != null) {
            setGraduationRank(newGraduationRank);
        }
        if (newUniversity != null) {
            setUniversity(newUniversity);
        }
        return true;
    }

    @Override
    public void showProfile() {
        System.out.printf("ID: %-5s|type: %-2d|name: %-15s|gra-time: %-10s|Rank: %-10s| Uni: %-10s|\n", getId(), getType(), getName(), getGraduationTime(), getGraduationRank(), getUniversity());
    }

}
