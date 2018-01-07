using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzb.ShopLogin
{
    public class JData
    {
        public string id { get; set; }
        public bool isNewRecord { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string userId { get; set; }
        public string contactId { get; set; }
        public JCompany company { get; set; }
        public JOffice office { get; set; }
        public string isAgent { get; set; }
        public string shopName { get; set; }
        public string shopNumber { get; set; }
        public string shopTwoCode { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string area { get; set; }
        public string shopDetailedAddress { get; set; }
        public string paymentType { get; set; }
        public string accountMoney { get; set; }
        public string payMoney { get; set; }
        public string isSecHeadImage { get; set; }
        public string isLock { get; set; }
        public string provinceName { get; set; }
        public string cityName { get; set; }
        public string areaName { get; set; }
    }
}
