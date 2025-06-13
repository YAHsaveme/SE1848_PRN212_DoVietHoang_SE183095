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
using System.Windows.Shapes;

namespace HelloWpfApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDangNhap__Click(object sender, RoutedEventArgs e)
        {
            //giả lập account là:
            //username obama, password 123
            if(txtUserName.Text=="obama" && txtPassword.Password=="123")
            {
                MainWindow mw=new MainWindow();
                mw.Show();
                //đóng cửa sổ đăng nhập:
                Close();
                //hoặc gọi:
                //btnThoat.RaiseEvent(e);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại rồi Thím!");
            }
        }
    }
}
