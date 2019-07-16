
using PaisesWEBAPI.Entities;
using System.Collections.Generic;

namespace PaisesWEBAPI.Services
{
    public interface IReportesRepository
    {
        IEnumerable<TablaDMPrep> ListReportOne();

        bool Save();
    }
}
