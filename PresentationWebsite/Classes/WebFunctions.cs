using BlazorBootstrap;


namespace PresentationWebsite.Classes
{
    public class WebFunctions
    {
        public static async Task<Sidebar2DataProviderResult> GetMenu(Sidebar2DataProviderRequest request)
        {
            //if (nitems is null)
            //    nitems = WebFunctions.GetNavItems();

            //await Task.Delay(1000);

            return await Task.FromResult(request.ApplyTo(GetNavItems()));
        }
        public static IEnumerable<NavItem> GetNavItems()
        {
            return
            [
                new NavItem { Id = "1", Href = "/", IconName = IconName.House, Text = "Home" },
                new NavItem { Id = "2", Href = "/dailychart", IconName = IconName.CloudSun, Text = "Daily" },
            ];
        }
    }
}