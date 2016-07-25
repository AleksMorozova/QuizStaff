using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class PermissionDTO
    {
        public Guid Id { get; set; }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != title)
                {
                    title = value;
                }
            }
        }

        public static implicit operator PermissionDTO(Permission permission)
        {
            PermissionDTO newPermission = new PermissionDTO();
            
            newPermission.Id = permission.Id;
            newPermission.Title = permission.Title;

            return newPermission;
        }
    }
}
