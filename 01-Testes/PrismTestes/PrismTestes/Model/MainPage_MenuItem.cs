using System;
using System.Collections.Generic;
using System.Text;

namespace PrismTestes.Model
{
    public class MainPage_MenuItem
    {
        public MainPage_MenuItem()
        {
            PRP_CoresMenu = new MenuCores();
            PRP_BackGroundColor = PRP_CoresMenu.PRP_UnSelectedBackGroundColor;
            PRP_FontColor = PRP_CoresMenu.PRP_UnSelectedFontColor;
            PRP_BorderColor = PRP_CoresMenu.PRP_BorderColor;
        }

        public string PRP_Display { get; set; }
        public string PRP_Descricao { get; set; }
        public string PRP_Icon { get; set; }
        public string PRP_BackGroundColor { get; set; }
        public string PRP_FontColor { get; set; }
        public Enum.PaginasAplicacao PRP_Pagina { get; set; }
        public string PRP_BorderColor { get; set; }
        public MenuCores PRP_CoresMenu { get; set; }
    }

    public class MenuCores
    {
        public string PRP_SelectedBackGroundColor { get => "#080808"; }
        public string PRP_SelectedFontColor { get => "#FFFFFF"; }
        public string PRP_UnSelectedBackGroundColor { get => "#2d2d2d"; }
        public string PRP_UnSelectedFontColor { get => "#9D9D9D"; }
        public string PRP_BorderColor { get=> "#080808"; }
    }
}
