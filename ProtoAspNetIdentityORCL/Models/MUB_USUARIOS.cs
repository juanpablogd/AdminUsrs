
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
    
public partial class MUB_USUARIOS
{

    public MUB_USUARIOS()
    {

        this.MUB_USUARIOS_ROLES = new HashSet<MUB_USUARIOS_ROLES>();

    }


    public long ID_USUARIO { get; set; }

    public string NOMBRE { get; set; }

    public string CARGO { get; set; }

    public string DIRECCION { get; set; }

    public string TELEFONO { get; set; }

    public string CELULAR { get; set; }

    public string EXTENSION { get; set; }

    public string FAX { get; set; }

    public string EMAIL { get; set; }

    public string ESTADO { get; set; }

    public string PWDHASH { get; set; }
        [DisplayName("ORGANIZACIÓN")]
        public Nullable<long> ID_ORGANIZACION { get; set; }



    public virtual ICollection<MUB_USUARIOS_ROLES> MUB_USUARIOS_ROLES { get; set; }

    public virtual MUB_ORGANIZACIONES MUB_ORGANIZACIONES { get; set; }

}

}
