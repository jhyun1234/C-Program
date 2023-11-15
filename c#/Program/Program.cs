using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Program
{
   
    internal class Program
    {
   
        static void Main(string[] args)
        {
            #region SRP 5대 원칙


            //Monster spider = new Monster("거미 ", 10, 100);

            //spider.Patrol();

            //Infromation infromation = new Infromation();

            //infromation.MonsterInfo(spider);
            #endregion

            #region OCP 5대 원칙

            Marine marine = new Marine();
            Firebet firebet = new Firebet();
            Ghost ghost = new Ghost();
            UnitMangaer unitMangaer = new UnitMangaer();
            unitMangaer.Commend(marine);
            unitMangaer.Commend(firebet);
            unitMangaer.Commend(ghost);

            #endregion
        }
    }
}