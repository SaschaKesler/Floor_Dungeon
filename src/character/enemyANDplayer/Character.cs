using System.Collections.Generic;

public abstract class Character {

    //stats
    private int health;
    private int mana;
    private int damage;
    private int attackSpeed;
    private int defense;
    private int magicResistence;
    private int speed;
    private Race race;
    private Role role;
    
    //TODO: implement equipment, ability (and inventory?) --> or make a new class equipment which contains all of these with inventory
    private Weapon weapon; //maybe as list? or as array with length two (two as final static attribute)
    private List<Armor> armor; // maybe not a list since it would be easier to handle armor?

    //abilities
    private List<Spell> spells;
    private List<Skill> skills;

    //others
    private string name;
    private int level;
    private int experience;
    private int gold;

    public Character(string name) {
        this.name = name;
    }
}