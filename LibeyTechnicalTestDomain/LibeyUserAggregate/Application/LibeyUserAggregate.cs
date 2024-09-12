using AutoMapper;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class LibeyUserAggregate : ILibeyUserAggregate
    {
        private readonly ILibeyUserRepository _repository;
        private readonly IMapper _mapper;
        public LibeyUserAggregate(ILibeyUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Create(UserUpdateorCreateCommand command)
        {
            var domainDTO = _mapper.Map<LibeyUser>(command);
            _repository.Create(domainDTO);
        }

        public void Delete(string documentNumber)
        {
            _repository.Delete(documentNumber);
        }

        public LibeyUserResponse FindResponse(string documentNumber)
        {
            var row = _repository.FindResponse(documentNumber);
            return row;
        }
        public void Update(UserUpdateorCreateCommand command)
        {
            var domainDTO = _mapper.Map<LibeyUser>(command);
            _repository.Update(domainDTO);
        }

        public List<LibeyUserResponse> GetAll()
        {
            var list = _repository.GetAll();
            return list;
        }

        
    }
}