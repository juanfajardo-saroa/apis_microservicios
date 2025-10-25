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
     /// Clase Model Base para  PA_ContratosIE
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ContratosIEModelBase : ModelObject
    {
		private DateTime _createdFechalnicioContrato; 
private DateTime _createdFechaFinalContrato; 
    public PA_ContratosIEModelBase() 
    {  
    _createdFechalnicioContrato= DateTime.MinValue; 
    _createdFechaFinalContrato= DateTime.MinValue; 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoContratoCHIP 
        /// </Resumen> 
        [Display(Name = "Tipo Contrato C H I P")] 
        public int? ID_TipoContratoCHIP{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoConceptoGasto 
        /// </Resumen> 
        [Display(Name = "Tipo Concepto Gasto")] 
        public int? ID_TipoConceptoGasto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ET 
        /// </Resumen> 
        [Display(Name = "E T")] 
        public int? ID_ET{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_MinutaPatronAlimento 
        /// </Resumen> 
        [Display(Name = "Minuta Patron Alimento")] 
        public int? ID_MinutaPatronAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Operador 
        /// </Resumen> 
        [Display(Name = "Operador")] 
        public int? ID_Operador{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoCategoriaContrato 
        /// </Resumen> 
        [Display(Name = "Tipo Categoria Contrato")] 
        public int? ID_TipoCategoriaContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoContrato 
        /// </Resumen> 
        [Display(Name = "Estado Contrato")] 
        public int? ID_EstadoContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_UTConsorcio 
        /// </Resumen> 
        [Display(Name = "U T Consorcio")] 
        public int? ID_UTConsorcio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_PlanAlistamiento 
        /// </Resumen> 
        [Display(Name = "Plan Alistamiento")] 
        public int? ID_PlanAlistamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Vigencia 
        /// </Resumen> 
        [Display(Name = "Vigencia")] 
        public int? ID_Vigencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroContrato 
        /// </Resumen> 
        [Display(Name = "Numero Contrato")] 
        [DataType (DataType.MultilineText)]   
        public String? NumeroContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ObjetoContrato 
        /// </Resumen> 
        [Display(Name = "Objeto Contrato")] 
        [DataType (DataType.MultilineText)]   
        public String? ObjetoContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ConAnticipo 
        /// </Resumen> 
        [Display(Name = "Con Anticipo")] 
        public Boolean? ConAnticipo{ get; set; }

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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaFinalContrato 
        /// </Resumen> 
        [Display(Name = "Fecha Final Contrato")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaFinalContrato

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Estado 
        /// </Resumen> 
        [Display(Name = "Estado")] 
        public Boolean? Estado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ValorTotalContrato 
        /// </Resumen> 
        [Display(Name = "Valor Total Contrato")] 
        public Double? ValorTotalContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoContratoId 
        /// </Resumen> 
        [Display(Name = "Tipo Contrato Id")] 
        public int? TipoContratoId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SubTipoContratoId 
        /// </Resumen> 
        [Display(Name = "Sub Tipo Contrato Id")] 
        public int? SubTipoContratoId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SuministroDesentralizadoId 
        /// </Resumen> 
        [Display(Name = "Suministro Desentralizado Id")] 
        public int? SuministroDesentralizadoId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Tipo Modelo Operacion")] 
        public int? ID_TipoModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ManejaPAEC 
        /// </Resumen> 
        [Display(Name = "Maneja P A E C")] 
        public Boolean? ManejaPAEC{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





