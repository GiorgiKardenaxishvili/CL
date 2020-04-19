﻿using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class SchedulePersonConfiguration : IEntityTypeConfiguration<SchedulePerson>
    {
        public void Configure(EntityTypeBuilder<SchedulePerson> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.CreateAppId)
                 .HasMaxLength(50);

            builder.Property(e => e.LastModifiedAppId)
                .HasMaxLength(50);

            builder.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(e => e.IsHidden)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(e => e.PersonId)
                .IsRequired();

            builder.Property(e => e.ScheduleId)
                .IsRequired();

            builder.Property(e => e.PersonStatusId)
                .IsRequired();
        }
    }
}
