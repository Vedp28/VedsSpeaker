using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VedSpeaker.Models;

namespace VedSpeaker.Data
{
    public class VedSpeakerContext : DbContext
    {
        public VedSpeakerContext (DbContextOptions<VedSpeakerContext> options)
            : base(options)
        {
        }

        public DbSet<VedSpeaker.Models.Speaker> Speaker { get; set; }
    }
}
