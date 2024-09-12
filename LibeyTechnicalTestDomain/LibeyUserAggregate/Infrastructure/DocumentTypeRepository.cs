using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly Context _context;

        public DocumentTypeRepository(Context context)
        {
            _context = context;
        }
        public List<DocumentTypeResponse> GetAll()
        {
            var documentsType = _context.DocumentTypes.ToList();

            var responseList = new List<DocumentTypeResponse>();
            foreach (var docs in documentsType)
            {
                var response = new DocumentTypeResponse()
                {
                    DocumentTypeId = docs.DocumentTypeId,
                    DocumentTypeDescription = docs.DocumentTypeDescription
                };

                responseList.Add(response);
            }
            return responseList;
        }
    }
}
