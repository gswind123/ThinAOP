using System;
using System.Collections.Generic;
using System.Text;
using ThinAOP;
using System.Reflection;

namespace TestThinAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc calc2 = ProxyFactory.CreateProxy<ICalc>(typeof(Calculater));
            calc2.Add(2, 3);
            calc2.Divide(6, 3);
            calc2.Divide(6, 0);
            
            Console.ReadKey(true);
        }
    }

    public class LogStartAttribute : PreAspectAttribute
    {
        public override void Action(InvokeContext context)
        {
            Console.WriteLine("log start!");
        }
    }

    public class LogEndAttribute : PostAspectAttribute
    {
        public override void Action(InvokeContext context)
        {
            Console.WriteLine("log end!");
        }
    }

    public class LogExAttribute : ExceptionAspectAttribute
    {
        public override void Action(InvokeContext context)
        {
            Console.WriteLine("log exception!");
        }
    }

    public interface ICalc
    {
        void Add(int a, int b);
        void Divide(int a, int b);
    }

    public class Calculater : ICalc
    {
        [LogStart]
        [LogEnd]
        public void Add(int a, int b)
        {
            Console.WriteLine("a+b=" + (a + b).ToString());
        }

        [LogEx]
        public void Divide(int a, int b)
        {
            Console.WriteLine("a/b=" + (a / b).ToString());
        }
    }

}
