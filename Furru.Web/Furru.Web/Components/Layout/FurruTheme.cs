using MudBlazor;

namespace Furru.Web.Components.Layout
{
    public class FurruTheme : MudTheme
    {
        public FurruTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#1D1A1A",
                Secondary = "#FF8800",
                Background = "#F5F5F5",
                AppbarBackground = "#4CAF50",
                DrawerBackground = "#FFFFFF",
                TextPrimary = "#212121",
                TextSecondary = "#757575"
            };
            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontFamily = ["Poppins", "Helvetica", "Arial", "sans-serif"],
                    FontSize = "16px",
                    FontWeight = "400",
                    LineHeight = "1.5"
                }
            };
        }
    }
}
