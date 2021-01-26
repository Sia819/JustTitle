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

namespace WindowTitleControl
{
    /// <summary>
    /// CostomTitle.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CostomTitle : UserControl
    {
        public CostomTitle()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources.Add("myBrush", new SolidColorBrush(Color.FromRgb(255, 0, 0)));
        }
    }
}
