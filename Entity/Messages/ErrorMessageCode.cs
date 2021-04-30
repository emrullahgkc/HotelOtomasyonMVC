using System.ComponentModel;

namespace Entity.Messages
{
 
    public enum ErrorMessageCode
    {
        UsernameAlreadyExists = 101,
        EmailAlreadyExists = 102,
        UserIsNotActive = 151,
        UsernameOrPassWrong = 152,
        CheckYourEmail = 153,
        UserAlreadyActive = 154,
        ActivateIdDoesNotExists = 155,
        UserNotFound = 156,
        ProfileCouldNotUpdated = 157,
        UserCouldNotRemove = 158,
        UserCouldNotFind = 159,
        RegionNameAlreadyExists = 160,
        RegionNotFound = 161,
        RegionCouldNotFind = 162,
        RegionCouldNotRemove = 163,
        CountryNameAlreadyExists = 164,
        CountryNotFound = 165,
        CountryCouldNotUpdated = 166,
        NameAlreadyExists = 167,
        PlateNoAlreadyExists = 168,
        AreaCodeAlreadyExists = 169,
        CityCouldNotUpdated = 170,
        CityCouldNotRemove = 171,
        CityCouldNotFound = 172,
        RegionCodeAlreadyExists = 173,
        RegionCouldNotUpdated = 174,
        CityNameAlreadyExists = 175,
        DistrictNameAlreadyExists = 176,
        PostCodeAlreadyExists = 177,
        DistrictCouldNotFound = 178,
        DistrictNotFound = 179,
    }

  
}