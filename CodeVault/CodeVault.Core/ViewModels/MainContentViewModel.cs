namespace CodeVault.Core.ViewModels
{
    public class MainContentViewModel : BaseViewModel
    {
        public MainContentViewModel()
        {
            ShowViewModel<SidebarViewModel>();
        }
    }
}