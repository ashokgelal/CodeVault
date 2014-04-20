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
    /// <summary>
    ///  Defines the Setup type.
    /// </summary>
    public class Setup : MvxWpfSetup
    {
        private readonly Dispatcher _dispatcher;
        private readonly IMvxWpfViewPresenter _presenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="dispatcher">The dispatcher.</param>
        /// <param name="presenter">The presenter.</param>
        public Setup(Dispatcher dispatcher, IMvxWpfViewPresenter presenter)
            : base(dispatcher, presenter)
        {
            _dispatcher = dispatcher;
            _presenter = presenter;
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        /// <summary>
        /// Creates the app.
        /// </summary>
        /// <returns>An instance of MvxApplication</returns>
        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxViewDispatcher CreateViewDispatcher()
        {
            var controlPresenter = new MvxWpfControlPresenter(_presenter);
            return new MvxWpfViewDispatcher(_dispatcher, controlPresenter);
        }
    }
}