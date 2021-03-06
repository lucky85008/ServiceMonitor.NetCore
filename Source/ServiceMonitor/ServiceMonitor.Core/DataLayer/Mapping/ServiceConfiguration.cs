﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceMonitor.Core.EntityLayer;

namespace ServiceMonitor.Core.DataLayer.Mapping
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            // Mapping for table
            builder.ToTable("Service", "dbo");

            // Set key for entity
            builder.HasKey(p => p.ServiceID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ServiceID).UseSqlServerIdentityColumn();
        }
    }
}
