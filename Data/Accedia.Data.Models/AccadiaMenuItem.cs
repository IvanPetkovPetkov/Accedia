namespace Accedia.Data.Models
{
    using Accedia.Data.Common.Models;

    public class AccadiaMenuItem : BaseModel<int>
    {
        public string Name { get; set; }

        public bool IsVisible { get; set; }

        public bool OrderNumber { get; set; }
    }
}
