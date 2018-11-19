public abstract class Weapon{

    private int damage;
    private double attackSpeed;
    private WeaponTyp weaponTyp;
    private bool isOneHand;

    public Weapon(int damage, double attackSpeed, bool isOneHand, WeaponTyp weaponTyp) {
        this.damage = damage;
        this.attackSpeed = attackSpeed;
        this.isOneHand = isOneHand;
        this.weaponTyp = weaponTyp;
    }

}