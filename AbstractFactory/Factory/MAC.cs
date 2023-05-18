namespace AbstractFactory.Factory
{
    internal class MAC : IBrand
    {
        public string GetBrandName()
        {
            return Brands.Apple.ToString();
        }
    }
}
