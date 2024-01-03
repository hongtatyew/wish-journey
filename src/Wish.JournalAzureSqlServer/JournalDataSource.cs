﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Savvyio.Extensions.EFCore;

namespace Wish.JournalAzureSqlServer
{
    public class JournalDataSource : EfCoreDataSource
    {
        public JournalDataSource(IConfiguration configuration) : base(o =>
        {
            o.ContextConfigurator = b => b.UseSqlServer(configuration.GetConnectionString("Journal"));
            o.ModelConstructor = mb => mb.AddJournal();
        })
        {
        }
    }
}
