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

namespace EditableMatrix
{

    public partial class MainWindow : Window
    {
        MyMatrix matrix;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlusColumn_Click(object sender, RoutedEventArgs e)
        {
            int temp = matrix.Columns;
            temp++;
            matrix.Columns = temp;


            matrix.MatrixCheck(ref  Box00, ref  Box01, ref  Box02, ref  Box03, ref  Box04, ref  Box10, ref  Box11, ref  Box12, ref  Box13, ref  Box14, ref  Box20, ref  Box21, ref  Box22, ref  Box23, ref  Box24, ref  Box30, ref  Box31, ref  Box32, ref  Box33, ref  Box34, ref  Box40, ref  Box41, ref  Box42, ref  Box43, ref  Box44);
        }

        private void StartClick(object sender, RoutedEventArgs e)
        {
            matrix = new MyMatrix();
            PlusColumnButton.IsEnabled = true;
            MinusColumnButton.IsEnabled = true;
            PlusRowButton.IsEnabled = true;
            MinusRowButton.IsEnabled = true;
            Start.IsEnabled = false;
        }

        private void MinusColumn_Click(object sender, RoutedEventArgs e)
        {
            int temp = matrix.Columns;
            temp--;
            matrix.Columns = temp;


            matrix.MatrixCheck(ref Box00, ref Box01, ref Box02, ref Box03, ref Box04, ref Box10, ref Box11, ref Box12, ref Box13, ref Box14, ref Box20, ref Box21, ref Box22, ref Box23, ref Box24, ref Box30, ref Box31, ref Box32, ref Box33, ref Box34, ref Box40, ref Box41, ref Box42, ref Box43, ref Box44);       
        }

        private void PlusRow_Click(object sender, RoutedEventArgs e)
        {
            int temp = matrix.Rows;
            temp++;
            matrix.Rows = temp;


            matrix.MatrixCheck(ref Box00, ref Box01, ref Box02, ref Box03, ref Box04, ref Box10, ref Box11, ref Box12, ref Box13, ref Box14, ref Box20, ref Box21, ref Box22, ref Box23, ref Box24, ref Box30, ref Box31, ref Box32, ref Box33, ref Box34, ref Box40, ref Box41, ref Box42, ref Box43, ref Box44);
        }

        private void MinusRow_Click(object sender, RoutedEventArgs e)
        {
            int temp = matrix.Rows;
            temp--;
            matrix.Rows = temp;


            matrix.MatrixCheck(ref Box00, ref Box01, ref Box02, ref Box03, ref Box04, ref Box10, ref Box11, ref Box12, ref Box13, ref Box14, ref Box20, ref Box21, ref Box22, ref Box23, ref Box24, ref Box30, ref Box31, ref Box32, ref Box33, ref Box34, ref Box40, ref Box41, ref Box42, ref Box43, ref Box44);
        }
    }
}
