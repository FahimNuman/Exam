using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
