using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevisaoDoTempo.API
{
    public interface IApiService
    {
        [Get("/weather?key=48b4b015&city_name={city}")]
        Task<HGResponse> GetTemp(string city);
    }
}
