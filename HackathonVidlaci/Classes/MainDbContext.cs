using Microsoft.EntityFrameworkCore;

namespace HackathonVidlaci.Classes;

public class HradyContext : DbContext
{
    public DbSet<Hrady> hrady { get; set; }
    public HradyContext(DbContextOptions<HradyContext> options) : base(options) { }
}

public class HrobyContext : DbContext
{
    public DbSet<ValHroby> Válečné_hroby { get; set; }
    public HrobyContext(DbContextOptions<HrobyContext> options) : base(options) { }
}

public class DivadlaContext : DbContext
{
    public DbSet<DivadlaAFilharmonie> Divadla_a_filharmonie { get; set; }
    public DivadlaContext(DbContextOptions<DivadlaContext> options) : base(options) { }
}

public class ZamkyContext : DbContext
{
    public DbSet<Zamky> Zámky { get; set; }
    public ZamkyContext(DbContextOptions<ZamkyContext> options) : base (options) { }
}

public class KulturniDomyContext : DbContext
{
    public DbSet<KulturniDomy> Kulturní_domy { get; set; }
    public KulturniDomyContext(DbContextOptions<KulturniDomyContext> options) : base(options) { }
}

public class TechnickePamatkyContext : DbContext
{
    public DbSet<TechnickePamatky> Technické_památky { get; set; }
    public TechnickePamatkyContext(DbContextOptions<TechnickePamatkyContext> options) : base(options) { }
}

//public class PamatkyContext : DbContext
//{
//    public DbSet<Pamatky> Národní_památky {get; set;}
//    public PamatkyContext(DbContextOptions<PamatkyContext> options): base (options) { }
//}