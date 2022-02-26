using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VedSpeaker.Data;
using System;
using System.Linq;

namespace VedSpeaker.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VedSpeakerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VedSpeakerContext>>()))
            {
                // Look for any movies.
                if (context.Speaker.Any())
                {
                    return;   // DB has been seeded
                }

                context.Speaker.AddRange(
                    new Speaker
                    {
                        Name = "JBL",
                        Features = "Water resistance",
                        Types = "Wireless",
                        BatteryLife = 20,
                        Size =15,
                        Rating =4,
                        Price = 50
                    },

                    new Speaker
                    {
                        Name = "Boat",
                        Features = "Visual Effects",
                        Types = "Wired",
                        BatteryLife = 30,
                        Size = 25,
                        Rating = 5,
                        Price = 100
                    },

                    new Speaker
                    {
                        Name = "Aman Gupta",
                        Features = "Durable",
                        Types = "Wireless",
                        BatteryLife = 24,
                        Size = 12,
                        Rating = 3,
                        Price = 170
                    },

                    new Speaker
                    {
                        Name = "Nirvana",
                        Features = "Versatile portability",
                        Types = "Wireless",
                        BatteryLife = 18,
                        Size = 18,
                        Rating = 4,
                        Price = 200
                    },
                    new Speaker
                    {
                        Name = "Bose",
                        Features = "Durable",
                        Types = "Wired",
                        BatteryLife = 35,
                        Size = 20,
                        Rating = 5,
                        Price = 135
                    },
                    new Speaker
                    {
                        Name = "Nirvana",
                        Features = "Water resistance",
                        Types = "Wireless",
                        BatteryLife = 40,
                        Size = 22,
                        Rating = 2,
                        Price = 145
                    },
                    new Speaker
                    {
                        Name = "Subwoofer",
                        Features = "Visual effects",
                        Types = "Wireless",
                        BatteryLife = 38,
                        Size = 16,
                        Rating = 3,
                        Price = 165
                    },
                    new Speaker
                    {
                        Name = "Philips",
                        Features = "Durable",
                        Types = "Wireless",
                        BatteryLife = 24,
                        Size = 19,
                        Rating = 4,
                        Price = 190
                    },
                    new Speaker
                    {
                        Name = "Dynaudio",
                        Features = "Versatile portability",
                        Types = "Wired and Wireless",
                        BatteryLife = 35,
                        Size = 27,
                        Rating = 5,
                        Price = 250
                    },
                    new Speaker
                    {
                        Name = "Klipsch",
                        Features = "Durable",
                        Types = "Wireless",
                        BatteryLife = 24,
                        Size = 15,
                        Rating = 3,
                        Price = 150
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
