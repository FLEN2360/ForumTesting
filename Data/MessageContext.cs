using ForumTesting.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ForumTesting.Data
{
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}
