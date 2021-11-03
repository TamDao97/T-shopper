using System;

namespace Tshopper.Infrastructure
{
    public class ProductViewModel : BaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? ImportPrice { get; set; }
        public double? ExportPrice { get; set; }
        public int? Amount { get; set; }
        public int? QuantityOfInventory { get; set; }
        public int? StarPoint { get; set; }
        public bool IsHotTrend { get; set; }
    }

    public class ProductModel : ProductViewModel
    {
        public Guid CategoryId { get; set; }
    }

    public class ProductCreateModel : ProductModel
    {
        public Guid CreatedByUserId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }

    public class ProductUpdateModel : ProductModel
    {
        public Guid ModifiedByUserId { get; set; }
        public DateTime DateModified { get; set; }
    }

    public class ProductFilterModel : FilterBaseModel
    {
        public double? StartPrice { get; set; }
        public double? EndPrice { get; set; }
        public int? StarPoint { get; set; }
        public bool IsHotTrend { get; set; }
    }
}
