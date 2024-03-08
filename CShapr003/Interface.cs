namespace CShapr003
{
    internal class Interface
    {
        // 인터페이스
        // 추상클래스의 일종으로 특징이 동일함
        // 함수에 대한 선언만 하고 이를 포함하는 클래스에서 구체화한 다음 사용
        // 공통점 : 함수에 대한 선언만정의. 자식에서 구체화
        // 인터페이스는 다중 상속 허용, 
        // 상속 : 사과는 과일이다. -> 그럼 상속
        // 추상클래스 : 상속관계인경우 자식클래스가 부모클래스의 하위 분류인 경우
        //           : 상속을 통해서 얻을 수 잇는 기능등을 사용할 수 있음
        //           : 부모클래스의 기능을 통해서 자식 클래스의 기능을 확장하는 경우
        //           : 관계성이 연관 상위 클래스가 하위클래스랑 연결 포함
        // 인터페이스 : 행동을 포함하고 인터페이스를 상속을 받는 car라는 클래스가 해당 행동을 할 수 있는 경우 
        // 인터페이스에 정의된 함수들을 클래스에 목적에 맞게 기능을 구현하는 경우
        // 00 있다

        public abstract class Test
        {
            // 변수 포함 가능
            int a;

            public void Print()
            {
                Console.WriteLine();
            }
        }


        public interface IEnterable
        {
            // 변수 포함 불가능 int b; 오류
            void Enter();
        }

        public interface IEnterablea
        { 
            void Enter();
        }


        public abstract class Building : IEnterable 
        {
            public void Enter()
            {

            }
        }
        // 은행은 건물이다 -> 상속 ㄱ
        // 차는 들어갈수 있다 -> 인터페이스 

        public class Car : IEnterable , IEnterablea // 다중상속 가능
        {
            public void Enter()
            {
                // 문을 열고 차에 들어간다.
            }
        }

        

        static void Main(string[] args)
        {

        }
    }
}
