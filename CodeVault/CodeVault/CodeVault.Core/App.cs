#region Using

using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using CodeVault.Core.ViewModels;

#endregion

namespace CodeVault.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Start the app with the First View Model.
            RegisterAppStart<ShellViewModel>();
        }
    }
}