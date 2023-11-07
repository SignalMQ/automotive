using automotive.Views;

namespace automotive.Factory
{
    public interface IMenuViewFactory
    {
        MenuView Create();
    }

    public class MenuViewFactory: IMenuViewFactory
    {
        public MenuView Create()
        {
            return new MenuView();
        }
    }
}
