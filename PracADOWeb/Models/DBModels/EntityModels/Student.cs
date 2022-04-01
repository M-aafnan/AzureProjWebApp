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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Attendances = new HashSet<Attendance>();
            this.HostelFeePayments = new HashSet<HostelFeePayment>();
        }
    
        public string AdmissionNo { get; set; }
        public string EnrollmentNo { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FatherCN { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public string ContactNo { get; set; }
        public string EmailID { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public System.DateTime AdmissionDate { get; set; }
        public string Session { get; set; }
        public string Caste { get; set; }
        public string Religion { get; set; }
        public byte[] Photo { get; set; }
        public string Status { get; set; }
        public string Nationality { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }
        public Nullable<int> SchoolID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HostelFeePayment> HostelFeePayments { get; set; }
        public virtual School School { get; set; }
    }
}
