using ChargeShare.AdresService.DAL.Contexts;
using Shared.Models;

namespace ChargeShare.AdresService.DAL.Repositories;

public class AdresRepository
{
    private readonly AdresContext _adresContext;
    public AdresRepository(AdresContext adresContext)
    {
        _adresContext = adresContext;
    }

    public async Task<IEnumerable<ChargeStationModel>> GetAllAsync()
    {
        return _adresContext.Adresses;
    }
}