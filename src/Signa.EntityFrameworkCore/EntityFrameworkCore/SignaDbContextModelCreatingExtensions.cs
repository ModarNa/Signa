using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Signa.EntityFrameworkCore
{
    public static class SignaDbContextModelCreatingExtensions
    {
        public static void ConfigureSigna(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SignaConsts.DbTablePrefix + "YourEntities", SignaConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}