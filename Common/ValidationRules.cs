using System;
using System.Data;
using System.Globalization;
using System.Windows.Controls;

namespace WpfApp2
{
    class ReqireValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
                return new ValidationResult(false, "Vui lòng nhập một giá trị.");
            else
            {
                if (value.ToString().Trim().Length == 0)
                    return new ValidationResult(false, "Vui lòng nhập một giá trị.");
            }
            return ValidationResult.ValidResult;
        }
    }
    class AgeValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null||!(value is DateTime))
            {
                return new ValidationResult(false, "Vui lòng nhập một giá trị.");
            }
            DateTime b = (DateTime)value;
            if (((DateTime.Now.Year -b.Year)*12+ DateTime.Now.Month - b.Month) / 12 < 18)
            {
                return new ValidationResult(false, "Ngày sinh không hợp lệ(tuổi nhỏ hơn 18).");
            }
            return ValidationResult.ValidResult;
        }
    }
    class DataTableLengthValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            if (value == null ||!(value is DataTable) || ((DataTable)value).Rows.Count<=0)
            {
                return new ValidationResult(false, "Vui lòng nhập một giá trị.");
            }

            return ValidationResult.ValidResult;
        }
    }

}
