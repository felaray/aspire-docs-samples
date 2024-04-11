using Microsoft.EntityFrameworkCore;
using SupportTicketApi.Models;

namespace SupportTicketApi.Data
{
    public class TicketContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<SupportTicket> Tickets => Set<SupportTicket>();
    }
}
