using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CShapr003
{
    internal class Abstract
    {

        // Abstract 추상화
        // - 클래스를 정의할때 구체화 시킬 수 없는 기능을 추상적 표현으로 정의
        // 추상클래스는 뭘까요
        // - 하나 이상의 추상함수를 포함하는 클래스
        // - 클래스가 추상적인 표현을 정의하는 경우 자식에서 구체화시켜 구현할것을 염두하고 추상화 시킨다
        // 추상클래스를 상속하는 자식클래스가 추상함수를 재정의 하여 구체화한 경우 사용 가능
        //

        abstract class Item // 추상클래스 : 하나 이상의 추상함수를 포함하는 클래스, 추상클래스에서 구현하지 않고 선언만함 
        {
            // 클래스에서 구현을 하지 않고 선언만 한다 (자식에서 반드시 구현 ->구체화)
            public abstract void Use();
        }

        class Potion : Item
        {
            public override void Use()
            {
                Console.WriteLine("포션 꿀렁꿀렁 ~ 체력회복");
            }
        }

        abstract class Animal
        {
            // 상위클래스에서 구현하기 어려운 기능
            // -> 무슨 동물이 도대체 어떻게 우는데 ?
            public abstract void Cry();
        }

        class Cat : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("야옹야옹");
            }
        }
        
        abstract class Shape
        {
            public abstract void Draw();

            public virtual void Show()
            {
                Console.WriteLine("shape 출력");
            }

        }

        class Circle : Shape
        {
            double radius;
            
            public Circle (double radius)
            {
                this.radius = radius;
            }

            public override void Draw()
            {
                Console.WriteLine($"반지름{radius}");
            }

            public override void Show()
            {
                 base.Show();
               // Console.WriteLine("구 ");
            }
        }

        class Rectangle : Shape
        {
            double width;
            double height;
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public override void Draw()
            {
                
                Console.WriteLine($"넓이{width*height}");
            }
        }

        static void Main(string[] args)
        {
            // Item item = new Item(); // 추상클래스는 인스턴스 생성 X, 실체화를 시킬 수 없음
            // 구체화한 자식에서는 인스턴스 생성이 가능하고 기능을 사용할 수 있음 
            Item item = new Potion();
            item.Use();
            Circle circle = new Circle(10);
            circle.Show();
            circle.Draw();
           
            
        }
    }
}
