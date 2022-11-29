using Mvc.JQuery.DataTables.Models;
using Mvc.JQuery.DataTables;

namespace BelajarASPNetMVC.Models.Companies
{
    public class EditCompanyViewModel
    {
        [DataTables(Order = 0, Visible = false)]
        public int Id { get; set; }
        [DataTables(DisplayName = "Name", SortDirection = SortDirection.Ascending, Searchable = true, Width = "250px")]
        public string Name { get; set; }
        [DataTables(DisplayName = "Address", Sortable = false)]
        public string Address { get; set; }
        [DataTables(DisplayName = "Country", Sortable = false)]
        public string Country { get; set; }
    }
}
