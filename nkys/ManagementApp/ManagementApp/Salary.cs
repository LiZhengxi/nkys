//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Salary()
        {
            this.ExternalFee = new HashSet<ExternalFee>();
        }
    
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public double DayWorkingTime { get; set; }
        public double NightWorkingTime { get; set; }
        public double HolidayWorkingTime { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<double> FixSalary { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalFee> ExternalFee { get; set; }
    }
}