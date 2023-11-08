namespace Program
{
    // 접근 지정자 class 클래스 이름
    // public , protected, private 

 

    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine() : 문자열을 출력하는 함수
            #region 자료형
            //byte stream =1;
            //bool boolean = false;
            //char character = 'A';
            //short data = 200;
            //int integer = 100;
            //long longData = 300;

            //float[] buffer = new float[3];
            //double pi = 3.14;
            //decimal decimalData = 0.1m;


            //Console.WriteLine("stream : "+ stream);
            //Console.WriteLine("boolean : " + boolean);
            #endregion

            #region 박싱
            // 값 형식의 데이터를 참조 형식으로 변화하는 과정이다.
            int data = 5;

            object obj = data;

            #endregion

            #region 언박싱
            // 참조 타입의 데이터를 값 타입으로 변환하는 과정이다.

            int count = 10;
            object obj1 = count;
            int result = (int)obj1;


            #endregion
        }
    }
}