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
     /// Clase Model Base para  PA_ContratosPlanAlistamientoGetAll
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ContratosPlanAlistamientoGetAllModelBase : ModelObject
    {
		private DateTime _createdFechalnicioContrato; 
    public PA_ContratosPlanAlistamientoGetAllModelBase() 
    {  
    _createdFechalnicioContrato= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ContratoId 
        /// </Resumen> 
        [Display(Name = "Contrato Id")] 
        public int? ContratoId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroContrato 
        /// </Resumen> 
        [Display(Name = "Numero Contrato")] 
        [DataType (DataType.MultilineText)]   
        public String? NumeroContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreRazonSocial 
        /// </Resumen> 
        [Display(Name = "Nombre Razon Social")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreRazonSocial{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Modelo Operacion")] 
        [DataType (DataType.MultilineText)]   
        public String? ModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechalnicioContrato 
        /// </Resumen> 
        [Display(Name = "Fechalnicio Contrato")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechalnicioContrato

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoBodegas 
        /// </Resumen> 
        [Display(Name = "Estado Bodegas")] 
        public int? ID_EstadoBodegas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoMenus 
        /// </Resumen> 
        [Display(Name = "Estado Menus")] 
        public int? ID_EstadoMenus{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoRutas 
        /// </Resumen> 
        [Display(Name = "Estado Rutas")] 
        public int? ID_EstadoRutas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoDocumentacion 
        /// </Resumen> 
        [Display(Name = "Estado Documentacion")] 
        public int? ID_EstadoDocumentacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoEstadoAlistamiento 
        /// </Resumen> 
        [Display(Name = "Tipo Estado Alistamiento")] 
        public int? ID_TipoEstadoAlistamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PlazoRestante 
        /// </Resumen> 
        [Display(Name = "Plazo Restante")] 
        public int? PlazoRestante{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoBodegas 
        /// </Resumen> 
        [Display(Name = "Estado Bodegas")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoBodegas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoMenus 
        /// </Resumen> 
        [Display(Name = "Estado Menus")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoMenus{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoRutas 
        /// </Resumen> 
        [Display(Name = "Estado Rutas")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoRutas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoDocumentacion 
        /// </Resumen> 
        [Display(Name = "Estado Documentacion")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoDocumentacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoEstadoAlistamiento 
        /// </Resumen> 
        [Display(Name = "Tipo Estado Alistamiento")] 
        [DataType (DataType.MultilineText)]   
        public String? TipoEstadoAlistamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_PlanAlistamiento 
        /// </Resumen> 
        [Display(Name = "Plan Alistamiento")] 
        public int? ID_PlanAlistamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TMO1_Jornada 
        /// </Resumen> 
        [Display(Name = "T M O1 Jornada")] 
        [DataType (DataType.MultilineText)]   
        public String? TMO1_Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TMO2_Jornada 
        /// </Resumen> 
        [Display(Name = "T M O2 Jornada")] 
        [DataType (DataType.MultilineText)]   
        public String? TMO2_Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TMO3_Jornada 
        /// </Resumen> 
        [Display(Name = "T M O3 Jornada")] 
        [DataType (DataType.MultilineText)]   
        public String? TMO3_Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        public int? ID_NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        [DataType (DataType.MultilineText)]   
        public String? NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoModalidadComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Modalidad Complemento")] 
        public int? id_TipoModalidadComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoModalidadRacion 
        /// </Resumen> 
        [Display(Name = "Tipo Modalidad Racion")] 
        [DataType (DataType.MultilineText)]   
        public String? TipoModalidadComplemento { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Complemento")] 
        public int? id_TipoComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? TipoComplemento{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





