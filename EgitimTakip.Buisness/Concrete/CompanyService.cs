using EgitimTakip.Buisness.Abstract;
using EgitimTakip.IRepository.Shared.Abstract;
using EgitimTakip.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakip.Buisness.Concrete
{
    public class CompanyService:ICompanyService
    {
        private readonly ICompanyRepository _repo;

        public CompanyService(IRepository<Company> repo)
        {
            _repo = repo;
        }

        public Company Add(Company company)
        {
           return _repo.Add(company);
        }

        public Company Delete(int id)
        {
        _repo.Delete(id);
            return true;
        }

        public IQueryable<Company> GetAll()
        {
            return _repo.GetAll();
        }

        public Company Update(Company company)
        {
            return _repo.Update(company);
        }


    }
}
