using EgitimTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakip.Buisness.Abstract
{
    public interface ICompanyService
    {
        IQueryable<Company> GetAll();

        Company Add(Company company);

        Company Update(Company company);

        Company Delete(int id);

    }
}
