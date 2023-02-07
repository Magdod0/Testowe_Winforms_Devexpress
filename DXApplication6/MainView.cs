using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication6
{
    public partial class MainView : DevExpress.XtraBars.TabForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            MainView form = new MainView();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
            fluent.BindCommand(tabFormControl1.AddPageButton, x => x.Show());
        }
    }
}
