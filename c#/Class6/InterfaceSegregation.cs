using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Class6
{
    #region 인터페이스 분리 원칙
    // 클라이언트가 자신이 사용하지 않는 함수에 의존하지 않아야 하며,
    // 인터페이스를 구체적이고 작은 단위로 분리하여 사용하는 원칙

    
    public interface IMoveable
	{
        public void Move();
		
            
        

	}

	public interface IAttackable
	{
        public void Attack();
		
           
        
	}
	
	public interface ISkillable
	{
        public void Skill();
		
           
        
	}

    public class Wraith : IMoveable, IAttackable, ISkillable
    {
        public void Attack()
        {
            Console.WriteLine("Wraith is Attack");
        }

        public void Move()
        {
            Console.WriteLine("Wraith is Move");
        }

        public void Skill()
        {
            Console.WriteLine("Wraith use Skill");
        }
    }

    public class Battlecruiser : IMoveable, IAttackable, ISkillable
    {
        public void Attack()
        {
            Console.WriteLine("Battlecruiser is Attack");
        }

        public void Move()
        {
            Console.WriteLine("Battlecruiser is Move");
        }

        public void Skill()
        {
            Console.WriteLine("Battlecruiser use Skill");
        }
    }
    public class Valkyrie : IMoveable, IAttackable
    {
        public void Attack()
        {
            Console.WriteLine("Valkyrie is Attack");
        }

        public void Move()
        {
            Console.WriteLine("Valkyrie is Move");
        }
    }

    public class Dropship : IMoveable ,ISkillable
    {
        public void Move()
        {
            Console.WriteLine("Dropship is Move");
        }

        public void Skill()
        {
            Console.WriteLine("Dropship use Skill");
        }
    }
    #endregion
}
