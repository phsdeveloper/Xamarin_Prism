using System;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismTestes
{
    public partial class App : PrismApplication
    {
        public App():base(null){ }
        public App(IPlatformInitializer initializer) : base(initializer) { }


        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Views.MainPage,ViewModels.MainPageViewModel>();
        }

        protected override void OnStart()
        {
        }
        
        protected override void OnSleep()
        {
        }
        
        protected override void OnResume()
        {
        }
    }
}
//treterte