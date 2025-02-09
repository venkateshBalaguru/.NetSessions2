using AutofactoryCommonLib.Products;
namespace ApplicationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new AutoMobileFactory();
            var auto = factory.Make(AutoType.Benz);
            auto.Start();
            auto.Stop();
            Console.WriteLine(auto.GetType());
        }
    }
}
