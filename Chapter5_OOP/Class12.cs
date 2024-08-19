using System;

namespace CSharp_ProgramingStudy.Chapter5_OOP
{
  /// <summary>
  /// 클래스 설계 원칙 (Class Design Principles)
  /// 목표: 객체 지향 프로그래밍에서 클래스를 설계할 때 따라야 할 기본 원칙을 학습한다.
  /// 
  /// 이 자료에서는 SOLID 원칙을 중심으로, 클래스 설계의 기본 원칙들을 설명합니다. 
  /// SOLID 원칙은 객체 지향 설계에서 코드의 유연성과 유지 보수성을 높이기 위해 제안된 5가지 기본 원칙입니다.
  /// 1. 단일 책임 원칙 (Single Responsibility Principle, SRP):
  /// 클래스는 단 하나의 책임만 가져야 하며, 그 책임에 따라 클래스가 변경될 이유도 단 하나뿐이어야 합니다. 
  /// 이는 클래스의 응집도를 높이고, 변경에 유연하게 대응할 수 있도록 돕습니다.
  /// 2. 개방/폐쇄 원칙 (Open/Closed Principle, OCP):
  /// 클래스는 확장에는 열려 있어야 하지만, 수정에는 닫혀 있어야 합니다. 
  /// 즉, 새로운 기능을 추가할 때 기존 코드를 수정하지 않고도 확장할 수 있어야 합니다.
  /// 
  /// 3. 리스코프 치환 원칙 (Liskov Substitution Principle, LSP):
  /// 서브 클래스는 언제나 자신의 기반 클래스 타입으로 대체할 수 있어야 합니다. 
  /// 이는 상속을 사용하는 클래스 설계에서 중요한 개념으로, 다형성을 보장합니다.
  /// 
  /// 4. 인터페이스 분리 원칙 (Interface Segregation Principle, ISP):
  /// 특정 클라이언트를 위한 인터페이스 여러 개가 범용 인터페이스 하나보다 낫습니다. 
  /// 즉, 클라이언트는 자신이 사용하지 않는 메서드에 의존하지 않아야 합니다.
  /// 
  /// 5. 의존성 역전 원칙 (Dependency Inversion Principle, DIP):
  /// 고수준 모듈은 저수준 모듈에 의존해서는 안 되며, 둘 다 추상화에 의존해야 합니다. 
  /// 이는 코드의 결합도를 낮추고, 유연성을 높이기 위한 원칙입니다.
  /// </summary>
  public class Class12
  {
    /// <summary>
    /// 1. 단일 책임 원칙 (Single Responsibility Principle, SRP)
    /// - 설명: 클래스는 단 하나의 책임만 가져야 하며, 그 책임을 완전히 캡슐화해야 합니다. 
    ///        이는 클래스가 변화해야 할 이유가 오직 하나뿐이어야 함을 의미합니다.
    /// - 예제: 다음 예제에서 UserManager 클래스는 사용자를 관리하는 책임만 가지고 있습니다.
    /// </summary>
    public class UserManager
    {
      public void AddUser(string username)
      {
        Console.WriteLine($"User '{username}' added.");
      }
    }

    /// <summary>
    /// 2. 개방/폐쇄 원칙 (Open/Closed Principle, OCP)
    /// - 설명: 클래스는 확장에는 열려 있어야 하지만, 수정에는 닫혀 있어야 합니다. 
    ///        즉, 새로운 기능을 추가할 때 기존 코드를 수정하지 않고도 확장할 수 있어야 합니다.
    /// - 예제: 다음 예제에서, DiscountCalculator 클래스는 새로운 할인 정책을 추가할 때 기존 코드를 수정하지 않고도 확장 가능합니다.
    /// </summary>
    public abstract class DiscountCalculator
    {
      public abstract double CalculateDiscount(double totalPrice);
    }

    public class NoDiscount : DiscountCalculator
    {
      public override double CalculateDiscount(double totalPrice)
      {
        return totalPrice;
      }
    }

    public class PercentageDiscount : DiscountCalculator
    {
      private double percentage;
      public PercentageDiscount(double percentage)
      {
        this.percentage = percentage;
      }

      public override double CalculateDiscount(double totalPrice)
      {
        return totalPrice - (totalPrice * percentage / 100);
      }
    }

    /// <summary>
    /// 3. 리스코프 치환 원칙 (Liskov Substitution Principle, LSP)
    /// - 설명: 서브 클래스는 언제나 자신의 기반 클래스 타입으로 대체할 수 있어야 합니다. 
    ///        즉, 서브 클래스는 기반 클래스의 행동을 그대로 유지하면서 확장해야 합니다.
    /// - 예제: 다음 예제에서, Rectangle과 Square 클래스는 모두 Shape 클래스를 상속받고 있으며, Shape 타입으로 대체 가능해야 합니다.
    /// </summary>
    public class Shape
    {
      public virtual int Area() => 0;
    }

    public class Rectangle : Shape
    {
      public int Width { get; set; }
      public int Height { get; set; }

      public override int Area() => Width * Height;
    }

    public class Square : Rectangle
    {
      public override int Area() => Width * Width;
    }

    /// <summary>
    /// 4. 인터페이스 분리 원칙 (Interface Segregation Principle, ISP)
    /// - 설명: 특정 클라이언트를 위한 인터페이스 여러 개가 범용 인터페이스 하나보다 낫습니다. 
    ///        즉, 클라이언트는 자신이 사용하지 않는 메서드에 의존하지 않아야 합니다.
    /// - 예제: 다음 예제에서, IPrinter는 인쇄 기능만 제공하고, IScanner는 스캔 기능만 제공합니다.
    /// </summary>
    public interface IPrinter
    {
      void Print(string content);
    }

    public interface IScanner
    {
      void Scan(string document);
    }

    public class MultiFunctionPrinter : IPrinter, IScanner
    {
      public void Print(string content)
      {
        Console.WriteLine($"Printing: {content}");
      }

      public void Scan(string document)
      {
        Console.WriteLine($"Scanning: {document}");
      }
    }

    /// <summary>
    /// 5. 의존성 역전 원칙 (Dependency Inversion Principle, DIP)
    /// - 설명: 고수준 모듈은 저수준 모듈에 의존해서는 안 되며, 둘 다 추상화에 의존해야 합니다. 
    ///        즉, 구현이 아닌 추상화에 의존해야 합니다.
    /// - 예제: 다음 예제에서, NotificationService는 EmailSender와 SmsSender와 같은 저수준 구현에 의존하지 않고, ISender 인터페이스에 의존합니다.
    /// </summary>
    public interface ISender
    {
      void Send(string message);
    }

    public class EmailSender : ISender
    {
      public void Send(string message)
      {
        Console.WriteLine($"Sending email: {message}");
      }
    }

    public class SmsSender : ISender
    {
      public void Send(string message)
      {
        Console.WriteLine($"Sending SMS: {message}");
      }
    }

    public class NotificationService
    {
      private readonly ISender _sender;

      public NotificationService(ISender sender)
      {
        _sender = sender;
      }

      public void Notify(string message)
      {
        _sender.Send(message);
      }
    }

    /// <summary>
    /// Run 메서드: 각 설계 원칙의 예제를 실행
    /// </summary>
    public void Run()
    {
      // SRP 예제 실행
      UserManager userManager = new UserManager();
      userManager.AddUser("JohnDoe");

      // OCP 예제 실행
      DiscountCalculator calculator = new PercentageDiscount(10);
      Console.WriteLine($"Discounted Price: {calculator.CalculateDiscount(100)}");

      // LSP 예제 실행
      Shape rectangle = new Rectangle { Width = 4, Height = 5 };
      Shape square = new Square { Width = 4 };
      Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
      Console.WriteLine($"Square Area: {square.Area()}");

      // ISP 예제 실행
      MultiFunctionPrinter mfp = new MultiFunctionPrinter();
      mfp.Print("Document");
      mfp.Scan("Photo");

      // DIP 예제 실행
      NotificationService notificationService = new NotificationService(new EmailSender());
      notificationService.Notify("Hello World!");
    }
  }
}
