using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleCode.Models
{
    public class Movie
    {       
        public int Id { get; set; }

        //[Required(ErrorMessage="Title is required!")]
        public string Title { get; set; }

        //[Required(ErrorMessage="Director is required!")]
        //[StringLength(5, ErrorMessage="You put in too many characters!")]
        public string Director { get; set; }
    }
}