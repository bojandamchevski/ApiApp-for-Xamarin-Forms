using DataAccess.Interfaces;
using Dtos.EstateDtos;
using Mappers;
using RealEstate.Models;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private IRepository<Estate> _estateRepository;
        public UserService(IRepository<Estate> estateRepository)
        {
            _estateRepository = estateRepository;
        }
        public List<EstateDto> GetAllEstates()
        {
            return _estateRepository.GetAll().Select(x => x.ToEstateDto()).ToList();
        }

        public EstateDto GetEstateById(int id)
        {
            return _estateRepository.GetById(id).ToEstateDto();
        }
    }
}
