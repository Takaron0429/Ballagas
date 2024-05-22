using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Ballagasprojekt2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public MySqlConnection connection()
        {
            try
            {
                string server = "localhost";
                string database = "ugyfel";
                string user = "root";
                string password = "";
                string code = $"server={server}; database={database}; uid={user}; pw={password}";
                MySqlConnection msc = new MySqlConnection(code);

                msc.Open();
                return msc;
            }
            catch (Exception hiba)
            {
                MessageBox.Show(hiba.Message);
                return null;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rögzites page = new rögzites();
            page.ShowDialog();
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MySqlConnection conn = connection();
                conn.Open();

                string code = $"DELETE FROM `megrendelés`";

                MySqlCommand cmd = new MySqlCommand(code);
                cmd.Connection = conn;

                conn.Close();
            }
            catch (Exception hiba)
            {
                MessageBox.Show(hiba.Message);
            }
            


        }
    }
}
