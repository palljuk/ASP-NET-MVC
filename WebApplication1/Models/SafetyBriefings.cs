//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SafetyBriefings
    {
        public int Id_SafetyBriefing { get; set; }
        public string CustomerName { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<System.DateTime> BriefingGivenOn { get; set; }
        public string PersonGivingBriefing { get; set; }
        public string AdditionalDetails { get; set; }
        public byte[] PdfFileData { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
    }
}
