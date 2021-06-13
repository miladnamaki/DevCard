using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class SendContect
    {
        [Required(ErrorMessage = "این فیلد اجباری است ")]
        [MinLength(3,ErrorMessage = "حداقل طول نام ، 3 کارکتر است ")]
        [MaxLength(100,ErrorMessage = "حداکثر  طول نام 100 کارکتر است ")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست ")]

        public string Email { get; set;  }
        public string Message { get; set; }
        public string Services { get; set; }
 

    }
}
