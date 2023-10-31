using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteAula301023.Models;

namespace TesteAula301023.Data
{
    public class TesteAula301023Context : DbContext
    {
        public TesteAula301023Context (DbContextOptions<TesteAula301023Context> options)
            : base(options)
        {
        }

        public DbSet<TesteAula301023.Models.Aluno> Aluno { get; set; } = default!;
    }
}
