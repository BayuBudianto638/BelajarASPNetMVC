using BelajarASPNetMVC.Application.Services.Companies.Dto;
using BelajarASPNetMVC.Data;
using BelajarASPNetMVC.Data.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarASPNetMVC.Application.Services.Companies
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly AppDbContext _context;
        public CompanyAppService(AppDbContext context)
        {
            _context = context;
        }
        public void Create(CompanyDto company)
        {
            var addCompany = new Company()
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                Country = company.Country
            };

            _context.Company.Add(addCompany);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var company = _context.Company.FirstOrDefault(x => x.Id == id);
            if (company != null)
            {
                _context.Company.Remove(company);
                _context.SaveChanges();
            }
        }

        public CompanyDto GetById(int id)
        {
            var company = _context.Company.FirstOrDefault(x => x.Id == id);
            var companyDto = new CompanyDto
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                Country = company.Country
            };

            return companyDto;
        }

        public List<CompanyDto> GetCompanies()
        {
            var companies = _context.Company.ToList();
            var companyList = new List<CompanyDto>();

            foreach(var company in companies)
            {
                var companyDto = new CompanyDto()
                {
                    Id = company.Id,
                    Name = company.Name,
                    Address = company.Address,
                    Country = company.Country
                };

                companyList.Add(companyDto);
            }

            return companyList;
        }

        public void Update(CompanyDto company)
        {
            var updateCompany = new Company()
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                Country = company.Country
            };

            _context.Company.Update(updateCompany);
            _context.SaveChanges();
        }
    }
}
