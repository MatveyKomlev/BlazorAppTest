using BlazorAppTest.Services;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppTest.src
{
    public class PurchaseContext : DbContext
    {
        // DbSet-свойства добавляем после описания наших табличных классов, сейчас не нужно
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<ProposalMaterial> ProposalMaterials { get; set; }

        // Обязательная настройка конструктора. Конфигуратор в Startup’е использует этот конструктор
        public PurchaseContext(DbContextOptions<PurchaseContext> options) : base(options)
        { }

    }
}
