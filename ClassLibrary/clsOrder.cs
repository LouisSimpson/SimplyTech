using System;

namespace clslibrary
{
    public class clsOrder
    {
        public DateTime DateOrdered { get; set; }
        public int OrderNo { get; set; }
        public double OrderPrice { get; set; }
        public string ProductName { get; set; }
        public int ProductNo { get; set; }
        public int QuantityNo { get; set; }

        public bool Valid(int someOrder)
        {
            return true;
        }

        public bool Find(int orderNo)
        {
            return true;
        }
    }
}