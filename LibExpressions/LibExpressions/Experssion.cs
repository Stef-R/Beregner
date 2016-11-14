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

        public ConstantExpression(double value)
        {
            this.value = value;
        }

        public override double Evaluate()
        {
            return value;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }

    public abstract class BinaryExpression : Expression
    {
        protected readonly Expression left;
        protected readonly Expression right;
        // TODO: public readonly string OperatorSymbol
        protected BinaryExpression(Expression left, Expression right)
        {
            this.left  = 
                left;
            this.right = right;
        }

        public abstract string OperatorSymbol
        {
            get;
            //private set; // eller udelad for Read-only
        }
        public sealed override string ToString()
        {
            return "(" + left.ToString() +" " + OperatorSymbol + " "+ right.ToString() + ")";
        }
    }
    public class PlusExpression : BinaryExpression
    {
        public PlusExpression(Expression left, Expression right) : base(left, right)
        {
        }

        public override string OperatorSymbol        {            get  {return "+";}        }

        public override double Evaluate()
        {
            return this.left.Evaluate() + this.right.Evaluate() ;
        }
        //public PlusExpression PlusExpresion(Exception left,Exception right)
        //{
        //    this.left  = left;
        //    this.right = right;
        //    OperatorSymbol = "+";
        //}
    }

    public class MinusExpression : BinaryExpression
    {
        public MinusExpression(Expression left, Expression right) : base(left, right)    { }

        public override string OperatorSymbol  { get  {  return "-";   }        }

        public override double Evaluate()
        {
            return left.Evaluate() - right.Evaluate();
        }
    }


}
