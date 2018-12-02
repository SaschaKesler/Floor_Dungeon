using System.Collections.Generic;
using race;
using role;
using ability;

namespace enemyAndPlayer {
    public abstract class Character {

        //stats
        private int health = 100;
        private int mana = 100;
        private int damage = 10;
        private double attackSpeed = 1;
        private int defense = 0;
        private int magicResistence = 0;
        private int speed = 3;
        private Race race;
        private Role role;
        
        //TODO: implement equipment, ability (and inventory?) --> or make a new class equipment which contains all of these with inventory
        private Weapon weapon; //maybe as list? or as array with length two (two as final static attribute)
        private List<Armor> armor; // maybe not a list since it would be easier to handle armor?

        //abilities
        private List<Spell> spells = new List<Spell>();
        private List<Skill> skills = new List<Skill>();

        //others
        private string name;
        private int level = 0;
        private int experience = 0;
        private int gold = 0;

        public Character(string name, Role role, Race race) {
            this.name = name;
            this.role = role;
            this.race = race;
        }
    }
}