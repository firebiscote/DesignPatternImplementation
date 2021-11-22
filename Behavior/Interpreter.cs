/*Ce patron définit comment interpréter les éléments du 
 * langage. Dans ce patron de conception, il y a une 
 * classe par symbole terminal et non-terminal du 
 * langage à interpréter. L'arbre de syntaxe du 
 * langage est représenté par une instance du patron 
 * de conception Objet composite.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternImplementation.Behavior
{
    public interface IExpression
    {
        public void Interpret(Stack<int> stack);
    }

    public class TerminalExpressionNumber : IExpression
    {
        private int number;

        public TerminalExpressionNumber(int number)
        {
            this.number = number;
        }

        void IExpression.Interpret(Stack<int> stack)
        {
            stack.Push(number);
        }
    }

    public class TerminalExpressionPlus : IExpression
    {
        void IExpression.Interpret(Stack<int> stack)
        {
            stack.Push(stack.Pop() + stack.Pop());
        }
    }

    public class TerminalExpressionMinus : IExpression
    {
        void IExpression.Interpret(Stack<int> stack)
        {
            stack.Push(-stack.Pop() + stack.Pop());
        }
    }

    public class Parser
    {
        private List<IExpression> parseTree = new List<IExpression>();

        public Parser(string s)
        {
            foreach (string token in s.Split(" "))
            {
                if (token == "+")
                {
                    parseTree.Add(new TerminalExpressionPlus());
                } else if (token == "-")
                {
                    parseTree.Add(new TerminalExpressionMinus());
                } else
                {
                    parseTree.Add(new TerminalExpressionNumber(int.Parse(token)));
                }
            }
        }

        public int Evaluate()
        {
            Stack<int> context = new Stack<int>();
            foreach (IExpression e in parseTree)
                e.Interpret(context);
            return context.Pop();
        }
    }
}
