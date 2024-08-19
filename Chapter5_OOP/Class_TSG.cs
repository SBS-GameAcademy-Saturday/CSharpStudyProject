using System;

namespace TextRPG
{
  /// <summary>
  /// Character 클래스는 모든 캐릭터의 공통 속성 및 행동을 정의합니다.
  /// </summary>
  public abstract class Character
  {
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public Character(string name, int health, int attackPower)
    {
      Name = name;
      Health = health;
      AttackPower = attackPower;
    }

    /// <summary>
    /// 캐릭터가 공격을 받았을 때의 로직을 처리합니다.
    /// </summary>
    /// <param name="damage">받는 데미지 양</param>
    public void TakeDamage(int damage)
    {
      Health -= damage;
      if (Health <= 0)
      {
        Console.WriteLine($"{Name} has been defeated!");
      }
    }

    /// <summary>
    /// 캐릭터가 공격할 때의 행동을 정의합니다. 서브 클래스에서 구체화됩니다.
    /// </summary>
    /// <param name="target">공격할 대상</param>
    public abstract void Attack(Character target);
  }
  /// <summary>
  /// Player 클래스는 플레이어 캐릭터의 속성과 행동을 정의합니다.
  /// </summary>
  public class Player : Character
  {
    public Player(string name, int health, int attackPower)
        : base(name, health, attackPower)
    {
    }

    /// <summary>
    /// 플레이어가 공격할 때의 로직을 처리합니다.
    /// </summary>
    /// <param name="target">공격할 대상 캐릭터</param>
    public override void Attack(Character target)
    {
      Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage.");
      target.TakeDamage(AttackPower);
    }
  }

  /// <summary>
  /// Monster 클래스는 몬스터의 속성과 행동을 정의합니다.
  /// </summary>
  public class Monster : Character
  {
    public Monster(string name, int health, int attackPower)
        : base(name, health, attackPower)
    {
    }

    /// <summary>
    /// 몬스터가 공격할 때의 로직을 처리합니다.
    /// </summary>
    /// <param name="target">공격할 대상 캐릭터</param>
    public override void Attack(Character target)
    {
      Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage.");
      target.TakeDamage(AttackPower);
    }
  }

  public class Game
  {
    public void Start()
    {
      // 플레이어와 몬스터 생성
      Player player = new Player("Hero", 100, 20);
      Monster monster = new Monster("Goblin", 50, 10);

      // 전투 시작
      Console.WriteLine("A wild goblin appears!");

      while (player.Health > 0 && monster.Health > 0)
      {
        // 플레이어의 턴
        player.Attack(monster);
        if (monster.Health > 0)
        {
          // 몬스터의 턴
          monster.Attack(player);
        }
      }

      // 전투 종료
      if (player.Health > 0)
      {
        Console.WriteLine("You have defeated the goblin!");
      }
      else
      {
        Console.WriteLine("You have been defeated...");
      }
    }
  }
}