using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range <T> where T : IComparable<T>
    {
        #region Properies
        public T Max { get; set; }
        public T Min { get; set; }

        #endregion

        #region Constractors
        public Range(T min, T max)
        {
            Max = max;
            Min = min;
        }
        #endregion

        #region Methods
        public string IsInRange(T value)
        {
            if (value.CompareTo(Max) <= 0 && value.CompareTo(Min) >= 0)
                return "true";
            else
                return "false";
        }
        public T Length()
        {
            dynamic max = Max;
            dynamic min = Min;
            return max -min;        
        }
        #endregion
    }
}
