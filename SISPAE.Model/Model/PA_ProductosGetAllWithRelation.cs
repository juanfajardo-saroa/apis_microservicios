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
     /// Clase Model Base para  PA_ProductosGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ProductosGetAllWithRelationModelBase : ModelObject
    {
		private DateTime _createdFechaRegistro; 
    public PA_ProductosGetAllWithRelationModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TiposAlimentos 
        /// </Resumen> 
        [Display(Name = "Tipos Alimentos")] 
        public int? ID_TiposAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TiposUnidad 
        /// </Resumen> 
        [Display(Name = "Tipos Unidad")] 
        public int? ID_TiposUnidad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_RegistroINVIMA 
        /// </Resumen> 
        [Display(Name = "Registro I N V I M A")] 
        public int? ID_RegistroINVIMA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroRegistroInvima 
        /// </Resumen> 
        [Display(Name = "Numero Registro Invima")] 
        [DataType (DataType.MultilineText)]   
        public String? NumeroRegistroInvima{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PathlmagenProducto 
        /// </Resumen> 
        [Display(Name = "Pathlmagen Producto")] 
        [DataType (DataType.MultilineText)]   
        public String? PathlmagenProducto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PathlmagenRegistroSanitario 
        /// </Resumen> 
        [Display(Name = "Pathlmagen Registro Sanitario")] 
        [DataType (DataType.MultilineText)]   
        public String? PathlmagenRegistroSanitario{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: BaseFruta 
        /// </Resumen> 
        [Display(Name = "Base Fruta")] 
        [DataType (DataType.MultilineText)]   
        public String? BaseFruta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PathImagenInformacionNutricional 
        /// </Resumen> 
        [Display(Name = "Path Imagen Informacion Nutricional")] 
        [DataType (DataType.MultilineText)]   
        public String? PathImagenInformacionNutricional{ get; set; }

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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TiposAlimentos 
        /// </Resumen> 
        [Display(Name = "s Tipos Alimentos")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TiposAlimentos{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





