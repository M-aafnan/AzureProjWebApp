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
    
    public partial class MarksEntry
    {
        public int M_ID { get; set; }
        public string AdmissionNo { get; set; }
        public string StudentSchool { get; set; }
        public string Session { get; set; }
        public string StudentClass { get; set; }
        public string StudentSection { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string Result { get; set; }
    }
}