using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsViewerClient.Models
{
    public class GroupAccessPermission
    {
        public int? UserGroupAccessPermissionId { get; set; }

        public int? UserGroupId { get; set; }

        public int AccessPermissionId { get; set; }

        public string AccessPermissionName { get; set; }

        public string AccessPermissionTag { get; set; }

        public bool Assigned { get; set; }
    }
}
