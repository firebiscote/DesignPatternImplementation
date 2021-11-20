namespace DesignPatternImplementation
{
    public class Model
    {
        private static Model instance;
        static readonly object instanceLock = new object();

        private Model() { }

        public static Model getModel()
        {
            lock (instanceLock)
            {
                if (instance == null)
                    instance = new Model();
                return instance;
            }
        }
    }
}