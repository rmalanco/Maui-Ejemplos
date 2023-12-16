namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new Views.Pages.FlyoutSample.FlyoutSamplePage();
            //MainPage = new Views.Pages.TabbedSample.TabbedPageSample();
            //MainPage = new Views.Pages.StackLayoutSample.StackLayoutPageSample();
            //MainPage = new Views.Pages.StackLayoutSample.StackLayoutPageChallenge();
            //MainPage = new Views.Pages.AbsoluteLayoutSample.AbsoluteLayoutPageSample();
            //MainPage = new Views.Pages.GridSample.GridPageSample();
            MainPage = new Views.Pages.GridSample.GridPageChallenge();
            //MainPage = new Views.Pages.GridSample.ChallengeExtra();
            //MainPage = new Views.Pages.FlexLayoutSample.FlexLayoutPageSample();
            //MainPage = new Views.Pages.FlexLayoutSample.FlexLayoutChallenge();
            //MainPage = new Views.Pages.FlexLayoutSample.ChallengeExtra2();

        }
    }
}