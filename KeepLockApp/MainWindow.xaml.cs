using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace KeepLockApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbServicio.Items.Clear();
            cbServicio.Items.Insert(0,"LDAP");
            cbServicio.Items.Insert(1,"FTP");
            cbServicio.Items.Insert(2,"Linux Machine");
            cbServicio.SelectedIndex = 0;
            dgOperacion.Items.Clear();
            dgOperacion.ItemsSource = operation;
        }
        private ObservableCollection<Operation> operation = new ObservableCollection<Operation>();
        private int contador = 0;
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            operation.Add(new Operation { Id=contador, Service= cbServicio.SelectedValue.ToString(), Usuario=txtUsuario.Text, Contrasenia=txtContrasenia.Text, IP=txtIP.Text });
            contador++;
            int i = 1;
        }

        class Operation {
            private int id;
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            private String service;
            public String Service   
            {
                get { return service; }
                set { service = value; }
            }
            private String usuario;
            public String Usuario
            {
                get { return usuario; }
                set { usuario = value; }
            }
            private String contrasenia;
            public String Contrasenia
            {
                get { return contrasenia; }
                set { contrasenia = value; }
            }
            private String ip;
            public String IP
            {
                get { return ip; }
                set { ip = value; }
            }
        }
    }
}
