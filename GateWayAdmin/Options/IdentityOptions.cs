using System.Collections.Generic;

namespace ASPNetCoreIdentityCookie.Options
{
    public class IdentitySettingOptions
    {
        public IDictionary<string, string> Users { get; set; }

        public int ExpiryTime { get; set; }
    }
}
