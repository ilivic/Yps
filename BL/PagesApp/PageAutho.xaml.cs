using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BL.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageAutho.xaml
    /// </summary>
    public partial class PageAutho : Page
    {
        public PageAutho()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageReg());
                }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClassApp.ClassDatT.GetUser();
            var checout = ClassApp.ClassDatT.ListUser.Where(z => z.Login == TxtLog.Text && z.Password == TxtPass.Password).FirstOrDefault();
            if (checout != null)
            {
                NavigationService.Navigate( new PageMain());
            }
            else
            {
                MessageBox.Show("нет такого пользователя");
            }
        }
    }
}
