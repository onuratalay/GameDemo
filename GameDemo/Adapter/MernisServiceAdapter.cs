using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;
using MernisServiceReference;

namespace GameDemo.MernisServiceAdapter
{
    public class MernisServiceAdapter:IPlayerCheckService

    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(player.IdentityNumber, player.FirstName, player.LastName, player.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
