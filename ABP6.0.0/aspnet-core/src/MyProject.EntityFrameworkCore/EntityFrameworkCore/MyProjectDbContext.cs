using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyProject.Authorization.Roles;
using MyProject.Authorization.Users;
using MyProject.MultiTenancy;
using MyProject.BaseInfo;

namespace MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<CardFeeInfo> CardFeeInfos { get; set; }
        public virtual DbSet<CommissionRules> CommissionRules { get; set; }
        public virtual DbSet<FitnessProjectInfos> FitnessProjectInfos { get; set; }
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
        }
    }
}
