﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            switch (Common.CurrentRole)
            {
                case Common.RoleNhanVien:
                    break;
                case Common.RoleChiNhanh:
                    break;
                case Common.RoleCongTy:
                    btnAdd.IsEnabled = false;
                    btnEdit.IsEnabled = false;
                    btnRemove.IsEnabled = false;
                    btnSave.IsEnabled = false;
                    btnUndo.IsEnabled = false;
                    btnRedo.IsEnabled = false;
                    break;
                default:
                    break;
            }
            try
            {
                loadData(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void add()
        {
            AddKho.Singleton.dataGrid = dgContent;
            AddKho.Singleton.Hide();
            AddKho.Singleton.Show();
            Window.GetWindow(this).Closed += (o, ev) => { AddKho.Singleton.Close(); };
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
            try
            {
                page = new Paging(Common.connection, "Kho", "KhoId desc");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            int rs = 0;
            try
            {
                rs= khoTableAdapter.Update((QLVTDataSet.KhoDataTable)dgContent.ItemsSource);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rs;
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (update() > 0)
            {
                MessageBox.Show("Saved!");
                loadData(0);
            };
        }

        private void btnUndo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                undo();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnRedo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                redo();
            }
            catch (Exception ex)
            {

            }

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
                    MessageBox.Show("Page not found!");
                }
                else
                {
                    loadData(p);

                }
            }
            else
            {
                MessageBox.Show("Invalid number format!");
            }
        }

        private void linkPre_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex - 1;
            if (p < 0 || p > page.totalPage)
            {
                MessageBox.Show("Page not found!");
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
                MessageBox.Show("Page not found!");
            }
            else
            {
                loadData(p);

            }
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            page = new Paging(Common.connection, "Kho where KhoId = '" + txbSearch.Text + "'", "KhoId desc");
            QLVTDataSet.KhoDataTable khos = new QLVTDataSet.KhoDataTable();
            DataTable dataTable = page.getPage(0);
            if (dataTable != null)
            {
                khos.Merge(dataTable);
            }
            dgContent.ItemsSource = khos;
            tableLog = new DataTableLog((DataTable)khos);
            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

            if (dgContent.CurrentItem != null)
            {
                tableLog.SetRowChange(((DataRowView)dgContent.CurrentItem).Row);
                AddKho addKho = new AddKho(((DataRowView)dgContent.CurrentItem).Row);
                addKho.dataGrid = this.dgContent;
                addKho.Show();
            }
            else
            {
                MessageBox.Show("Không có hàng nào được chọn!");
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            if (dgContent.CurrentItem != null)
            {
                ((DataRowView)dgContent.CurrentItem).Delete();
            }
            else
            {
                MessageBox.Show("Không có hàng nào được chọn!");
            }
        }
    }
}
