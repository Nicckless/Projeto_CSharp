﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestor_de_oficina
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StandAutomoveisContainer : DbContext
    {
        public StandAutomoveisContainer()
            : base("name=StandAutomoveisContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Carro> Carros { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }
        public virtual DbSet<Parcela> Parcelas { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }
        public virtual DbSet<Aluguer> Aluguers { get; set; }
    }
}
