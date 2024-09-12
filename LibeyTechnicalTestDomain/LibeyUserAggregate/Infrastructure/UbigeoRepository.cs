using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class UbigeoRepository : IUbigeoRepository
    {
        private readonly Context _context;
        public UbigeoRepository(Context context) { _context = context; }
        public List<UbigeoResponses> List(string region, string province)
        {
            var ubigeo = _context.Ubigeos.Where(u => u.RegionCode == region && u.ProvinceCode == province).ToList();
            var responseList = new List<UbigeoResponses>();
            foreach (var u in ubigeo)
            {
                var response = new UbigeoResponses()
                {
                    UbigeoCode = u.UbigeoCode,
                    ProvinceCode = u.ProvinceCode,
                    RegionCode = u.RegionCode,
                    UbigeoDescription = u.UbigeoDescription
                };

                responseList.Add(response);
            }
            return responseList;
        }

        public List<UbigeoResponses> ListForUser(string ubigeo)
        {
            var list = _context.Ubigeos.Where(u => u.UbigeoCode == ubigeo).ToList();
            var responseList = new List<UbigeoResponses>();
            foreach (var u in list)
            {
                var response = new UbigeoResponses()
                {
                    UbigeoCode = u.UbigeoCode,
                    ProvinceCode = u.ProvinceCode,
                    RegionCode = u.RegionCode,
                    UbigeoDescription = u.UbigeoDescription
                };

                responseList.Add(response);
            }
            return responseList;
        }
    }
}
