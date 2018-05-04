using System;
using System.Collections.Generic;

namespace DBMS.Controllers.DB
{
    class Role
    {
        private int permissionId;
        private string roleName;

        public int PermissionId { get => permissionId; set => permissionId = value; }
        public string RoleName { get => roleName; set => roleName = value; }

        public Role(int permissionId, string roleName)
        {
            this.permissionId = permissionId;
            this.roleName = roleName ?? throw new ArgumentNullException(nameof(roleName));
        }

        public string GetDifferences(Role role)
        {
            string diff = "";

            if(permissionId != role.permissionId)
                diff += "permission_id";
            if(!RoleName.Equals(role.RoleName))
                diff += "role_name";

            return diff;
        }

        public override bool Equals(object obj)
        {
            var role = obj as Role;
            return role != null &&
                   permissionId == role.permissionId &&
                   roleName == role.roleName;
        }

        public override int GetHashCode()
        {
            var hashCode = -925703335;
            hashCode = hashCode * -1521134295 + permissionId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(roleName);
            return hashCode;
        }
    }
}
