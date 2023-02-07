using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Testowe_Winforms_Devexpress.Contexts;

namespace Testowe_Winforms_Devexpress
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainWindow()
        {
            InitializeComponent();
            //if (!mvvmContext1.IsDesignMode)
            //    InitializeBindings();

            StorageDbContext context = new StorageDbContext();

        }

        //private void InitializeBindings()
        //{
        //    var fleunt = mvvmContext1.OfType<MainViewModel>();
        //}
    }
}
