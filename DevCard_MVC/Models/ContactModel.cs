using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class ContactModel
    {

        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(3,ErrorMessage ="حداقل طول نام سه کاراکتر است")]
        [MaxLength(100,ErrorMessage ="حداکثر طول نام صد کاراکتر است")]
        public string Name { get; set; }



        [Required(ErrorMessage ="این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل صحیح نیست")]
        public string Email { get; set; }





        public string Message { get; set; }

        public string Service { get; set; }


    }
}
