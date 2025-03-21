using System.Diagnostics.Tracing;

namespace APPSistemaVet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void OnLoginClicked(object sender, EventArgs e)
        {
            char Entry = etrLogin.Text;

            if (etrLogin == "ERROR")
                LoginBtn.Text = $"Clicked {entry} in software";
            else
             LoginBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(LoginBtn.Text);
        }
    }
}
