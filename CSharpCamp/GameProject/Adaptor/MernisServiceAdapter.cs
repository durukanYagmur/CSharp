using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adaptade
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient
                (KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.gamerTC),
                gamer.gamerName.ToUpper(),
                gamer.gamerSurname.ToUpper(), gamer.dateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }

       
    }
}
