using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class UserInfo
    {

        public int Id { get; set; }
        [Required (ErrorMessage ="Ad bilgisi girilmeli")]
        public string? Name { get; set; }
        [Required (ErrorMessage ="Telefon numarasi girilmeli")]
        public string? Phone { get; set; }
        [Required (ErrorMessage ="Email adresi girilmeli")]
        [EmailAddress (ErrorMessage ="Hatali Email")]
        public string? Email { get; set; }
        [Required (ErrorMessage ="Katilim Bilgisi Girilmeli")]
        public bool? WillAttend { get; set; }    


    }
}