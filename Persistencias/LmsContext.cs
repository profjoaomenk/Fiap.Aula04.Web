using Fiap.Aula04.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula04.Web.Persistencias
{
    //Classe que gerencia as entidades da aplicação
    public class LmsContext :  DbContext
    {
        //Propriedades (Entidades da aplicação)
        public DbSet<Curso> Cursos { get; set; }

        //Contrutor
        public LmsContext(DbContextOptions options) : base(options)
        {
        }
    }
}
