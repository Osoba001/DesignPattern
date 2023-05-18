namespace AbstractFactory.Factory
{
    internal class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processor.I5.ToString();
        }
    }
}
