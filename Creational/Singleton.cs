namespace DesignPatternImplementation
{
    public class Controller
    {
        private static Controller instance;
        static readonly object instanceLock = new object();

        private Controller() { }

        public static Controller GetModel()
        {
            lock (instanceLock)
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }
    }
}