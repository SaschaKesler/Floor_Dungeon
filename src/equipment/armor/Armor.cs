public abstract class Armor {
    private int armor;
    private int magicResistence;
    private ArmorTyp armorTyp;

    public Armor(int armor, int magicResistence, ArmorTyp armorTyp) {
        this.armor = armor;
        this.magicResistence = magicResistence;
        this.armorTyp = armorTyp;
    }
}