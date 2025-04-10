namespace MyClass
{
  public class Sample
  {
    // 自動実装プロパティ（アクセサ）
    string name {get; set;} = "nobuhiko";
    int age {get; set;} = 38;

    // コンストラクタ
    public Sample(int age, string name)
    {
      this.age = age;
      this.name = name;
    }
    public void SamplePrint((int age, String name) sample)
    {
      Console.WriteLine($"私の名前は{sample.name}です。年齢は{sample.age}歳です");
    }

    // メソッドのオーバーロード
    public void SamplePrint()
    {
      Console.WriteLine($"私の名前は{this.name}です。年齢は{this.age}歳です");
    }
  }
}
