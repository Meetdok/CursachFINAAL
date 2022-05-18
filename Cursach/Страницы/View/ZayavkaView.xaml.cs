using Cursach.Tools;
using Cursach.КОД.View;
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

namespace Cursach.Страницы.View
{
    /// <summary>
    /// Interaction logic for ZayavkaView.xaml
    /// </summary>
    public partial class ZayavkaView : Page
    {
        
        public ZayavkaView(DTO.User selectedUser, Данные.Employ selectedEmploy, Данные.Kind selectedKind)
        {
            InitializeComponent();
            DataContext = new ViewZayavkaVM(selectedUser, selectedEmploy);
        }
    }
}
