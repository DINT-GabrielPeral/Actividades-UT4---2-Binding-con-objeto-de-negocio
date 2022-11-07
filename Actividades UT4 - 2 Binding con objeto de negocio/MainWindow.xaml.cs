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

namespace Actividades_UT4___2_Binding_con_objeto_de_negocio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nSuperheroe=0;
        List<Superheroe> superheroes = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();

            
            Padre_DockPanel.DataContext = superheroes[nSuperheroe];
        }

        private void Arrow_Click(object sender, MouseButtonEventArgs e)
        {
            Image imagen = (Image)sender;
            if(nSuperheroe<2&&imagen.Tag.ToString()=="derecha")
            {
                nSuperheroe++;
                
            }else if(nSuperheroe > 0 && imagen.Tag.ToString() == "izquierda")
            {
                nSuperheroe--;  
            }
            Padre_DockPanel.DataContext = superheroes[nSuperheroe];
            textBlockNumero.Text = ((nSuperheroe+1) + "/3");
        }
    }
}
