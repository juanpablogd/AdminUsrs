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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;
    public partial class MUB_PROYECTOS_PECOR
    {
        public MUB_PROYECTOS_PECOR()
        {
            this.MUB_PECOR_CP_VSS = new HashSet<MUB_PECOR_CP_VSS>();
        }
        [Key]
        public long ID_PROYECTO_PECOR { get; set; }
        [DisplayName("ORGANIZACI�N")]
        public Nullable<long> ID_ORGANIZACION { get; set; }
        [DisplayName("CLASIFICACI�N")]
        [Required]
        public string PROG_PROY { get; set; }
        [DisplayName("CODIGO UPME")]
        public string CODIGO_UPME { get; set; }
        public string NOMBRE { get; set; }
        [DisplayName("TIPO")]
        public long ID_TIPO_PROY_PECOR { get; set; }
        [DisplayName("CLASE")]
        public long ID_CLASE { get; set; }
        [DisplayName("REALIZAR� PROYECTO?")]
        public string REALIZARA_PROYECTO { get; set; }
        [DisplayName("ADMINISTRAR� PROYECTO?")]
        public string ADMIN_PROYECTO { get; set; }
        [DisplayName("FINANCIA ACOMETIDA")]
        public string FINANCIA_ACOMETIDA { get; set; }
        [DisplayName("FECHA INICIO EJECUCI�N")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> INI_EJEC_INV { get; set; }
        [DisplayName("FECHA FINAL EJECUCI�N")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FIN_EJE_INV { get; set; }
        [DisplayName("FECHA PUESTA EN MARCHA")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> PUESTA_MARCHA { get; set; }
        [DisplayName("DEMANDA ANUAL")]
        public Nullable<long> DEMANDA_ANUAL { get; set; }
        [DisplayName("N� VIVIENDAS BENEFICIADAS")]
        public Nullable<long> V_BENEFICIA { get; set; }
        [DisplayName("CIRCUITO CONEXI�N")]
        public string CIRCUITO { get; set; }
        [DisplayName("NIVEL TENSI�N")]
        public Nullable<long> NIVEL_TENSION { get; set; }
        [DisplayName("RED MT (Km)")]
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> RED_MT_KM { get; set; }
        [DisplayName("RED BT (Km)")]
        [DisplayFormat(DataFormatString = "{0:F3}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> RED_BT_KM { get; set; }
        [DisplayName("N� TRANSFORMADORES")]
        public Nullable<long> NUM_TRANSFORMADORES { get; set; }
        [DisplayName("AOM N1")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> AOM_N1 { get; set; }
        [DisplayName("AOM COSTO MEDIO N1")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> COSTO_MEDIO_N1 { get; set; }
        [DisplayName("AOM INVERSI�N N1")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> INVERSION_N1 { get; set; }
        [DisplayName("AOM N2")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> AOM_N2 { get; set; }
        [DisplayName("AOM COSTO MEDIO N2")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> COSTO_MEDIO_N2 { get; set; }
        [DisplayName("AOM INVERSI�N N2")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> INVERSION_N2 { get; set; }
        [DisplayName("AOM N3")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> AOM_N3 { get; set; }
        [DisplayName("AOM COSTO MEDIO N3")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> COSTO_MEDIO_N3 { get; set; }
        [DisplayName("AOM INVERSI�N N3")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> INVERSION_N3 { get; set; }
        [DisplayName("CU MODIFICADO $KW/h")]
        [DisplayFormat(DataFormatString = "{0:F4}", ApplyFormatInEditMode = true)]
        public Nullable<decimal> CU_MODIFICADO { get; set; }
        public Nullable<decimal> ID_USUARIO_REGISITRO { get; set; }
        public Nullable<System.DateTime> FECHA_REGISTRO { get; set; }
        public Nullable<decimal> ID_SUBESTACION { get; set; }

        public Nullable<decimal> ID_PLAN { get; set; }
    
        public virtual MUB_CLASE_CP MUB_CLASE_CP { get; set; }
        public virtual MUB_ORGANIZACIONES MUB_ORGANIZACIONES { get; set; }
        public virtual MUB_TIPO_PROY_PECOR MUB_TIPO_PROY_PECOR { get; set; }
        public virtual ICollection<MUB_PECOR_CP_VSS> MUB_PECOR_CP_VSS { get; set; }
        public virtual VISTA_SUBESTACION VISTA_SUBESTACION { get; set; }
        public virtual MUB_PECOR_PLAN MUB_PECOR_PLAN { get; set; }
    }
}