﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppExamen.Entidades;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<AppExamen.Entidades.Pelicula> Pelicula { get; set; } = default!;

public DbSet<AppExamen.Entidades.Actor> Actor { get; set; } = default!;
    }
