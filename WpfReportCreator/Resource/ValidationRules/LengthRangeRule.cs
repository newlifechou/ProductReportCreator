using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfReportCreator.Resource.ValidationRules
{
    public class LengthRangeRule : ValidationRule
    {
        private int min;
        /// <summary>
        /// 设定输入的长度
        /// </summary>
        public int Min
        {
            get { return min; }
            set
            {
                if (value >= max)
                {
                    throw new ArgumentException("min value must less than max");
                }
                min = value;
            }
        }
        private int max;

        public int Max
        {
            get { return max; }
            set
            {
                if (value > min)
                {
                    throw new ArgumentException("max value must more than min");
                }
                max = value;
            }
        }


        public LengthRangeRule()
        {
            Min = 0;
            Max = 20;
        }


        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value.ToString();
            if (input.Length < Min || input.Length > Max)
            {
                return new ValidationResult(false, "Must more than " + Min+", and less than "+ Max);
            }
            return new ValidationResult(true, null);

        }

    }
}
