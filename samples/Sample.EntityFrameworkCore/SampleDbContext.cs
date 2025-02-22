﻿namespace Sample.EntityFrameworkCore
{
	using Fluxera.Repository.EntityFrameworkCore;
	using JetBrains.Annotations;
	using Microsoft.EntityFrameworkCore;
	using Sample.Domain.Company;

	[PublicAPI]
	public sealed class SampleDbContext : DbContext
	{
		public SampleDbContext()
		{
		}

		public SampleDbContext(DbContextOptions<SampleDbContext> options)
			: base(options)
		{
		}

		/// <inheritdoc />
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseInMemoryDatabase("sample");
			}
		}

		/// <inheritdoc />
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Company>(entity =>
			{
				entity.ToTable("Companies");

				entity.OwnsOne(x => x.Address);

				entity.UseRepositoryDefaults();
			});
		}
	}
}
