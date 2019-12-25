using Model.Service;
using Ninject;
using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ICalculatorView>().To<CalculatorView>();

            kernel.Bind<ICalculatorService>().To<CalculatorService>().InSingletonScope();

            kernel.Bind<CalculatorPresenter>().ToSelf();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            kernel.Get<CalculatorPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
