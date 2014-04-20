#region Using

using System;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Wpf.Views;
using CodeVault.Wpf.Bootstrap;

#endregion

namespace CodeVault.Wpf
{
    public partial class App
    {
        /// <summary>
        ///     Setup complete indicator.
        /// </summary>
        private bool _setupComplete;

        /// <summary>
        ///     Does the setup.
        /// </summary>
        private void DoSetup()
        {
            var presenter = new MvxSimpleWpfViewPresenter(MainWindow);

            var setup = new Setup(Dispatcher, presenter);
            setup.Initialize();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            _setupComplete = true;
        }

        /// <summary>
        ///     Raises the <see cref="E:System.Windows.Application.Activated" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnActivated(EventArgs e)
        {
            if (!_setupComplete)
            {
                DoSetup();
            }

            base.OnActivated(e);
        }
    }
}