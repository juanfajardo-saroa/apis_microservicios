/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
/// Ano			    :2022
/// Arquitectura	:Patron MVC ASP Net Core, Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
/// Capa			:MODEL (Model Entity Layer) - Capa Model (Source: MVC7_DAL_ModelBase.CS)  Partial Interface 
/// </Derechos_Reservados>


using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SISPAE.Model
{
     /// <Resumen>
     /// Clase Model Base para  PA_BuscarProductosPTN
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_BuscarProductosPTNModelBase : ModelObject
    {
		private DateTime _createdFechaRegistroProducto; 
    public PA_BuscarProductosPTNModelBase() 
    {  
    _createdFechaRegistroProducto= DateTime.MinValue; 
    }  
        

		

                 ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    
             ///    
 
            ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
///  Estas son las propiedades Base de esta clase  
             ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Producto 
        /// </Resumen> 
        [Display(Name = "Producto")] 
        public int? ID_Producto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Producto 
        /// </Resumen> 
        [Display(Name = "Producto")] 
        [DataType (DataType.MultilineText)]   
        public String Producto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_GrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Grupo Alimentos")] 
        public int? ID_GrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Grupo Alimentos")] 
        [DataType (DataType.MultilineText)]   
        public String GrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_SubGrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Sub Grupo Alimentos")] 
        public int? ID_SubGrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SubGrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Sub Grupo Alimentos")] 
        public int? SubGrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaRegistroProducto 
        /// </Resumen> 
        [Display(Name = "Fecha Registro Producto")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaRegistroProducto

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoRegistro 
        /// </Resumen> 
        [Display(Name = "Estado Registro")] 
        public int? ID_EstadoRegistro{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoRegistro 
        /// </Resumen> 
        [Display(Name = "Estado Registro")] 
        [DataType (DataType.MultilineText)]   
        public String EstadoRegistro{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoProducto 
        /// </Resumen> 
        [Display(Name = "Tipo Producto")] 
        public int? ID_TipoProducto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoProducto 
        /// </Resumen> 
        [Display(Name = "Tipo Producto")] 
        [DataType (DataType.MultilineText)]   
        public String TipoProducto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorEstado 
        /// </Resumen> 
        [Display(Name = "Color Estado")] 
        [DataType (DataType.MultilineText)]   
        public String ColorEstado{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    
///    


    }
}





