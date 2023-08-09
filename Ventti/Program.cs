using Ventti.Model;
using Ventti.Presenter;
using Ventti.View;

namespace TwentyOneCardGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //  Console.OutputEncoding = System.Text.Encoding.UTF8;

            IView view = new ConsoleView();
            IModel model = new GameVenttiModel();

            IPresenter presenter = new VenttiPresenter(view, model);
            presenter.PlayGame();

            Console.ReadLine();
        }






    }
}


