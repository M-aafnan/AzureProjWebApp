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
    
    public partial class Attendance
    {
        public int AttendanceID { get; set; }
        public string Class { get; set; }
        public string Session { get; set; }
        public string Section { get; set; }
        public string SubjectCode { get; set; }
        public string StaffID { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public string AdmissionNo { get; set; }
        public string Status { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
