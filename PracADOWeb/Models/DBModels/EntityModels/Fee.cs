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
    
    public partial class Fee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fee()
        {
            this.CourseFees = new HashSet<CourseFee>();
        }
    
        public int Id { get; set; }
        public string Feename { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseFee> CourseFees { get; set; }
    }
}
