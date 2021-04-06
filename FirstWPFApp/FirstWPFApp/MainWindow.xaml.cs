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

namespace FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; private set; }
        public string[] text = new string[4]{"lalala", "tralala", "okokokok", "hmhmhmhm" };
        InkEditingModes editingModes = new InkEditingModes();
        public MainWindow()
        {
            InitializeComponent();

           // this.DataContext = editingModes;

            Counter = 0;
        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            // onEvent.Content = Counter++;
            Random r = new Random();
            int a = r.Next(0, 4);
            MessageBox.Show(text[a]);
        }

        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Select;
            // editingModes.EditingMode = InkCanvasEditingMode.Select;
        }

        private void Drawing_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.Resources["editingModes"] as InkEditingModes).EditingMode = InkCanvasEditingMode.Ink;
         //   editingModes.EditingMode = InkCanvasEditingMode.Ink;
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            secondary.Content = "Clicked";
        }*/

        /*private void Change_Click(object sender, RoutedEventArgs e)
        {
            text_block.Text = "Changed text";
        }*/
    }
}
