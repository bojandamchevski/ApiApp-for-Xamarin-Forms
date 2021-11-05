using Dtos.EstateDtos;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IUserService
    {
        List<EstateDto> GetAllEstates();
        EstateDto GetEstateById(int id);
    }
}
