//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracADOWeb.Models.DBModels.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookIssueStaffs = new HashSet<BookIssueStaff>();
        }
    
        public string AccessionNo { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string JointAuthors { get; set; }
        public string Subject { get; set; }
        public string Department { get; set; }
        public string Barcode { get; set; }
        public string ISBN { get; set; }
        public string Volume { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
        public string PlaceOfPublisher { get; set; }
        public string CD { get; set; }
        public Nullable<int> PublishingYear { get; set; }
        public string Reference { get; set; }
        public string AlmiraPosition { get; set; }
        public Nullable<int> Price { get; set; }
        public string SupplierName { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string Remarks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookIssueStaff> BookIssueStaffs { get; set; }
    }
}
