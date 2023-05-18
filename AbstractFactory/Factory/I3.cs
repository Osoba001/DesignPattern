namespace AbstractFactory.Factory
{
    internal class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Processor.I3.ToString();
        }
    }
}
