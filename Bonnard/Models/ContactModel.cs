using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bonnard.Models
{
    public class ContactModel
    {
        [Required, Display(Name = "Votre nom")]
        public string _name { get; set; }
        [Required, Display(Name = "Votre email"), EmailAddress]
        public string _email { get; set; }
        [Display(Name = "Objet")]
        public string _subject { get; set; }
        [Display(Name = "Commentaires")]
        [Required,MaxLength(140), MinLength(20)]
        public string _content { get; set; }
    }
}