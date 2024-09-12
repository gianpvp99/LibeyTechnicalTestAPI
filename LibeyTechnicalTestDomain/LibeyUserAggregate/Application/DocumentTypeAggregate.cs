using AutoMapper;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class DocumentTypeAggregate : IDocumentTypeAggregate
    {
        private readonly IDocumentTypeRepository _repository;
        private readonly IMapper _mapper;
        public DocumentTypeAggregate(IDocumentTypeRepository repository,IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public List<DocumentTypeResponse> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
