using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ensemble.Models
{
    class Group
    {
        public Group(int intGroupID, string strName)
        {
            IntGroupID = intGroupID;
            StrName = strName;
        }

        public int IntGroupID { get; set; }

        public string StrName { get; set; }

    }
}