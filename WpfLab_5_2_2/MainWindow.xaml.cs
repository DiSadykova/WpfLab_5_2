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
using System.IO;
using Microsoft.Win32;
using System.Drawing;

namespace WpfLab_5_2_2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color=Colors.Red;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Orange;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Magenta;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        //private void Button_Click_10(object sender, RoutedEventArgs e)
        //{
        //    inkCanvas.DefaultDrawingAttributes.Color = ;
        //}

        //private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        // {
        //     SaveFileDialog saveFileDialog = new SaveFileDialog();
        //     if (saveFileDialog.ShowDialog() == true)
        //     {
        //        File. (saveFileDialog.FileName, inkCanvas.Strokes);
        //     }
        // }
    }
}
