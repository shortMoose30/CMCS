using System.Windows;

namespace ContractClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaim submitClaimPage = new SubmitClaim();
            submitClaimPage.Show();
           
            this.Close();
        }

        private void BtnViewClaims_Click(object sender, RoutedEventArgs e)
        {
            ViewClaims viewClaimsPage = new ViewClaims();
            viewClaimsPage.Show();
            this.Close();
        }

        private void BtnManageContracts_Click(object sender, RoutedEventArgs e)
        {
            ManageContracts manageContractsPage = new ManageContracts();
            manageContractsPage.Show();
            this.Close();
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings settingsPage = new Settings();
            settingsPage.Show();
            this.Close();
        }
    }
}
