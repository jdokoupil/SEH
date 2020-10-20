using SEH.API;
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
using Google.Apis;

namespace SEH
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Page
    {
        public SearchResultsPage()
        {
            InitializeComponent();
            search("dog");
        }

        public void search( string search )
        {
            

            ImageProcessor processor = new ImageProcessor();
            var res = processor.LoadImage(search);
            MessageBox.Show(((ResultModel)res).Src);

            
        }
    }
}
