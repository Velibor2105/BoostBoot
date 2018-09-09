using System;
using System.Collections.Generic;

namespace Model
{
    public class Company
    {
        public object SortingDynamic { get; set; }
        public int? CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string RegistryCode { get; set; }
        public string VatNumber { get; set; }
        public string FoundingDateString { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyPlace { get; set; }
        public string PostalCode { get; set; }
        public string LegalForm { get; set; }
        public string OccupationCode { get; set; }
        public string OccupationName { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string CountryFlag { get; set; }
        public string CompanyAddress { get; set; }
        public double? Revenue { get; set; }
        public int? LastFinReportYear { get; set; }
        public string LastFinReportYearText { get; set; }
        public string AprStatus { get; set; }
        public string NbsStatus { get; set; }
        public string RevenueText { get; set; }
        public double? RevenueChange { get; set; }
        public string RevenueChangeText { get; set; }
        public string RevenueChangeTrendArrow { get; set; }
        public double? Profit { get; set; }
        public string ProfitText { get; set; }
        public double? ProfitChange { get; set; }
        public string ProfitChangeText { get; set; }
        public string ProfitChangeTrendArrow { get; set; }
        public int? NumberOfEmployees { get; set; }
        public string NumberOfEmployeesText { get; set; }
        public double? NumberOfEmployeesChange { get; set; }
        public string NumberOfEmployeesChangeText { get; set; }
        public string NumberOfEmployeesChangeTrendArrow { get; set; }
        public int? FinReportYear { get; set; }
        public double? Ebit { get; set; }
        public string EbitText { get; set; }
        public double? Ebitda { get; set; }
        public string EbitdaText { get; set; }
        public object PdvNumber { get; set; }
        public string Email { get; set; }
    }

    public class RootObject
    {
        public List<Company> Data { get; set; }
    }
}
