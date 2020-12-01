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
    class MyMatrix
    {
        private int columns;
        private int rows;

        public MyMatrix()
        {
            this.columns = 5;
            this.rows = 5;
        }

        public int Columns
        {
            get
            {
                return columns;
            }
            set
            {
                if (value > 0 && value < 6)
                {
                    columns = value;
                }
            }
        }
        public int Rows
        {
            get
            {
                return rows;
            }
            set
            {
                if (value > 0 && value < 6)
                {
                    rows = value;
                }
            }
        }

        public void MatrixCheck(ref TextBox Box00, ref TextBox Box01, ref TextBox Box02, ref TextBox Box03, ref TextBox Box04, ref TextBox Box10, ref TextBox Box11, ref TextBox Box12, ref TextBox Box13, ref TextBox Box14, ref TextBox Box20, ref TextBox Box21, ref TextBox Box22, ref TextBox Box23, ref TextBox Box24, ref TextBox Box30, ref TextBox Box31, ref TextBox Box32, ref TextBox Box33, ref TextBox Box34, ref TextBox Box40, ref TextBox Box41, ref TextBox Box42, ref TextBox Box43, ref TextBox Box44)
        {
                Box00.IsEnabled = true;
                Box01.IsEnabled = true;
                Box02.IsEnabled = true;
                Box03.IsEnabled = true;
                Box04.IsEnabled = true;
                Box10.IsEnabled = true;
                Box11.IsEnabled = true;
                Box12.IsEnabled = true;
                Box13.IsEnabled = true;
                Box14.IsEnabled = true;
                Box20.IsEnabled = true;
                Box21.IsEnabled = true;
                Box22.IsEnabled = true;
                Box23.IsEnabled = true;
                Box24.IsEnabled = true;
                Box30.IsEnabled = true;
                Box31.IsEnabled = true;
                Box32.IsEnabled = true;
                Box33.IsEnabled = true;
                Box34.IsEnabled = true;
                Box40.IsEnabled = true;
                Box41.IsEnabled = true;
                Box42.IsEnabled = true;
                Box43.IsEnabled = true;
                Box44.IsEnabled = true;

            Box00.Visibility = Visibility.Visible;
            Box01.Visibility = Visibility.Visible;
            Box02.Visibility = Visibility.Visible;
            Box03.Visibility = Visibility.Visible;
            Box04.Visibility = Visibility.Visible;
            Box10.Visibility = Visibility.Visible;
            Box11.Visibility = Visibility.Visible;
            Box12.Visibility = Visibility.Visible;
            Box13.Visibility = Visibility.Visible;
            Box14.Visibility = Visibility.Visible;
            Box20.Visibility = Visibility.Visible;
            Box21.Visibility = Visibility.Visible;
            Box22.Visibility = Visibility.Visible;
            Box23.Visibility = Visibility.Visible;
            Box24.Visibility = Visibility.Visible;
            Box30.Visibility = Visibility.Visible;
            Box31.Visibility = Visibility.Visible;
            Box32.Visibility = Visibility.Visible;
            Box33.Visibility = Visibility.Visible;
            Box34.Visibility = Visibility.Visible;
            Box40.Visibility = Visibility.Visible;
            Box41.Visibility = Visibility.Visible;
            Box42.Visibility = Visibility.Visible;
            Box43.Visibility = Visibility.Visible;
            Box44.Visibility = Visibility.Visible;

            if (columns == 5) { }
            else if (columns == 4)
            {
                Box40.IsEnabled = false;
                Box41.IsEnabled = false;
                Box42.IsEnabled = false;
                Box43.IsEnabled = false;
                Box44.IsEnabled = false;
                Box40.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
                Box43.Visibility = Visibility.Collapsed;
                Box44.Visibility = Visibility.Collapsed;
            }
            else if(columns == 3)
            {
                Box40.IsEnabled = false;
                Box41.IsEnabled = false;
                Box42.IsEnabled = false;
                Box43.IsEnabled = false;
                Box44.IsEnabled = false;
                Box30.IsEnabled = false;
                Box31.IsEnabled = false;
                Box32.IsEnabled = false;
                Box33.IsEnabled = false;
                Box34.IsEnabled = false;
                Box40.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
                Box43.Visibility = Visibility.Collapsed;
                Box44.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box32.Visibility = Visibility.Collapsed;
                Box33.Visibility = Visibility.Collapsed;
                Box34.Visibility = Visibility.Collapsed;
                
            }
            else if(columns == 2)
            {
                Box40.IsEnabled = false;
                Box41.IsEnabled = false;
                Box42.IsEnabled = false;
                Box43.IsEnabled = false;
                Box44.IsEnabled = false;
                Box30.IsEnabled = false;
                Box31.IsEnabled = false;
                Box32.IsEnabled = false;
                Box33.IsEnabled = false;
                Box34.IsEnabled = false;
                Box20.IsEnabled = false;
                Box21.IsEnabled = false;
                Box22.IsEnabled = false;
                Box23.IsEnabled = false;
                Box24.IsEnabled = false;
                Box40.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
                Box43.Visibility = Visibility.Collapsed;
                Box44.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box32.Visibility = Visibility.Collapsed;
                Box33.Visibility = Visibility.Collapsed;
                Box34.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box21.Visibility = Visibility.Collapsed;
                Box22.Visibility = Visibility.Collapsed;
                Box23.Visibility = Visibility.Collapsed;
                Box24.Visibility = Visibility.Collapsed;
            }
            else if(columns == 1)
            {
                Box40.IsEnabled = false;
                Box41.IsEnabled = false;
                Box42.IsEnabled = false;
                Box43.IsEnabled = false;
                Box44.IsEnabled = false;
                Box30.IsEnabled = false;
                Box31.IsEnabled = false;
                Box32.IsEnabled = false;
                Box33.IsEnabled = false;
                Box34.IsEnabled = false;
                Box20.IsEnabled = false;
                Box21.IsEnabled = false;
                Box22.IsEnabled = false;
                Box23.IsEnabled = false;
                Box24.IsEnabled = false;
                Box10.IsEnabled = false;
                Box11.IsEnabled = false;
                Box12.IsEnabled = false;
                Box13.IsEnabled = false;
                Box14.IsEnabled = false;
                Box40.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
                Box43.Visibility = Visibility.Collapsed;
                Box44.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box32.Visibility = Visibility.Collapsed;
                Box33.Visibility = Visibility.Collapsed;
                Box34.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box21.Visibility = Visibility.Collapsed;
                Box22.Visibility = Visibility.Collapsed;
                Box23.Visibility = Visibility.Collapsed;
                Box24.Visibility = Visibility.Collapsed;
                Box10.Visibility = Visibility.Collapsed;
                Box11.Visibility = Visibility.Collapsed;
                Box12.Visibility = Visibility.Collapsed;
                Box13.Visibility = Visibility.Collapsed;
                Box14.Visibility = Visibility.Collapsed;
            }
            else if(columns == 0)
            {
                Box40.IsEnabled = false;
                Box41.IsEnabled = false;
                Box42.IsEnabled = false;
                Box43.IsEnabled = false;
                Box44.IsEnabled = false;
                Box30.IsEnabled = false;
                Box31.IsEnabled = false;
                Box32.IsEnabled = false;
                Box33.IsEnabled = false;
                Box34.IsEnabled = false;
                Box20.IsEnabled = false;
                Box21.IsEnabled = false;
                Box22.IsEnabled = false;
                Box23.IsEnabled = false;
                Box24.IsEnabled = false;
                Box10.IsEnabled = false;
                Box11.IsEnabled = false;
                Box12.IsEnabled = false;
                Box13.IsEnabled = false;
                Box14.IsEnabled = false;
                Box00.IsEnabled = false;
                Box01.IsEnabled = false;
                Box02.IsEnabled = false;
                Box03.IsEnabled = false;
                Box04.IsEnabled = false;
                Box40.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
                Box43.Visibility = Visibility.Collapsed;
                Box44.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box32.Visibility = Visibility.Collapsed;
                Box33.Visibility = Visibility.Collapsed;
                Box34.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box21.Visibility = Visibility.Collapsed;
                Box22.Visibility = Visibility.Collapsed;
                Box23.Visibility = Visibility.Collapsed;
                Box24.Visibility = Visibility.Collapsed;
                Box10.Visibility = Visibility.Collapsed;
                Box11.Visibility = Visibility.Collapsed;
                Box12.Visibility = Visibility.Collapsed;
                Box13.Visibility = Visibility.Collapsed;
                Box14.Visibility = Visibility.Collapsed;
                Box00.Visibility = Visibility.Collapsed;
                Box01.Visibility = Visibility.Collapsed;
                Box02.Visibility = Visibility.Collapsed;
                Box03.Visibility = Visibility.Collapsed;
                Box04.Visibility = Visibility.Collapsed;
            }

            if (rows == 5) { }
            else if (rows == 4)
            {
                Box00.IsEnabled = false;
                Box10.IsEnabled = false;
                Box20.IsEnabled = false;
                Box30.IsEnabled = false;
                Box40.IsEnabled = false;
                Box00.Visibility = Visibility.Collapsed;
                Box10.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box40.Visibility = Visibility.Collapsed;
            }
            else if (rows == 3)
            {
                Box00.IsEnabled = false;
                Box10.IsEnabled = false;
                Box20.IsEnabled = false;
                Box30.IsEnabled = false;
                Box40.IsEnabled = false;
                Box01.IsEnabled = false;
                Box11.IsEnabled = false;
                Box21.IsEnabled = false;
                Box31.IsEnabled = false;
                Box41.IsEnabled = false;
                Box00.Visibility = Visibility.Collapsed;
                Box10.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box40.Visibility = Visibility.Collapsed;
                Box01.Visibility = Visibility.Collapsed;
                Box11.Visibility = Visibility.Collapsed;
                Box21.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
            }
            else if (rows == 2)
            {
                Box00.IsEnabled = false;
                Box10.IsEnabled = false;
                Box20.IsEnabled = false;
                Box30.IsEnabled = false;
                Box40.IsEnabled = false;
                Box01.IsEnabled = false;
                Box11.IsEnabled = false;
                Box21.IsEnabled = false;
                Box31.IsEnabled = false;
                Box41.IsEnabled = false;
                Box02.IsEnabled = false;
                Box12.IsEnabled = false;
                Box22.IsEnabled = false;
                Box32.IsEnabled = false;
                Box42.IsEnabled = false;
                Box00.Visibility = Visibility.Collapsed;
                Box10.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box40.Visibility = Visibility.Collapsed;
                Box01.Visibility = Visibility.Collapsed;
                Box11.Visibility = Visibility.Collapsed;
                Box21.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box02.Visibility = Visibility.Collapsed;
                Box12.Visibility = Visibility.Collapsed;
                Box22.Visibility = Visibility.Collapsed;
                Box32.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
            }
            else if (rows == 1)
            {
                Box00.IsEnabled = false;
                Box10.IsEnabled = false;
                Box20.IsEnabled = false;
                Box30.IsEnabled = false;
                Box40.IsEnabled = false;
                Box01.IsEnabled = false;
                Box11.IsEnabled = false;
                Box21.IsEnabled = false;
                Box31.IsEnabled = false;
                Box41.IsEnabled = false;
                Box02.IsEnabled = false;
                Box12.IsEnabled = false;
                Box22.IsEnabled = false;
                Box32.IsEnabled = false;
                Box42.IsEnabled = false;
                Box03.IsEnabled = false;
                Box13.IsEnabled = false;
                Box23.IsEnabled = false;
                Box33.IsEnabled = false;
                Box43.IsEnabled = false;
                Box00.Visibility = Visibility.Collapsed;
                Box10.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box40.Visibility = Visibility.Collapsed;
                Box01.Visibility = Visibility.Collapsed;
                Box11.Visibility = Visibility.Collapsed;
                Box21.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box02.Visibility = Visibility.Collapsed;
                Box12.Visibility = Visibility.Collapsed;
                Box22.Visibility = Visibility.Collapsed;
                Box32.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
                Box03.Visibility = Visibility.Collapsed;
                Box13.Visibility = Visibility.Collapsed;
                Box23.Visibility = Visibility.Collapsed;
                Box33.Visibility = Visibility.Collapsed;
                Box43.Visibility = Visibility.Collapsed;
            }
            else if (rows == 1)
            {
                Box00.IsEnabled = false;
                Box10.IsEnabled = false;
                Box20.IsEnabled = false;
                Box30.IsEnabled = false;
                Box40.IsEnabled = false;
                Box01.IsEnabled = false;
                Box11.IsEnabled = false;
                Box21.IsEnabled = false;
                Box31.IsEnabled = false;
                Box41.IsEnabled = false;
                Box02.IsEnabled = false;
                Box12.IsEnabled = false;
                Box22.IsEnabled = false;
                Box32.IsEnabled = false;
                Box42.IsEnabled = false;
                Box03.IsEnabled = false;
                Box13.IsEnabled = false;
                Box23.IsEnabled = false;
                Box33.IsEnabled = false;
                Box43.IsEnabled = false;
                Box04.IsEnabled = false;
                Box14.IsEnabled = false;
                Box24.IsEnabled = false;
                Box34.IsEnabled = false;
                Box44.IsEnabled = false;
                Box40.Visibility = Visibility.Collapsed;
                Box41.Visibility = Visibility.Collapsed;
                Box42.Visibility = Visibility.Collapsed;
                Box43.Visibility = Visibility.Collapsed;
                Box44.Visibility = Visibility.Collapsed;
                Box30.Visibility = Visibility.Collapsed;
                Box31.Visibility = Visibility.Collapsed;
                Box32.Visibility = Visibility.Collapsed;
                Box33.Visibility = Visibility.Collapsed;
                Box34.Visibility = Visibility.Collapsed;
                Box20.Visibility = Visibility.Collapsed;
                Box21.Visibility = Visibility.Collapsed;
                Box22.Visibility = Visibility.Collapsed;
                Box23.Visibility = Visibility.Collapsed;
                Box24.Visibility = Visibility.Collapsed;
                Box10.Visibility = Visibility.Collapsed;
                Box11.Visibility = Visibility.Collapsed;
                Box12.Visibility = Visibility.Collapsed;
                Box13.Visibility = Visibility.Collapsed;
                Box14.Visibility = Visibility.Collapsed;
                Box00.Visibility = Visibility.Collapsed;
                Box01.Visibility = Visibility.Collapsed;
                Box02.Visibility = Visibility.Collapsed;
                Box03.Visibility = Visibility.Collapsed;
                Box04.Visibility = Visibility.Collapsed;
            }
        }


    }
}
