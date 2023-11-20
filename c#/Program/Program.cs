using System.Collections;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Program
{
   public class GameObject
    {
        private string name;
        private string v;

        public GameObject(string v)
        {
            this.v = v;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
    internal class Program
    {
   
        static void Main(string[] args)
        {
            #region 콜렉션

            //ArrayList
            /*
             * ArrayList arrayList = new ArrayList(); // 모든 타입을 다 받을 수 있다.

            arrayList.Add(100);
            arrayList.Add("String");
            arrayList.Add(115.5f);
            arrayList.Add('A');

            foreach(object element in arrayList)
            {
                Console.WriteLine(element);
            }

            //  0      1        2      3
            // [10] [String] [115.5f] [A]

            arrayList.Remove(100);
            Console.WriteLine("  ");
            Console.WriteLine("arrayList Count : "+arrayList.Count);


            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }
            */


            // List 
            /*
            List<int> list = new List<int>(10);

            list.Capacity = 10;
            // [] [] [] [] [] [] [] [] [] []
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            // list.RemoveAt(3); // 3번째 index가 삭제됨
            // list.Reverse(); 순서를 반전시킴
            // list.Sort(); // 작은 수(list 안에있는 원소) 부터 정렬함 
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            */
            /*
             List<string> list = new List<string>(5);
             list.Capacity = 5;
             list.Add("메이플스토리");
             list.Add("로스트아크");
             list.Add("서든어택");
             list.Add("리그오브레전드");
             list.Add("오버워치");


             Random random = new Random();
             int temp = list.Count;
             for(int i=0; i<temp; i++)
             {
                 int rand = random.Next(0, list.Count);
                 Console.WriteLine(list[rand]);
                 list.RemoveAt(rand);
             }
             */

            // LinkedList
            /*
            LinkedList<int> link = new LinkedList<int>();
            link.AddFirst(10); 
            link.AddFirst(20); // 20이 먼저 나오는 이유는 newNode가 첫번째 노드로 가 있기 때문
            link.AddLast(30);
            foreach(var item in link)
            {
                Console.WriteLine(item);
            }
            */

            // Stack
            /*
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            stack.Pop();  // Pop: 가장 위에 있는 데이터를 삭제한다.
                          // Peek : 가장 위에 있는 데이터를 반환한다.
            Console.WriteLine("stack Peek : "+ stack.Peek());
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            */


            // Queue
            Queue<GameObject> queue = new Queue<GameObject>();
            string[] objectName = new string[4] { "Cube", "Sphere", "Capsule", "Cylinder" };
            queue.Enqueue(new GameObject("Cube")); // []
            queue.Enqueue(new GameObject("Sphere")); // [] []
            queue.Enqueue(new GameObject("Capsule")); // [] [] []
            queue.Enqueue(new GameObject("Cylinder")); // [] [] [] []

            int queueSize = queue.Count;
            for(int i=0; i<queueSize; i++)
            {
                GameObject gameObject = queue.Dequeue();
                gameObject.Name = objectName[i];
                Console.WriteLine(gameObject.Name);
            }

            

            


            // Random Class
            /*
             * Random random = new Random();
            int rand = random.Next(0, 10);

            Console.WriteLine("rand : " + rand);
            */


            #endregion


        }
    }
}