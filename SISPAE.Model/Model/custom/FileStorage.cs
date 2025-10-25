using System;
using System.Collections.Generic;
using System.Text;

namespace SISPAE.Model
 {
    public class FileStorage
    {
       public string  Type { get; set; }////filesystem-AzureAd-database-alfresco
        public string VirtualPath { get; set; }
        public AzureAd AzureAd { get; set; }
    }


    public class AzureAd
    {
        public string Instance { get; set; }
        public string Domain { get; set; }
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string CallbackPath { get; set; }
        public string SignedOutCallbackPath { get; set; }
        public string ClientSecret { get; set; }
    }
}

