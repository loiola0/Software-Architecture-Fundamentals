namespace Singleton
{
    public sealed class Chair
    {
        private static readonly Chair instance = new Chair();

        public int Quantity {get;set;}


        public static Chair Instance
        {
            get
            {
                return instance;
            }
        }

    }
}