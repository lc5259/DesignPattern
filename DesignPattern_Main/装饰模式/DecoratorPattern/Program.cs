namespace DecoratorPattern
{
    /// <summary>
    /// 装饰模式
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new Person { Name = "小菜" };
            Finery tShirts = new TShirts();
            Finery bigTrouser = new BigTrouser();
            Finery sneakers = new Sneakers();
            tShirts.Decorate(person);
            bigTrouser.Decorate(tShirts);
            sneakers.Decorate(bigTrouser);
            sneakers.Show();
           
            Console.ReadLine();
        }
    }
    /// <summary>
    /// 对象类
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine($"装扮的{this.Name}");
        }
    }
    /// <summary>
    /// 功能的基类
    /// </summary>
    public abstract class Finery : Person
    {
        protected Person component;
        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
    public class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("破球鞋");
            base.Show();
        }
    }
    public class Suit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("西装");
            base.Show();
        }
    }

}
