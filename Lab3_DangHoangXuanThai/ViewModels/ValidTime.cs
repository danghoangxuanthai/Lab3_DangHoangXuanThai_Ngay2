using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_DangHoangXuanThai.ViewModels
{
    public class ValidTime : ValidationAtttribute
    {
        public override bool IsVailid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyle.None,
                out dateTime)
        }
    }
}