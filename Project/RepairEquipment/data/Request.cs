//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepairEquipment.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Comment = new HashSet<Comment>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> IdTech { get; set; }
        public Nullable<int> IdFirmModel { get; set; }
        public Nullable<int> IdColor { get; set; }
        public string ProblemDescryption { get; set; }
        public Nullable<int> IdStatus { get; set; }
        public Nullable<System.DateTime> ComplectionDate { get; set; }
        public string RepairParts { get; set; }
        public Nullable<int> MasterId { get; set; }
        public Nullable<int> ClientId { get; set; }
    
        public virtual Color Color { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual FirmModel FirmModel { get; set; }
        public virtual HomeTech HomeTech { get; set; }
        public virtual User User { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User1 { get; set; }
    }
}