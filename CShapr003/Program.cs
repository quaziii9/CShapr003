namespace CShapr003
{
    /*
     값 형식 (value)
     - 복사할때 실제값이 복사됨(깊은복사)
     - 구조체가 여기에 속함.

     참조 형식(reference)
     - 복사할때 객체의 주소가 복사됨(얕은복사)
     - 클래스가 여기에 속함
     */
    
    internal class Program
    {
        struct ValueType
        {
            public int value;

            public ValueType(int v)
            {
                value = v;
            }
        }
        class RefType
        {
            public int value;
            public RefType(int v)
            {
                value = v;
            }
        }

        static void Test()
        {
            ValueType valueType1 = new ValueType(10);
            ValueType valueType2 = valueType1;  // 값이 복사
            valueType2.value = 20;  // 값을 대입해도 원본에는 영향 X
            Console.WriteLine(valueType1.value); // 10

            RefType refType1 = new RefType(10);
            RefType refType2 = refType1;    // 객체 주소 복사
            refType2.value = 20;            // 원본 데이터 변경
            Console.WriteLine(refType1.value); 
        }

        static void Swap(ValueType left, ValueType right)
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }
        static void Swap(RefType left, RefType right)
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
        }

        static void Test01()
        {
            ValueType leftvalue = new ValueType(10);
            ValueType rightvalue = new ValueType(20);
            
            Swap(leftvalue, rightvalue);
            Console.WriteLine($"{leftvalue.value}, {rightvalue.value}");

            RefType leftRef = new RefType(10);
            RefType rightRef = new RefType(20);

            Swap(leftRef, rightRef);
            Console.WriteLine($"{leftRef.value}, {rightRef.value}");
        }

        static void Main(string[] args)
        {
             Test();
           // Test01();
        }
    }
}
