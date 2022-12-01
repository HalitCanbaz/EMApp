using System;
using System.Collections.Generic;
using System.Text;

namespace EMApp.Data.Contracts
{
   public interface IUnitOfWork : IDisposable
    {
        void Save();



    }
}
