using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}
