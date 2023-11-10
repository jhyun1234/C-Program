namespace Class3
{
    #region 프로퍼티
    /*public class Transform
    {
        private int x;
        private int y;
        private int z;

        public int X // 읽기전용 get
        {
            set 
            { 
                if(value >100)
                {
                    Console.WriteLine("예기치 못한 값이 설정 되었습니다.");
                    return;

                }
                else
                {
                    x = value;
                }
            
            }
            get { return x; }
        }


    }*/


    #endregion

    #region 메소드(함수) 숨기기
    public class Weapon
    {
        protected int attack;

        public void Information()
        {
            Console.WriteLine("Weapon 정보 : ");

        }
        public virtual void Action()
        {
            Console.WriteLine("Weapon의 동작 :");

        }
    }

    public class Sword : Weapon
    {
        public new void Information()
        {
            Console.WriteLine("Sword 정보 : ");

        }

        public override void Action()
        {
            Console.WriteLine("Sword 동작 : ");

        }
    }


    #endregion

    #region 함수의 오버로딩

    public class GameObject
    {
        public void Destory()
        {
            Console.WriteLine("Destory GameObject");
        }

        public void Destory(float timer)
        {
            Console.WriteLine("Destory GameObject" + "Destory timer" + timer);
        }

        public void GetComponent(string name, int id)
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("ID : " + id);
        }

        public void SetActive(bool active = true)
        {
            Console.WriteLine("GameObject state : " + active);
        }
    }


    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티
            /*
            Transform transform = new Transform();

            transform.X = 50*/

            // 메소드 숨기기
            /*
            Sword sword = new Sword();
            sword.Information();
            sword.Action();
            */

            // 가상 함수
            /*
            Weapon weapon = new Sword();
            weapon.Information();
            weapon.Action();
            */

            // 함수의 오버로딩
            /*
            GameObject gameObject = new GameObject();
            gameObject.Destory();

            gameObject.Destory(5f);
            */

            // 명명된 매개변수
            /*
            gameObject.GetComponent(name: "done ", id: 5);
            gameObject.GetComponent("done ", 5);
            */

            // 선택적 매개변수
            /*
            gameObject.SetActive();
            gameObject.SetActive(false);
            */


        }
    }
}