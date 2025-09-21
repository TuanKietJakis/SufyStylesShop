using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Admin
{
    public class ShowUserForManageDto
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public string? RoleName { get; set; }
        public string Username { get; set; }
        public string? ProfileName { get; set; }
        public string Email { get; set; }
        public string UrlImage { get; set; } 
        public string? Bio { get; set; }
        public string? Phone { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }

        public DateOnly? Birthday { get; set; }

        public bool? Gender { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsAcceptMarketing { get; set; } = false;

        public bool IsDeleted { get; set; } = false;

        public bool IsBanned { get; set; } = false;

        public string? ReasonBan { get; set; } = null;

    }
}
