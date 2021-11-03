
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Tshopper.Infrastructure
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var listProvince = new List<Province>();
            var userId = Guid.NewGuid();
            for (int i = 0; i < 8000000; i++)
            {
                listProvince.Add(new Province
                {

                    Id = Guid.NewGuid(),
                    Code = $"ProvinceCode-{i}",
                    Name = $"{i}-{i}-{i}",
                    CreatedByUserId = userId,
                    ModifiedByUserId = userId,
                    DateModified = DateTime.Now,
                });
            }

            modelBuilder.Entity<Province>().HasData(listProvince);
        }
    }
}
