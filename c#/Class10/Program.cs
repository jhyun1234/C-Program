namespace Class10
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region 등차수열


            // 등차수열
            /*
            int commonDiffernt = 0; // 공차 
            int firstTerm = 0; // 첫항

            int size = 0;

            // Console.ReadLine() : string 타입으로만 값을 반환한다.
            // string name = Console.ReadLine();
            // Console.WriteLine("name의 변수의 값 : " + name);
            // Int32.Parse : int 타입으로 값을 반환한다.

            Console.Write("첫 항의 값 입력 : ");
            firstTerm = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("공차의 값 입력 : ");
            commonDiffernt = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("n 의 값 입력 :");
            size = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");


            for (int i=0; i<size; i++)
            {
                Console.WriteLine(firstTerm + commonDiffernt *i);
            }
            */
            #endregion

            #region 등비수열
            /*
            int commonratio; // 공비
            int firstTerm; // 첫항

            int size;
            Console.Write("첫 항의 값 입력 : ");
            firstTerm = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("공비의 값 입력 : ");
            commonratio = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("n 의 값 입력 :");
            size = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            for (int i=1; i<size; i++)
            {
                Console.WriteLine(firstTerm);
                firstTerm *= commonratio;
            }
            */

            #endregion

            #region 무명 형식
            /*
            // 이름이 존재하지 않는 객체 또는 변수를 의미 한다.

            var data = new { Name = "Data", Value = 10 };
            // 무명 형식의 경우 값을 읽기만 할 수 있다.
            // data.Name=200; error

            Console.WriteLine("data.Name : "+data.Name + " data.Value : "+data.Value);
            */
            #endregion
        }
    }
}