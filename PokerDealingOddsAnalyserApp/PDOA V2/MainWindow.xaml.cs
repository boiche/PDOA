using System.Windows;
using TexasHoldEm;

namespace PDOA_V2
{
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TexasHoldEm.TexasHoldEmForm form = new TexasHoldEmForm();
            form.Focus();
            form.ShowDialog();            
        }
    }
}
