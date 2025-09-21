using BussinessObject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject.Model
{
    public class UserFollow
    {
        [Key]
        public Guid FollowingId { get; set; }  

        [Key]
        public Guid FollowerId { get; set; }  

        public DateTime? FollowDate { get; set; }    
        public bool IsDeleted { get; set; } = false;

        [ForeignKey("FollowerId")]
        public virtual User FollowerUser { get; set; } = null!;
        [ForeignKey("FollowingId")]
        public virtual User FollowingUser { get; set; } = null!;
    }
}
