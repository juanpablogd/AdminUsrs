
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace NSPecor.Models
{

using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
public partial class MUB_ESTADO_SUB
{
    [Key]
    public short ID_ESTADO_SUB { get; set; }
    [DisplayName("DESCRIPCIÓN")]
    [Required]
    public string NOM_ESTADO_SUB { get; set; }

    public string ACTIVO { get; set; }

}

}
