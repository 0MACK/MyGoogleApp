namespace MyGoogleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Replace this with your actual data source
            var newsItems = new List<NewsItem>
        {
            new NewsItem { ImageSource = "https://www.aljazeera.com/wp-content/uploads/2022/12/2016-02-11T120000Z_1330925033_GF10000304856_RTRMADP_3_SAFRICA-ZUMA.jpg?resize=770%2C513&quality=80", Heading = "ANC Suspends Former president Jacob Zuma" },
            new NewsItem { ImageSource = "https://www.elections.org.za/pw/images/amendment_banner.jpg", Heading = "Youth Encouraged to register for upcoming 2024 elections" },
            new NewsItem { ImageSource = "https://www.enca.com/sites/default/files/styles/card/public/2023-12/348J8WN-highres.jpeg.webp?itok=cWRdo4n4https://www.elections.org.za/pw/images/amendment_banner.jpg", Heading = "ISRAEL-PALESTINE CONFLICT | DEATH TOLL IN GAZA PASSES 27,000" },
            new NewsItem { ImageSource = "https://cf-images.eu-west-1.prod.boltdns.net/v1/jit/6091058939001/e64534c8-ca29-47bf-8dc9-65e1494dd106/main/4000x2250/8s85ms/match/image.jpgg", Heading = "JOHANNESBURG - A blaze has gutted a shopping complex In Springfield, Durban overnight.\r\n\r\nWhile the cause is yet to be determined, firefighters have managed to contain the blaze at the China Mall." },
            // Add more items as needed
        };

            NewsCollectionView.ItemsSource = newsItems;
        }

        // Add a class to represent your news item
        public class NewsItem
        {
            public string ImageSource { get; set; }

            public string Heading { get; set; }
        }

    }
}
