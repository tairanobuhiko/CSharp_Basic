using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
  static void Main()
  {
    List<User> users = new List<User>();
    string input = Console.ReadLine();
    List<string> inputs = input.Split(" ").ToList();

    int n = int.Parse(inputs[0]);
    int k = int.Parse(inputs[1]);

    // 名簿リストへの登録
    for (int i = 0; i < n; i++)
    {
      string[] memberInfo = Console.ReadLine().Split(" ");
      User user = new User(memberInfo[0], int.Parse(memberInfo[1]), memberInfo[2], memberInfo[3]);
      users.Add(user);
    }

    // 名簿の更新
    for (int i = 0; i < k; i++)
    {
      string[] target = Console.ReadLine().Split(" ");
      int targetNum = int.Parse(target[0]) - 1;
      string updateName = target[1];
      users[targetNum].ChangeName(updateName);
    }

    // 名簿の出力
    foreach (User user in users)
    {
      Console.WriteLine($"{user.nickname} {user.old} {user.birth} {user.state}");
    }
  }
}

class User
{
  public string nickname { get; set; } = string.Empty;
  public int old { get; set; } = 0;
  public string birth { get; set; } = "YYYY/MM/DD";
  public string state { get; set; } = string.Empty;

  public User(string nickname, int old, string birth, string state)
  {
    this.nickname = nickname;
    this.old = old;
    this.birth = birth;
    this.state = state;
  }

  public void ChangeName(string nickname)
  {
    this.nickname = nickname;
  }
}