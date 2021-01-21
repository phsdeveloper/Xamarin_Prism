using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismTestes.ViewModels
{
    public abstract class BaseViewModel : BindableBase, INavigationAware, IDestructible
    {
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            Title = "Default";
        }


        #region A T R I B U T O S
       
        protected INavigationService NavigationService { get; }
        private string _title;

        #endregion A T R I B U T O S

        #region P R O P R I E D A D E S

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion P R O P R I E D A D E S




        public virtual void Destroy()
        {
            throw new NotImplementedException("Esse método precisa ser sobrecrever (override)");
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException("Esse método precisa ser sobrecrever (override)");
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException("Esse método precisa ser sobrecrever (override)");
        }



    }
}
