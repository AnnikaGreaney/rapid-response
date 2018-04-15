using RapidResponse.domain;
using System.Data.Entity.ModelConfiguration;

namespace RapidResponse.database.Mapping
{
    public class TaskItemMapping : EntityTypeConfiguration<TaskItem>
    {
        public TaskItemMapping()
        {
            ToTable("TaskItem");

            HasKey(x => x.Id);

            Property(x => x.Priority)
                .HasColumnName("Priority");

            Property(x => x.Status)
                .HasColumnName("Status");

            HasMany(x => x.Owners)
                .WithMany(x => x.Tasks);

            Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(DataLengthStandards.TaskDescription);

            Property(x => x.CreatedUTC)
                .HasColumnName("CreatedUTC");

            Property(x => x.CompletedUTC)
                .HasColumnName("CompletedUTC");

            Property(x => x.Location.Latitude)
                .HasColumnName("Latitude");

            Property(x => x.Location.Longitude)
                .HasColumnName("Longitude");

            HasMany(x => x.Owners)
                .WithMany(x => x.Tasks);
        }
    }
}
