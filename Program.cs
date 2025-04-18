using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
  static void Main()
  {
    string[] input = Console.ReadLine().Split(" ");
    int N = int.Parse(input[0]);
    int K = int.Parse(input[1]);

    // 客数定義
    List<Customer> customers = new List<Customer>();
    for (int i = 0; i < N; i++)
    {
      Customer customer = new Customer(int.Parse(Console.ReadLine()));
      customers.Add(customer);
    }

    // 注文ロジック
    for (int i = 0; i < K; i++)
    {
      string[] orders = Console.ReadLine().Split(" ");
      int index = int.Parse(orders[0]) - 1;
      string category = orders[1];
      int price = int.Parse(orders[2]);

      customers[index].Order(category, price);
    }

    // 会計出力
    foreach (Customer customer in customers)
    {
      Console.WriteLine(customer.Payment);
    }
  }
}


class Customer
{
  public int Age { get; set; }
  public bool HasDiscount { get; set; } = false;
  public int Payment { get; set; } = 0;

  public Customer(int age)
  {
    this.Age = age;
  }

  public void Order(string category, int payment)
  {
    switch (category)
    {
      case "food":
        this.Payment += this.HasDiscount ? (payment - 200) : payment;
        break;

      case "alcohol":
        if (this.Age < 20)
        {
          break;
        }
        this.Payment += payment;
        this.HasDiscount = true;
        break;

      case "softdrink":
        this.Payment += payment;
        break;
    }
  }
}