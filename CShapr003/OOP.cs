
namespace CShapr003
{
    /*
     
    객체지향 4대 특징
    1. 캡슐화 : 객체를 상태와 기능으로 묶는다. 객체의 내부 상태와 기능을 숨기고 허용한 상태와 기능만을 액세스 허용
    2. 상속 : 부모클래스의 모든 기능을 가지는 자식클래스를 만든다.
    3. 추상화 : 관련 특성 및 엔터티의 상호작용을 클래스를 모델링 하여 시스템의 추상적 표현을 정의
    4. 다형성 : 부모 클래스의 함수를 자식클래스에서 재정의 하여 자식 클래스의 다른 반응을 구현

    SOLID
    // S 단일 책임의 원칙 : 객체는 오로지 하나의 책임을 가짐
    // O 개방 폐쇄의 원칙 : 확장에 대해서는 개방적이고, 수정에 대해서는 폐쇄적
    // L 리스코프 치환문 원칙 :  자식클래스는 언제든지 내 부모클래스를 대체할 수 있어야함
    // I 인터페이스 분리 원칙 : 인터페이스는 작은 단위들로 분리 시켜서 구성을 하고 사용하지 않는 함수는 포함하지 말아야한다.
    // D 의존성 역전 원칙 : 객체는 하위 클래스보다 상위 클래스에 의존 

    대규모 프로젝트에 적합, 설계에 많은 시간이 소비, 신중해야함 

     */

    class Driver
    {
        public string name;
        public Driver(string name)
        {
            this.name = name;
        }
        public void Ride(Vehicle vehicle)
        {
            Console.WriteLine($"{this.name}이 {vehicle.name}을 운전한다.");
        }
    }
    class Vehicle
    {
        public string name;
        public int speed;

        public Vehicle(string name, int speed = 0) // 디폴트 매개변수 int speed = 0
        {
            this.name = name;
            this.speed = speed;
        }

        public void Move()
        {
            speed += 10;
            Console.WriteLine($"{name}의 속도가 {speed} 증가함.");
        }
    }

    internal class OOP
    {
        static void Main(string[] args)
        {
            Driver d = new Driver("경일이");
            Vehicle bike = new Vehicle("ㅋㅋ", 10);

            d.Ride(bike); // 드라이버라는 객체가 ride 기능으로 오타바이 객체와 상호작용 
        }
    }
}
