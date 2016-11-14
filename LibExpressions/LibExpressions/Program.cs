using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression expr = new PlusExpression(
                left: new ConstantExpression(4),
                right : new MinusExpression(
                    left:new ConstantExpression(1),
                    right: new ConstantExpression(2)     //
                    )
            );

            Console.Write(expr.ToString());
            Console.Write(" = ");
            Console.WriteLine(expr.Evaluate());


            Console.ReadKey();

        }
    }
}
