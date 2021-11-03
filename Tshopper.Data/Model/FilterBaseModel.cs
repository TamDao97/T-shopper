
namespace Tshopper.Infrastructure
{
    public class FilterBaseModel
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string TextSearch { get; set; }
    }
}
