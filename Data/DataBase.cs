using Microsoft.EntityFrameworkCore;


namespace Data {
    public class Context : DbContext {
        
        public DbSet<Models.Produto> Produtos { get; set; }
        public DbSet<Models.Almoxarifado> Almoxarifados { get; set; }
        public DbSet<Models.Saldo> Saldos { get; set; }
        public string connection = "Server=localhost;User Id=root;Database=atividade_win_forms";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(connection, ServerVersion.AutoDetect(connection));
    }
}
