using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
	#region 리스코프 치환 원칙
	// 상위 클래스와 하위 클래스가 있을 때
	// 상위 클래스가 호출하는 동작에서 하위 클래스가
	// 상위 클래스를 완벽하게 대체할 수 있어야 하는 원칙이다.


	public abstract class Zerg
	{
        protected int damage;
        protected int armor;
        
		public abstract void Move();
       
		
    }

    public class GroundUnit : Zerg
    {

		public GroundUnit(int dmamage, int armor)
		{
			this.damage = damage;
			this.armor = armor;
			
		}

		public void Ground()
		{
            Console.WriteLine("On the Ground");
        }
        public override void Move()
        {
            Ground();
            Console.WriteLine("Move");
        }
    }
    public class Drone : GroundUnit
    {
        public Drone():base(10,5)
        {
            base.Move();
        }

    }
    public class FlyUnit : Zerg
    {
        public override void Move()
        {
            throw new NotImplementedException();
        }
    }


    #endregion

}
