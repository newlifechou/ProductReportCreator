using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfReportCreator.Resource.ValidationRules
{
    /// <summary>
    /// 输入长度不能超过
    /// </summary>
    public class MaxLengthRule:ValidationRule
    {
        private int length;
        /// <summary>
        /// 设定输入的长度
        /// </summary>
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public MaxLengthRule()
        {
            Length = 20;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value.ToString();
            if (input.Length>Length)
            {
                return new ValidationResult(false, "Must Less than " + Length);
            }
            return new ValidationResult(true, null);

        }
    }
}
