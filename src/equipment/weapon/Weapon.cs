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

	public int getDamage() {
        return damage;
    }
    public void setDamage(int damage) {
        this.damage = damage;
    }

    public double getAttackSpeed() {
        return attackSpeed;
    }
    public void setAttackSpeed(double attackSpeed) {
        this.attackSpeed = attackSpeed;
    }

    public WeaponTyp getWeaponTyp() {
        return weaponTyp;
    }
    public void setWeaponTyp(WeaponTyp weaponTyp) {
        this.weaponTyp = weaponTyp;
    }
    public bool getIsOneHand() {
        return isOneHand;
    }
    public void setIsOneHand(bool isOneHand) {
        this.isOneHand = isOneHand;
    }

}