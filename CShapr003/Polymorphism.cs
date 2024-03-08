namespace CShapr003
{
    // 객체의 속성이 어떤 상황에 따라서 여러 형질을 가질 수 있음 
    internal class Polymorphism
    {
        class Car
        {
            protected string name;
            protected int speed;

            public void Move()
            {
                Console.WriteLine($"{name}이 {speed}의 속도로 이동!");
            }
        }

        class Truck : Car
        {
            public Truck()
            {
                name = "트럭";
                speed = 30;
            }
        }
        class SportCar : Car
        {
            public SportCar()
            {
                name = "스포츠카";
                speed = 100;
            }
        }
        // 가상함수와 오버라이딩 
        // 가상함수 : 부모클래스의 함수 중 자식클래스에 의해서 재정의 할 수 있는 함수를 지정
        // 오버라이딩 : 부모클래스의 가상함수를 같은 함수이름과 같은 매개변수로 재정의 하여 자식만의 반응을 구현
        
        class Skill
        {
            public virtual void Excute()    // 가상함수
            {
                Console.WriteLine("스킬 재사용 대기시간을 진행한다");
            }
        }
        class FireBall : Skill
        {
   
            public override void Excute()   // 오버라이딩
            {
                base.Excute();              // base : 부모클래스를 가리킴
                Console.WriteLine("화염구 발사!");
            }
        }
        class Dash : Skill
        {
            public override void Excute()   // 오버라이딩
            {
                Console.WriteLine("돌진공격");
            }
        }

        static void Test()
        {
            Skill fireball = new FireBall();    // 형변환 : 업캐스팅 , 
            fireball.Excute();

            Skill dash = new Dash();
            dash.Excute();
        }

        class Player
        {
            Skill skill;

            public void SetSkill(Skill skill)
            {
                this.skill = skill;
            }
            public void UseSkill()
            {
                skill.Excute();
            }
        }

        static void Main(string[] args)
        {
            Test();
            //Player player = new Player();
            //Dash dash = new Dash();
            //Skill fire = new FireBall();
            //player.SetSkill(fire);
            //player.UseSkill();
        }
    }
}
