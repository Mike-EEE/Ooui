using Ooui;

namespace Native.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            UI.Publish("/button", ButtonSample.Default.Get);

            LoadApplication(new Native.App());
        }
    }
}
