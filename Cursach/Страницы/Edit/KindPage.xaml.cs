using Cursach.КОД.Edit;
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

namespace Cursach.Страницы.Edit
{
    /// <summary>
    /// Interaction logic for KindPage.xaml
    /// </summary>
    public partial class KindPage : Page
    {
        public KindPage(KindVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
