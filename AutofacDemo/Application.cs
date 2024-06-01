using AutofacDemo.DemoLibrary;

namespace AutofacDemo
{
    public class Application : IApplication
    {
        private readonly IBusinessLogic businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            this.businessLogic = businessLogic;
        }

        public void Run()
        {
            businessLogic.Process();
        }
    }
}
