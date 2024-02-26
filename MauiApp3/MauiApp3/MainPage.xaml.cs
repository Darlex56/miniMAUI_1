using CommunityToolkit.Maui.Views;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void onPlayClicked(object sender, EventArgs e) { 
            mediaPlayer.Play();
        }
        public void onPauseClicked(object sender, EventArgs e)
        {
            mediaPlayer.Pause();
        }
    }

}
