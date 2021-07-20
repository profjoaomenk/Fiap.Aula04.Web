using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula04.Web.Models
{
    public enum Tipo
    {
        [Display(Name = "On-Line")]
        OnLine,
        Presencial,
        Hibrido,
        [Display(Name = "Semi-Presencial")]
        SemiPresencial
    }
}
