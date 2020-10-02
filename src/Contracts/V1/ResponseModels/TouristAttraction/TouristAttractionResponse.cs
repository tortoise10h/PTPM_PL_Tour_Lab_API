using System;

namespace src.Contracts.V1.ResponseModels.TouristAttraction
{
    public class TouristAttractionResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}