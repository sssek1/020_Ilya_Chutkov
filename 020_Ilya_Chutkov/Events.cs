//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _020_Ilya_Chutkov
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public int Days { get; set; }
        public int CityId { get; set; }
    
        public virtual City City { get; set; }
    }
}
