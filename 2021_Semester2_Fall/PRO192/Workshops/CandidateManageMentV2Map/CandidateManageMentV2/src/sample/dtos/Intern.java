package sample.dtos;

import sample.utils.Tools;

public class Intern extends Candidate {

    private String major;
    private String semester;
    private String university;

    public Intern(int type, String id) {
        super(type, id);
    }

    public Intern(String id, String name, String address, int type, String major, String semester, String university) {
        super(id, name, address, type);
        this.major = major;
        this.semester = semester;
        this.university = university;
    }

    public String getMajor() {
        return major;
    }

    public void setMajor(String major) {
        this.major = major;
    }

    public String getSemester() {
        return semester;
    }

    public void setSemester(String semester) {
        this.semester = semester;
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
        major = Tools.getString("Enter major: ", false);
        semester = Tools.getString("Enter semester", false);
        university = Tools.getString("Enter university: ", false);
        return true;
    }

    @Override
    public boolean updateInformation() {
        super.updateInformation();
        String newMajor = Tools.getString("Enter major: ", true);
        String newSemester = Tools.getString("Enter semester: ", true);
        String newUniversity = Tools.getString("Enter university: ", true);
        if (newMajor != null) {
            setMajor(newMajor);
        }
        if (newUniversity != null) {
            setUniversity(newUniversity);
        }
        if (newSemester != null) {
            setSemester(newSemester);
        }
        return true;

    }

    @Override
    public void showProfile() {
        System.out.printf("ID: %-5s|type: %-2d|name: %-15s|Major: %-10s|Semester: %-10s|Uni: %-10s|\n", getId(), getType(), getName(), getMajor(), getSemester(), getUniversity());
    }

}
