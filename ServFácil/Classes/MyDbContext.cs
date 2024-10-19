using LavaK.Classes;
using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using FirebirdSql.EntityFrameworkCore.Firebird;

namespace ServFacil.Classes
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder construtorOpcoes)
        {
            construtorOpcoes.UseFirebird(FdbGeral.stringConexao);
        }

        public DbSet<Cliente_Fornecedor> CLIENTE_FORNECEDOR { get; set; }

        protected override void OnModelCreating(ModelBuilder construtorModelo)
        {
            base.OnModelCreating(construtorModelo);

            construtorModelo.Entity<Cliente_Fornecedor>()
                .ToTable("CLIENTE_FORNECEDOR")
                .HasKey(pk => pk.ID);
        }
    }
    public class Cliente_Fornecedor
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public char CAD_NACIONAL { get; set; }
        public string CPF { get; set; }
        public string BAIRRO { get; set; }
        public string IE { get; set; }
        public char CLI_FORN { get; set; }
        public string PAIS { get; set; }
        public char UF { get; set; }
        public string CIDADE { get; set; }
        public string RUA { get; set; }
        public string CEP { get; set; }
        public string CELULAR { get; set; }
        public DateTime DT_NASCIMENTO { get; set; }
        public DateTime DT_HR_CADASTRO { get; set; }
    }
}
