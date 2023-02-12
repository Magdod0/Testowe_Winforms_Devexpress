using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowe_WinF_Dev.DataModels.Repositories;

namespace Testowe_WinF_Dev.DataModels.UnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        /// <summary>
        /// Save all changes.
        /// </summary>
        void SaveChanges();
        /// <summary>
        /// Check if there are changes
        /// </summary>
        bool HasChanges();

    }
}
