public class Test
{
    public int Prop1 { get; set; }

    public int Prop2 { get; set; }

    public Test() { }

    public void ChangeFieldsValue(int Prop1,int Prop2)
    {
        this.Prop1 = Prop1;
        this.Prop2 = Prop2;
        Console.WriteLine("Значения полей успешно изменены");
    }
    public void SetNullFields()
    {
        this.Prop1 = 0;
        this.Prop2 = 0;
        Console.WriteLine("Поля успешно обнулены");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Test test = new Test();
        int newProp = int.Parse(Console.ReadLine());
        int secondNewProp = int.Parse(Console.ReadLine());
        test.ChangeFieldsValue(newProp, secondNewProp);
        Console.WriteLine($"Prop1: {test.Prop1}, Prop2: {test.Prop2}");
        Console.ReadKey();
    }
}