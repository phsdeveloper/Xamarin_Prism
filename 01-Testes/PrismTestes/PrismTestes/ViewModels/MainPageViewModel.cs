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

        public DelegateCommand<Model.MainPage_MenuItem> SelecionarMenuItemCommand { get; set; }


        private void MTD_RedirecionarPagina(Model.MainPage_MenuItem pMenuItem)
        {
            foreach (var item in PRP_ItensMenu)
            {
                item.PRP_Descricao.Replace("Chamou", "");
                item.PRP_BackGroundColor = item.PRP_CoresMenu.PRP_UnSelectedBackGroundColor;
                item.PRP_FontColor = item.PRP_CoresMenu.PRP_UnSelectedFontColor;
            }
            var dados = pMenuItem;
            pMenuItem.PRP_BackGroundColor = pMenuItem.PRP_CoresMenu.PRP_SelectedBackGroundColor;
            pMenuItem.PRP_FontColor = pMenuItem.PRP_CoresMenu.PRP_SelectedFontColor;
            pMenuItem.PRP_Descricao += "Chamou";

        }
    }
}
