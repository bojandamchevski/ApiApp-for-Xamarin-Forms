namespace Dtos.EstateDtos
{
    public class EstateDto
    {
        public long Id { get; set; }

        public string EstateName { get; set; }

        public string ContactPersonName { get; set; }

        public string ContactPersonPhone { get; set; }

        public string ContactPersonEmail { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Address { get; set; }

        public string PhotoUrl { get; set; }

        public bool Available { get; set; }
    }
}
