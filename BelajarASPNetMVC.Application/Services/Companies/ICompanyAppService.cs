using BelajarASPNetMVC.Application.Services.Companies.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarASPNetMVC.Application.Services.Companies
{
    public interface ICompanyAppService
    {
        List<CompanyDto> GetCompanies();
        void Create(CompanyDto company);
        CompanyDto GetById(int id);
        void Update(CompanyDto company);
        void Delete(int id);
    }
}
