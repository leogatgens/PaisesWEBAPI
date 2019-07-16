using System;
using System.ComponentModel.DataAnnotations;

namespace PaisesWEBAPI.Entities
{
    public class TablaDMPrep
    {


        

        [Required]
        public string EnglishProductCategoryName { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int CustomerKey { get; set; }

      

        [Required]
        public string Region { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string IncomeGroup { get; set; }


        [Required]
        public Int16 CalendarYear { get; set; }


        [Required]
        public Int16 FiscalYear { get; set; }


        [Required]
        public byte Month { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        [Required]
        public byte LineNumber { get; set; }

        
              [Required]
        public Int16 Quantity { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Key]        
        public int IdTabla { get; set; }


        [Required]
        public decimal AmountAjustado { get; set; }

        


    }
}
