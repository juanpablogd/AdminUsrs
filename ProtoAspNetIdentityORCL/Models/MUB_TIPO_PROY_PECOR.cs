
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
    
public partial class MUB_TIPO_PROY_PECOR
{

    public MUB_TIPO_PROY_PECOR()
    {

        this.MUB_PROYECTOS_PECOR = new HashSet<MUB_PROYECTOS_PECOR>();

    }


    public long ID_TIPO_PROY_PECOR { get; set; }

    public string NOM_TIPO { get; set; }

    public string ACTIVO { get; set; }



    public virtual ICollection<MUB_PROYECTOS_PECOR> MUB_PROYECTOS_PECOR { get; set; }

}

}