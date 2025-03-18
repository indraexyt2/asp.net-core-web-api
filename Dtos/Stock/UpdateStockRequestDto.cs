using System.ComponentModel.DataAnnotations;

namespace Latihan.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 over")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "Company Name cannot be over 10 over")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 1000000000, ErrorMessage = "Purchase value must be between 1 and 1,000,000,000")]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001, 100, ErrorMessage = "Last Div value must be between 0.001 and 100")]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry cannot be over 10 character")]
        public string Industry { get; set; } = string.Empty;
        [Range(1, 500000000000)]
        public long MarketCap { get; set; }
    }
}
