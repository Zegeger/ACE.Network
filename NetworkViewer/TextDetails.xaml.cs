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

namespace ACE.Network.Tools
{
    /// <summary>
    /// Interaction logic for TextDetails.xaml
    /// </summary>
    public partial class TextDetails : Window
    {
        public TextDetails(string title, string text)
        {
            InitializeComponent();
            Title = title;
            Details.Text = text;
        }
    }
}
