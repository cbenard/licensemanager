using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseManager
{
    public class LicenseInformation
    {
        public string Product { get; set; }
        public DateTime? Expiration { get; set; }
        public bool IsValid { get; set; }
    }
}
