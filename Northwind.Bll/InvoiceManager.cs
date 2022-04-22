using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class InvoiceManager<T, TDto> : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        //IInvoiceRepository
        IInvoiceRepository invoiceRepository;

        public InvoiceManager(IInvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }

        public IQueryable<DtoInvoice> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}