using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels
{
    public class AppSettingsModel 
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    
 
    public class ConnectionStrings
    {
        public string DataBaseConnection { get; set; }
    }

   

}
