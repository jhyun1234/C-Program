using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

	#region 의존관계 역전 원칙
	// 상위계층이 하위계층에 의존하는 전통적인 관계를
	// 반전시킴으로써 상위 계층이 하위 계층의 구현으로부터
	// 독립될 수 있도록 설계하는 원칙이다.

    public class Player
    {
        private int health;
        private Weapon weapon;

        public Player(int health, Weapon weapon)
        {
            this.health = health;
            this.weapon = weapon;
        }
        public void ChangeWeapon(Weapon weapon)
        {
            this.weapon = weapon;
            WeaponInfo();
        }
        public void WeaponInfo()
        {
            Console.WriteLine("name : "+weapon.Name);
            Console.WriteLine("damage : "+weapon.Damage);
            Console.WriteLine("attack : "+weapon.Attack);
        }
    }
	public abstract class Weapon
	{
		protected int damage;
		protected int durability;
        protected string name;
        protected int attack;

        public Weapon(int damage,int durability,int attack,string name)
        {
            this.damage = damage;
            this.durability = durability;
            this.name = name;
            this.attack = attack;
        }
        public int Damage
        {
            get { return damage; }
        }
        public int Attack
        {
            get { return attack; }
        }
        public string Name
        {
            get { return name; }
        }
        
        public abstract void Action();
    }

	

    public class Axe : Weapon
    {
        public Axe() : base(50,100,1,"Axe")
        {

        }
        public override void Action()
        {
            Console.WriteLine("Axe Action");
        }

        
    }

    public class Knife : Weapon
    {
        public Knife() : base(12, 100,5, "Knife")
        {

        }
        public override void Action()
        {
            Console.WriteLine("Knife Action");
        }

        
    }
   


    #endregion

}
