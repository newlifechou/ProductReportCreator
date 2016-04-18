using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfReportCreator.Resource.ValidationRules
{
    public class RequiredRule:ValidationRule
    {
        /// <summary>
        /// 输入不能为空
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value as string;
            if (string.IsNullOrEmpty(input))
            {
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "This Value must be not empty");
            }
        }
    }
}
