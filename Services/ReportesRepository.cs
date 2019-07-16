
using PaisesWEBAPI.Context;
using PaisesWEBAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaisesWEBAPI.Services
{
    public class ReportesRepository : IReportesRepository
    {
        private readonly ReportContext datacontext;

        public ReportesRepository(ReportContext context)
        {
            datacontext = context;


        }

        IEnumerable<TablaDMPrep> IReportesRepository.ListReportOne()
        {
          return  datacontext.TablaDMPrep.Take(500000).ToList();
        }

        bool IReportesRepository.Save()
        {
            throw new NotImplementedException();
        }
    }
}
