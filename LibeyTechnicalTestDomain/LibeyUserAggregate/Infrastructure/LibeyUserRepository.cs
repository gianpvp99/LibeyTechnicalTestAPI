using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using System.Net;
using System.Numerics;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class LibeyUserRepository : ILibeyUserRepository
    {
        private readonly Context _context;
        public LibeyUserRepository(Context context)
        {
            _context = context;
        }
        public void Create(LibeyUser libeyUser)
        {
            _context.LibeyUsers.Add(libeyUser);
            _context.SaveChanges();
        }

        public void Delete(string documentNumber)
        {
            var user = _context.LibeyUsers.FirstOrDefault(u => u.DocumentNumber == documentNumber);
            if (user != null)
            {
                _context.Remove(user);
                _context.SaveChanges();
            }
        }

        public LibeyUserResponse FindResponse(string documentNumber)
        {

            var q = from libeyUser in _context.LibeyUsers.Where(x => x.DocumentNumber.Equals(documentNumber))
                    select new LibeyUserResponse()
                    {
                        DocumentNumber = libeyUser.DocumentNumber,
                        Active = libeyUser.Active,
                        Address = libeyUser.Address,
                        DocumentTypeId = libeyUser.DocumentTypeId,
                        Email = libeyUser.Email,
                        FathersLastName = libeyUser.FathersLastName,
                        MothersLastName = libeyUser.MothersLastName,
                        Name = libeyUser.Name,
                        Password = libeyUser.Password,
                        Phone = libeyUser.Phone
                    };
            var list = q.ToList();
            if (list.Any()) return list.First();
            else return new LibeyUserResponse();
        }

        public List<LibeyUserResponse> GetAll()
        {
            // Obtén la lista de usuarios
            var users = _context.LibeyUsers.ToList();

            var responseList = new List<LibeyUserResponse>();
            foreach(var user in users)
            {
                var response = new LibeyUserResponse()
                {
                    DocumentNumber = user.DocumentNumber,
                    DocumentTypeId = user.DocumentTypeId,
                    Name = user.Name,
                    FathersLastName = user.FathersLastName,
                    MothersLastName = user.MothersLastName,
                    Address = user.Address,
                    UbigeoCode = user.UbigeoCode,
                    Active = user.Active,
                    Email = user.Email,
                    Password = user.Password,
                    Phone = user.Phone
                };

                responseList.Add(response);
            }
            return responseList;
            
        }

        public void Update(LibeyUser libeyUser)
        {
            _context.LibeyUsers.Update(libeyUser);
            _context.SaveChanges();

        }
    }
}