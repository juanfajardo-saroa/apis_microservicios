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
     /// Clase Model Base para  PA_PreparacionesGestion
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_PreparacionesGestionModelBase : ModelObject
    {
		private DateTime _createdFechaPreparacion; 
    public PA_PreparacionesGestionModelBase() 
    {  
    _createdFechaPreparacion= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Preparacion 
        /// </Resumen> 
        [Display(Name = "Preparacion")] 
        public int? ID_Preparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombrePreparacion 
        /// </Resumen> 
        [Display(Name = "Nombre Preparacion")] 
        [DataType (DataType.MultilineText)]   
        public String NombrePreparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaPreparacion 
        /// </Resumen> 
        [Display(Name = "Fecha Preparacion")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaPreparacion

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_GrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Grupo Alimentos")] 
        public int? ID_GrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_SubgrupoAlimentos 
        /// </Resumen> 
        [Display(Name = "Subgrupo Alimentos")] 
        public int? ID_SubgrupoAlimentos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoPreparacion 
        /// </Resumen> 
        [Display(Name = "Tipo Preparacion")] 
        public int? ID_TipoPreparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Modelo Operacion")] 
        public int? ID_ModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoPreparacion 
        /// </Resumen> 
        [Display(Name = "Tipo Preparacion")] 
        [DataType (DataType.MultilineText)]   
        public String TipoPreparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Modelo Operacion")] 
        [DataType (DataType.MultilineText)]   
        public String ModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoPreparacion 
        /// </Resumen> 
        [Display(Name = "Estado Preparacion")] 
        public int? ID_EstadoPreparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorEstadoPreparacion 
        /// </Resumen> 
        [Display(Name = "Color Estado Preparacion")] 
        [DataType (DataType.MultilineText)]   
        public String ColorEstadoPreparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoPreparacion 
        /// </Resumen> 
        [Display(Name = "Estado Preparacion")] 
        [DataType (DataType.MultilineText)]   
        public String EstadoPreparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementosAplica 
        /// </Resumen> 
        [Display(Name = "Complementos Aplica")] 
        [DataType (DataType.MultilineText)]   
        public String ComplementosAplica{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





