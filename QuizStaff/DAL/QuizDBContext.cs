using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuizDBContext : DbContext
    {
        public QuizDBContext(string connection)
            : base(connection)
        {

            Database.CreateIfNotExists();
        }

        public DbSet<Testee> Testees { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<TesteeTraining> TesteeTrainings { get; set; }
        public DbSet<TesteeRoles> TesteeRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<ApplicationSettings> ApplicationSettings { get; set; }
        public DbSet<TesteeAnswer> TesteeAnswers { get; set; }
        public DbSet<DaysOfUpdate> DaysOfUpdate { get; set; }
    }
}
