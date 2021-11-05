using Dtos.EstateDtos;
using RealEstate.Models;

namespace Mappers
{
    public static class EstateMapper
    {
        public static Estate ToEstate(this EstateDto estateDto)
        {
            return new Estate()
            {
                Id = estateDto.Id,
                Address = estateDto.Address,
                Available = estateDto.Available,
                ContactPersonEmail = estateDto.ContactPersonEmail,
                ContactPersonName = estateDto.ContactPersonName,
                ContactPersonPhone = estateDto.ContactPersonPhone,
                EstateName = estateDto.EstateName,
                Latitude = estateDto.Latitude,
                Longitude = estateDto.Longitude,
                PhotoUrl = estateDto.PhotoUrl
            };
        }

        public static EstateDto ToEstateDto(this Estate estate)
        {
            return new EstateDto()
            {
                Id = estate.Id,
                Address = estate.Address,
                Available = estate.Available,
                ContactPersonEmail = estate.ContactPersonEmail,
                ContactPersonName = estate.ContactPersonName,
                ContactPersonPhone = estate.ContactPersonPhone,
                EstateName = estate.EstateName,
                Latitude = estate.Latitude,
                Longitude = estate.Longitude,
                PhotoUrl = estate.PhotoUrl
            };
        }
    }
}
