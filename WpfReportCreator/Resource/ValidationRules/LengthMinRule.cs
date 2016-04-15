using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfReportCreator.Resource.ValidationRules
{
    public class LengthMinRule : ValidationRule
    {
        private int length;
        /// <summary>
        /// 设定输入的长度
        /// </summary>
        public int Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentException("Length must be more than 0");
                }
                length = value;
            }
        }
        public LengthMinRule()
        {
            Length = 0;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value.ToString();
            if (input.Length > Length)
            {
                return new ValidationResult(false, "Must more than " + Length);
            }
            return new ValidationResult(true, null);

        }
    }
}
