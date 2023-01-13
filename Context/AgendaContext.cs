﻿using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Context
{
    public class AgendaContext : DbContext
    {

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> contatos { get; set; }
    }
}
