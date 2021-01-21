using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PrismTestes.ViewModels
{
    public class MainPageViewModel :BaseViewModel
    {
        public MainPageViewModel(Prism.Navigation.INavigationService navigation):base(navigation)
        {
            PRP_ItensMenu = new ObservableCollection<Model.MainPage_MenuItem>(new Model.MainPageModel().MTD_ObterItensMenu());
            //new Model.MainPageModel().MTD_ObterItensMenu().ForEach(x => PRP_ItensMenu.Add(x));
            Title = "Testes Prism";
            SelecionarMenuItemCommand = new DelegateCommand<Model.MainPage_MenuItem>(MTD_RedirecionarPagina);
        }

        #region A T R I B U T O S
        public ObservableCollection<Model.MainPage_MenuItem> PRP_ItensMenu { get; set; }
        #endregion A T R I B U T O S

        DelegateCommand<Model.MainPage_MenuItem> SelecionarMenuItemCommand { get; set; }


        private void MTD_RedirecionarPagina(Model.MainPage_MenuItem ItemMenu)
        {
            var dados = ItemMenu;
        }
    }
}
