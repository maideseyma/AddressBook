using AddressBookEL.Models;
using AddressBookEL.ViewModels;
using AutoMapper;

namespace AddressBookEL.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            // hangi dto nun hangi modele dönüşeceğini ayarlıyoruz

            CreateMap<City, CityVM>().ReverseMap();
            CreateMap<District, DistrictVM>().ReverseMap();
            CreateMap<Neighbourhood, NeighbourhoodVM>().ReverseMap();
            CreateMap<UserAddress, UserAddressVM>().ReverseMap();

        }

    }
}
