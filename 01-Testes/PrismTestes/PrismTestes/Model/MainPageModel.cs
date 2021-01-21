using System;
using System.Collections.Generic;
using System.Text;

namespace PrismTestes.Model
{
    public class MainPageModel
    {
        
        

        public List<MainPage_MenuItem> MTD_ObterItensMenu()
        {
            List<MainPage_MenuItem> itens = new List<MainPage_MenuItem>();

            itens.Add(new MainPage_MenuItem()
            {
                PRP_Display = "Prism - Behaviors",
                PRP_Descricao = "Permite adicionar eventos aos elementos adicionados na pagina.",
                PRP_Icon = "",
            }) ;

            itens.Add(new MainPage_MenuItem()
            {
                PRP_Display = "Prism - Dialogs",
                PRP_Descricao = "Ainda não vi para que serve.",
                PRP_Icon = "",
            });

            return itens;

        }
    }
}
