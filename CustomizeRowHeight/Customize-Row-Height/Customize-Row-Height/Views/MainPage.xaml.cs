using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfListViewSample
{
    public partial class MainPage : ContentPage
    {

        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            listView.QueryItemSize += ListView_QueryItemSize;
        }

        private void ListView_QueryItemSize(object sender, QueryItemSizeEventArgs e)
        {
            if (e.ItemIndex % 2 == 0)
                e.ItemSize = 50;
            else
                e.ItemSize = 100;
            e.Handled = true;
        }
        #endregion

    }
    
}
