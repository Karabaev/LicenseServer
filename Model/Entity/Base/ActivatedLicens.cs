//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Entity.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivatedLicens
    {
        public int ID { get; set; }
        public int LicenseID { get; set; }
        public System.DateTime ActivationDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public int DeviceID { get; set; }
    
        public virtual Device Device { get; set; }
        public virtual License License { get; set; }
    }
}