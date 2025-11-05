/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC ASP Net Core, Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:MODEL (Model Entity Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>


using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SISPAE.Model
{
     /// <Resumen>
     /// Clase Model Base para  PA_AlimentosICBFGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_AlimentosICBFGetAllWithRelationModelBase : ModelObject
    {
		private DateTime _createdFechaRegistro; 
    public PA_AlimentosICBFGetAllWithRelationModelBase() 
    {  
    _createdFechaRegistro= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        public int? id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_SubGrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Sub Grupo Alimentos")] 
        public int? ID_SubGrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoAlimento 
        /// </Resumen> 
        [Display(Name = "Tipo Alimento")] 
        public int? ID_TipoAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoFuenteNutricional 
        /// </Resumen> 
        [Display(Name = "Tipo Fuente Nutricional")] 
        public int? ID_TipoFuenteNutricional{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CodigoICBF 
        /// </Resumen> 
        [Display(Name = "Codigo I C B F")] 
        [DataType (DataType.MultilineText)]   
        public String? CodigoICBF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PathlmagenAlimento 
        /// </Resumen> 
        [Display(Name = "Pathlmagen Alimento")] 
        [DataType (DataType.MultilineText)]   
        public String? PathlmagenAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PathImagenInformacionNutricional 
        /// </Resumen> 
        [Display(Name = "Path Imagen Informacion Nutricional")] 
        [DataType (DataType.MultilineText)]   
        public String? PathImagenInformacionNutricional{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PorcentajeComestible 
        /// </Resumen> 
        [Display(Name = "Porcentaje Comestible")] 
        [DataType (DataType.MultilineText)]   
        public String? PorcentajeComestible{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IntercambioEstandarizado 
        /// </Resumen> 
        [Display(Name = "Intercambio Estandarizado")] 
        [DataType (DataType.MultilineText)]   
        public String? IntercambioEstandarizado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PesoBruto 
        /// </Resumen> 
        [Display(Name = "Peso Bruto")] 
        [DataType (DataType.MultilineText)]   
        public String? PesoBruto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TiposUnidad 
        /// </Resumen> 
        [Display(Name = "Tipos Unidad")] 
        public int? ID_TiposUnidad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoRegistro 
        /// </Resumen> 
        [Display(Name = "Estado Registro")] 
        public int? ID_EstadoRegistro{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaRegistro 
        /// </Resumen> 
        [Display(Name = "Fecha Registro")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistro

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_EstadoRegistro 
        /// </Resumen> 
        [Display(Name = "s Estado Registro")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_EstadoRegistro{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_ETC 
        /// </Resumen> 
        [Display(Name = "s E T C")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_SubGrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "s Sub Grupo Alimentos")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_SubGrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoFuenteNutricional 
        /// </Resumen> 
        [Display(Name = "s Tipo Fuente Nutricional")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoFuenteNutricional{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoAlimento 
        /// </Resumen> 
        [Display(Name = "s Tipo Alimento")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TiposUnidad 
        /// </Resumen> 
        [Display(Name = "s Tipos Unidad")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TiposUnidad{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





