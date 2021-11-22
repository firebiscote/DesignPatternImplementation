/*Le patron de conception Chaîne de responsabilité permet 
 * à un nombre quelconque de classes d'essayer de répondre 
 * à une requête sans connaître les possibilités des autres 
 * classes sur cette requête. Cela permet de diminuer le 
 * couplage entre objets. Le seul lien commun entre ces 
 * objets étant cette requête qui passe d'un objet à l'autre 
 * jusqu'à ce que l'un des objets puisse répondre.
 */

using System;

namespace DesignPatternImplementation.Behavior
{
    public class Logger
    {
        protected int level;
        public Logger Next { get; set; }

        public enum Type : int
        {
            ERROR = 0,
            NOTICE = 1,
            DEBUG = 2
        }

        public void Message(string message, int priority)
        {
            if (priority <= level)
                WriteMessage(message);
            if (Next != null)
                Next.Message(message, priority);
        }

        public virtual void WriteMessage(string message) { }
    }

    public class DebugLogger : Logger
    {
        public DebugLogger(int level)
        {
            this.level = level;
            this.Next = null;
        }

        public override void WriteMessage(string message)
        {
            Console.WriteLine("Debug message " + message);
        }
    }

    public class EmailLogger : Logger
    {
        public EmailLogger(int level)
        {
            this.level = level;
            this.Next = null;
        }

        public override void WriteMessage(string message)
        {
            Console.WriteLine("Email message " + message);
        }
    }

    public class ErrorLogger : Logger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
            this.Next = null;
        }

        public override void WriteMessage(string message)
        {
            Console.WriteLine("Error " + message);
        }
    }

    public class ChainImplementation
    {
        public void Main()
        {
            Logger logger = new DebugLogger((int)Logger.Type.DEBUG);
            Logger logger2 = new EmailLogger((int)Logger.Type.NOTICE);
            Logger logger3 = new ErrorLogger((int)Logger.Type.ERROR);
            logger.Next = logger2;
            logger2.Next = logger3;
        }
    }

}
