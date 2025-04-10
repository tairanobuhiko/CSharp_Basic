namespace MyClass
{
  public class Sample
  {
    public void SamplePrint((int age, String name) sample)
    {
      Console.WriteLine($"私の名前は{sample.name}です。年齢は{sample.age}歳です");
    }
  }
}
