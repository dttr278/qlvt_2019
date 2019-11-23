using System;
using System.Data;
using System.Globalization;
using System.Windows.Data;

namespace WpfApp2
{
    class PhaiConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return "Nam";
            }
            else
            {
                return "Nu";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == "Nam")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class ChiNhanhConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            QLVTDataSet.V_CNDataTable cn = (QLVTDataSet.V_CNDataTable)Common.ChiNhanhInfo;
            DataRow[] rows = cn.Select("ChiNhanhId =" + (int)value);

            return rows[0]["Ten"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class DanhMucVTConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            DataRow[] rows = Common.LoaiHangDataTable.Select("LoaiHangId =" + value);

            return rows[0]["Ten"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class NhanVienConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            DataRow[] rows = Common.NhanVienDataTable.Select("NhanVienId =" + value);

            return rows[0]["Ho"] + " " + rows[0]["Ten"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class NhaCuungCapConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            DataRow[] rows = Common.NhaCungCapDataTable.Select("NhaCungCapId =" + value);

            return rows[0]["Ten"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }
    class MatHangConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DataRow[] rows = Common.MatHangDataTable.Select("MatHangId =" + value);
            return rows[0]["Ten"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class MonneyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string v = String.Format("{0:0,0}", value);
                return v;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string v = value.ToString();
            v = v.Replace(",", "");
            return int.Parse(v);
        }
    }
    class KhachHangConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DataRow[] rows = Common.KhachHangDataTable.Select("KhachHangId =" + value);
            return rows[0]["Ten"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class KhoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DataRow[] rows = Common.KhoDataTable.Select("KhoId =" + value);
            return rows[0]["Ten"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime d = (DateTime)value;
            return d.ToString("dd/MM/yyyy hh:mm");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
