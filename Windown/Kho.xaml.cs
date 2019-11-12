using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Kho.xaml
    /// </summary>
    public partial class KhoControl : UserControl, UpdateDataWindow
    {
        Paging page;
        DataTableLog tableLog;
        static private KhoControl signleton;
        static public KhoControl Singleton => signleton;
        static KhoControl()
        {
            if (signleton == null)
                signleton = new KhoControl();
        }
        private KhoControl()
        {
            InitializeComponent();
        }

        public void add()
        {
            //Kho.Singleton.dataGrid = dgContent;
            //Kho.Singleton.Hide();
            //AddNhanVienWindow.Singleton.Show();
            //Window.GetWindow(this).Closed += (o, ev) => { AddNhanVienWindow.Singleton.Close(); };
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void edit()
        {
            throw new NotImplementedException();
        }

        public void loadData(int p)
        {
            page = new Paging(Common.connection, 10, "Kho", "KhoId desc");
            QLVTDataSet.KhoDataTable khos = new QLVTDataSet.KhoDataTable();


            DataTable dataTable = page.getPage(p);
            if (dataTable != null)
            {
                khos.Merge(dataTable);
            }
            dgContent.ItemsSource = khos;
            tableLog = new DataTableLog((DataTable)khos);

            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        public void redo()
        {
            tableLog.Redo();
        }

        public void undo()
        {
            tableLog.Undo();
        }

        public int update()
        {
            QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter = Common.KhoTableAdapter;
            khoTableAdapter.Connection = Common.connection;
            return khoTableAdapter.Update((QLVTDataSet.KhoDataTable)dgContent.ItemsSource);
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (update() > 0)
            {
                Common.ShowMessage("Saved!");
            };
        }

        private void btnUndo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            undo();
        }

        private void btnRedo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            redo();
        }

        private void btnRefresh_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            loadData(0);
        }

        private void linkGo_Click(object sender, RoutedEventArgs e)
        {
            int p;
            if (Int32.TryParse(tbxPage.Text, out p))
            {
                p--;
                if (p < 0 || p > page.totalPage)
                {
                    Common.ShowMessage("Page not found!");
                }
                else
                {
                    loadData(p);

                }
            }
            else
            {
                Common.ShowMessage("Invalid number format!");
            }
        }

        private void linkPre_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex - 1;
            if (p < 0 || p > page.totalPage)
            {
                Common.ShowMessage("Page not found!");
            }
            else
            {
                loadData(p);

            }

        }

        private void linkNext_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex + 1;
            if (p < 0 || p > page.totalPage)
            {
                Common.ShowMessage("Page not found!");
            }
            else
            {
                loadData(p);

            }
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txbSearch.Text.Length > 0)
            {
                QLVTDataSet.KhoDataTable khos = new QLVTDataSet.KhoDataTable();
                try
                {
                    DataTable table = ((QLVTDataSet.KhoDataTable)dgContent.ItemsSource).Select("KhoId=" + txbSearch.Text).CopyToDataTable();
                    khos.Merge(table);
                    dgContent.ItemsSource = khos;
                }
                catch (Exception ex)
                {
                    Common.ShowMessage("Result not found!");

                }

            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //(new AddNhanVienWindow(((DataRowView)dgContent.CurrentItem).Row)).Show();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            dgContent.Items.Remove(dgContent.CurrentItem);
            //DataRowView dataRowView = (DataRowView)dgContent.CurrentItem;
            //dataRowView.Row["TrangThai"] = 1;
            //QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter = new QLVTDataSetTableAdapters.KhoTableAdapter();
            //khoTableAdapter.Connection = Common.connection;
            //khoTableAdapter.Update(dataRowView.Row);
            //loadData(page.currentIndex);
        }
    }
}
