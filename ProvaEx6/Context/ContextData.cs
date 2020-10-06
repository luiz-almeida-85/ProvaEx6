using ProvaEx6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaEx6.Context
{
    public class ContextData : DbContext

    {
        public DbSet<Aluno> Alunos { get; set; }

    }
}