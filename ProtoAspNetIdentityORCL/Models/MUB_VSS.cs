
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
    
public partial class MUB_VSS
{

    public long ID_VSS { get; set; }

    public Nullable<decimal> VIGENCIA { get; set; }

    public Nullable<decimal> V_TOTAL { get; set; }

    public Nullable<decimal> V_URBANO { get; set; }

    public Nullable<decimal> V_RURAL { get; set; }

    public Nullable<decimal> VSS_TOTAL { get; set; }

    public Nullable<decimal> VSS_URBANO { get; set; }

    public Nullable<decimal> VSS_RURAL { get; set; }

    public Nullable<System.DateTime> FECHA_ACTUALIZACION { get; set; }

    public Nullable<decimal> ID_USUARIO_ACTUALIZACION { get; set; }

    public Nullable<System.DateTime> FECHA_REGISTRO { get; set; }

    public Nullable<decimal> ID_USUARIO_REGISTRO { get; set; }

    public string OBSERVACION { get; set; }

    public Nullable<int> ID_CENTRO_POBLADO { get; set; }

    public string COD_UPME { get; set; }



    public virtual BC_DP_SITIOS_UPME BC_DP_SITIOS_UPME { get; set; }

}

}