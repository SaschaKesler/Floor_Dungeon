using System.Collections.Generic;

public class Character {

    //stats
    private int health;
    private int mana;
    private int damage;
    private int attackSpeed;
    private int speed;
    private int defense;
    private int magicResistence;
    
    //ToDo implement equipment, ability (and inventory?) --> or make a new class equipment which contains all of these with inventory
    private Weapon weapon; //maybe as list? or as array with length two (two as final static attribute)
    private List<Armor> armor;
    private List<Spell> spells;
    private List<Skill> skills;

    //others
    private int level;
    private int experience;
    private int gold;
}