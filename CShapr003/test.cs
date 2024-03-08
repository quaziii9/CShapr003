
namespace CShapr003
{
    internal class test
    {

        public class Monster
        {
            public virtual void hit()
            {
                Console.WriteLine("Monster hit");
            }
        }

        public class Orc : Monster
        {
            public override void hit()
            {
                Console.WriteLine("Orc hit");
            }
        }

        public class Elf : Monster
        {
            public new void hit()
            {
                Console.WriteLine("Elf hit");
            }
        }

        public class Wolf : Monster
        {
            public void hit()
            {
                Console.WriteLine("Wolf hit");
            }
        }

        static void Main(string[] args)
        {
            Monster monster1 = new Monster();
            Orc monster2 = new Orc();
            Elf monster3 = new Elf();
            Wolf monster4 = new Wolf();

            monster1.hit();
            monster2.hit();
            monster3.hit();
            monster4.hit();

            Monster monster5 = new Orc();
            Monster monster6 = new Elf();
            Monster monster7 = new Wolf();


            Console.WriteLine("////////////////////");
            monster5.hit();
            monster6.hit();
            monster7.hit();
        }
    }
}