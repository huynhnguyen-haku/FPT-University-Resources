package sample.dtos;

import sample.utils.Tools;

public class Experience extends Candidate {
    
    private int expYear;
    private String proSkill;
    
    public Experience(int type, String id) {
        super(type, id);
    }
    
    public Experience(String id, String name, String address, int type, int expYear, String proSkill) {
        super(id, name, address, type);
        this.expYear = expYear;
        this.proSkill = proSkill;
    }
    
    public int getExpYear() {
        return expYear;
    }
    
    public void setExpYear(int expYear) {
        this.expYear = expYear;
    }
    
    public String getProSkill() {
        return proSkill;
    }
    
    public void setProSkill(String proSkill) {
        this.proSkill = proSkill;
    }
    
    @Override
    public boolean setInformation() {
        super.setInformation();
        expYear = Tools.getInt("Enter exp year: ", 0, 100);
        proSkill = Tools.getString("Enter pro-skill: ", false);
        return true;
    }
    
    @Override
    public boolean updateInformation() {
        super.updateInformation();
        String newExpYear = Tools.getString("Enter experience-year: ", true);
        String newProSkill = Tools.getString("Enter pro-skill: ", true);
        if (newExpYear != null) {
            setExpYear(Integer.parseInt(newExpYear));
        }
        if (newProSkill != null) {
            setProSkill(newProSkill);
        }
        return true;
        
    }
    
    @Override
    public void showProfile() {
        System.out.printf("ID: %-5s|type: %-2d|name: %-15s|exp-year: %-10s|pro-Skill: %-10s|\n", getId(), getType(), getName(), this.getExpYear(), getProSkill());
        
    }
    
}
