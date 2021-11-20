namespace DesignPatternImplementation
{
    public class Controller
    {
        private static Controller instance;
        static readonly object instanceLock = new object();

        private Controller() { }

        public static Controller getModel()
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