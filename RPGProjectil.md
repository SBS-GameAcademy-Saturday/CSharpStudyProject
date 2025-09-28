# RPG 게임 프로젝트 - Delegate, Event 및 스킬 시스템 추가

아래 코드는 delegate로 스킬의 형태를 정의하고, event를 통해 스킬 사용 시 발생하는 효과를 구현합니다. 플레이어는 3가지 스킬(평타, 강한 공격, 힐)을 사용할 수 있으며, 각 스킬은 턴마다 다른 행동을 수행합니다.

```csharp
using System;
using System.Threading;

// 1. 스킬 효과를 위한 Delegate 선언
public delegate void SkillAction(Character target);

// 모든 캐릭터의 기본 클래스
public class Character
{
    protected string _name;
    protected int _health;
    protected int _attackPower;
    
    public string Name => _name;
    public int Health => _health;

    public virtual void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;
        Console.WriteLine($"{_name}이(가) {damage}의 피해를 입었습니다. 현재 체력: {_health}");
    }

    public bool IsAlive()
    {
        return _health > 0;
    }
}

// 2. 스킬 클래스
public class Skill
{
    public string Name { get; private set; }
    // 3. SkillAction delegate를 기반으로 한 이벤트 선언
    public event SkillAction OnSkillUsed;

    public Skill(string name)
    {
        Name = name;
    }

    // 스킬 사용 메서드: 이벤트를 호출하여 스킬 효과를 발생시킴
    public void Use(Character target)
    {
        Console.WriteLine($"\n{Name} 스킬을 사용합니다!");
        // 이벤트 핸들러가 있을 때만 호출 (null 체크)
        OnSkillUsed?.Invoke(target);
    }
    
    // 이벤트 핸들러 추가
    public void AddEffect(SkillAction action)
    {
        OnSkillUsed += action;
    }
}

// 플레이어 클래스 (Character를 상속받음)
public class Player : Character
{
    private Skill _skill1;
    private Skill _skill2;
    private Skill _skill3;

    public Player(string name, int health, int attackPower)
    {
        _name = name;
        _health = health;
        _attackPower = attackPower;
        
        // 스킬들을 초기화하고 이벤트 핸들러를 연결
        _skill1 = new Skill("평타");
        _skill1.AddEffect(target => target.TakeDamage(_attackPower));

        _skill2 = new Skill("강한 공격");
        _skill2.AddEffect(target => target.TakeDamage(_attackPower * 2));
        
        _skill3 = new Skill("회복");
        _skill3.AddEffect(target => Heal(20)); // 플레이어 자신을 회복하는 힐 스킬
    }

    public void UseSkill(int skillNumber, Character target)
    {
        switch (skillNumber)
        {
            case 1:
                _skill1.Use(target);
                break;
            case 2:
                _skill2.Use(target);
                break;
            case 3:
                _skill3.Use(this); // 힐 스킬은 자기 자신을 대상으로 함
                break;
            default:
                Console.WriteLine("잘못된 스킬 번호입니다.");
                break;
        }
    }
    
    private void Heal(int amount)
    {
        _health += amount;
        Console.WriteLine($"{_name}이(가) {amount}만큼 체력을 회복했습니다. 현재 체력: {_health}");
    }
}

// 몬스터 클래스 (Character를 상속받음)
public class Monster : Character
{
    public Monster(string name, int health, int attackPower)
    {
        _name = name;
        _health = health;
        _attackPower = attackPower;
    }

    public void Attack(Character target)
    {
        Console.WriteLine($"{_name}이(가) {target.Name}를 공격합니다!");
        target.TakeDamage(_attackPower);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- 간단한 RPG 게임 시작! ---");
        
        Player player = new Player("용감한 전사", 100, 10);
        Monster goblin = new Monster("고블린", 50, 5);
        
        Console.WriteLine($"{player.Name}이(가) 나타났습니다.");
        Console.WriteLine($"{goblin.Name}이(가) 길을 막고 있습니다.");
        
        while (player.IsAlive() && goblin.IsAlive())
        {
            Thread.Sleep(1000);
            Console.WriteLine("\n--- 턴 시작 ---");
            Console.WriteLine($"[현재 상태] {player.Name} 체력: {player.Health}, {goblin.Name} 체력: {goblin.Health}");
            
            // 플레이어 턴 (스킬 선택)
            Console.WriteLine("스킬을 선택하세요: 1. 평타, 2. 강한 공격, 3. 회복");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int skillNumber))
            {
                player.UseSkill(skillNumber, goblin);
            }
            
            if (!goblin.IsAlive())
            {
                Console.WriteLine($"\n{goblin.Name}을(를) 물리쳤습니다! 🎉");
                break;
            }
            
            // 몬스터 턴
            Thread.Sleep(500);
            goblin.Attack(player);
            
            if (!player.IsAlive())
            {
                Console.WriteLine($"\n{player.Name}이(가) 쓰러졌습니다... 💀");
                break;
            }
        }
        
        Console.WriteLine("--- 게임 종료 ---");
    }
}
```

## 주요 코드 설명
- delegate void SkillAction(Character target);: delegate를 선언하여 스킬이 어떤 대상을 받아 어떤 행동을 할지 형태를 정의했습니다.
- Skill 클래스: 이 클래스는 스킬의 이름과 실제 효과를 담당하는 **event**를 가지고 있습니다.\
- event SkillAction OnSkillUsed;: 이벤트를 선언하여 스킬 사용 시 외부에서 정의된 행동을 알립니다.
- Use(Character target): 이 메서드는 OnSkillUsed?.Invoke(target)를 통해 이벤트에 등록된 모든 메서드(스킬 효과)를 호출합니다.

## Player 클래스:
생성자에서 3개의 Skill 객체를 생성하고, 각 스킬의 AddEffect 메서드를 통해 람다식으로 스킬 효과를 이벤트 핸들러로 등록했습니다.
_skill1 (평타)와 _skill2 (강한 공격)는 target.TakeDamage(...)로 몬스터에게 피해를 입히고, _skill3 (회복)은 Heal(...) 메서드를 호출하여 플레이어 자신을 치유합니다.
이러한 구조는 스킬의 효과를 클래스와 분리하여 관리하고, 새로운 스킬을 추가할 때 기존 코드를 수정하지 않고 유연하게 확장할 수 있게 해줍니다.
