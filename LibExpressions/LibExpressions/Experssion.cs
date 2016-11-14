using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibExpressions
{
    public abstract class Expression
    {
        public abstract double Evaluate(); 
    }
    public sealed class ConstantExpression:Expression
    {
        private readonly double value;

        //public ConstantExperssion()
        //{
        //}

        public override double Evaluate()
        {
            return value;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }

    public abstract class BinaryExperssion : Expression
    {
        protected Expression left;
        protected Expression right;
        // TODO: public readonly string OperatorSymbol
        public  string OperatorSymbol
        {
            private set; // eller udelad for Read-only
            get;
            }
        public sealed override string ToString()
        {
            return left.ToString() +" " + right.ToString() ;
        }
    }
    public class PlusExpression : BinaryExperssion
    {
        public override double Evaluate()
        {
            return this.left.Evaluate() + this.right.Evaluate() ;
        }
        public PlusExpression PlusExpresion(Exception left,Exception right)
        {
            this.left  = left;
            this.right = right;
            OperatorSymbol = "+";
        }
    }


}
