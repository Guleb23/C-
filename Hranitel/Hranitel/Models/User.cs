//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hranitel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Zayavkis = new HashSet<Zayavki>();
        }
    
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public string Passport { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Naznach { get; set; }
        public Nullable<int> Role { get; set; }
    
        public virtual Role Role1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zayavki> Zayavkis { get; set; }
    }
}