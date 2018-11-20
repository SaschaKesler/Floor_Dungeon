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

	public int getDamage()
	{
		return this.damage;
	}

	public void setDamage(int damage)
	{
		this.damage = damage;
	}

	public double getAttackspeed()
	{
		return this.attackSpeed;
	}

	public void setAttackspeed(double attackSpeed)
	{
		this.attackSpeed = attackSpeed;
	}

	public WeaponTyp getWeapontyp()
	{
		return this.weaponTyp;
	}

	public void setWeapontyp(WeaponTyp weaponTyp)
	{
		this.weaponTyp = weaponTyp;
	}

	public bool getIsonehand()
	{
		return this.isOneHand;
	}

	public void isIsonehand(bool isOneHand)
	{
		this.isOneHand = isOneHand;
	}

}