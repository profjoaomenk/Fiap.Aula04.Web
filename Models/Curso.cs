using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula04.Web.Models
{
    [Table("Tbl_Curso")]
    public class Curso
    {
        //Chave primária: Nome da Classe + Id (valores gerado automáticamente)
        [Column("Id")]
        [HiddenInput]
        public int CursoId { get; set; }
        
        [Required, MaxLength(50)]
        public string Nome { get; set; }
        
        [Column("Dt_lancamento")]
        [DataType(DataType.Date), Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }
        
        public Tipo Tipo { get; set; }
        
        public bool Certificado { get; set; }
        
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
