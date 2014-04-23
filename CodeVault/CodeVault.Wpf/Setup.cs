#region Using

using System.Windows.Threading;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.Wpf.Platform;
using Cirrious.MvvmCross.Wpf.Views;
using MupApps.MvvmCross.Plugins.ControlsNavigation.Wpf;

#endregion

namespace CodeVault.Wpf
{
    public class Setup : MvxWpfSetup
    {
        private readonly IMvxWpfViewPresenter _presenter;
        private readonly Dispatcher _uiThreadDispatcher;

        public Setup(Dispatcher dispatcher, IMvxWpfViewPresenter presenter)
            : base(dispatcher, presenter)
        {
            _uiThreadDispatcher = dispatcher;
            _presenter = presenter;
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override IMvxViewDispatcher CreateViewDispatcher()
        {
            var controlPresenter = new MvxWpfControlPresenter(_presenter);

            return new MvxWpfViewDispatcher(_uiThreadDispatcher, controlPresenter);
        }
    }
}