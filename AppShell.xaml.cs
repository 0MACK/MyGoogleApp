using MyGoogleApp.Veiws;

namespace MyGoogleApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        void RegisterRoutes() 
        {

            Routing.RegisterRoute("Discover", typeof(MainPage));
            Routing.RegisterRoute("Search", typeof(Search));
            Routing.RegisterRoute("Saved", typeof(Saved));
            
        
        }



    }
}
