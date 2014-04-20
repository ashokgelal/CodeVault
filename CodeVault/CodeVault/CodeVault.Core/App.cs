#region Using

using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
using CodeVault.Core.ViewModels;

#endregion

namespace CodeVault.Core
{
    /// <summary>
    ///     Define the App type.
    /// </summary>
    public class App : MvxApplication
    {
        /// <summary>
        ///     Initializes this instance.
        /// </summary>
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //// Start the app with the First View Model.
//            RegisterAppStart<FirstViewModel>();
        }
    }
}