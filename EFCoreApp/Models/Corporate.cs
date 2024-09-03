using System;

namespace EFCoreApp.Models
{
    public class Corporate
    {
        public int CorporateID { get; set; }
        public string? JobTitle { get; set; }
        public string? Education {  get; set; }
        public int Experience {  get; set; }
        public long Salary { get; set; }
    }
}
