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
     /// Clase Model Base para  PA_OperadorContratos
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_OperadorContratosModelBase : ModelObject
    {
		    public PA_OperadorContratosModelBase() 
    {  
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_contrato 
        /// </Resumen> 
        [Display(Name = "contrato")] 
        public int? id_contrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroContrato 
        /// </Resumen> 
        [Display(Name = "Numero Contrato")] 
        [DataType (DataType.MultilineText)]   
        public String? NumeroContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ETC_Nombre 
        /// </Resumen> 
        [Display(Name = "E Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? ETC_Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        [DataType (DataType.MultilineText)]   
        public String? Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoContrato 
        /// </Resumen> 
        [Display(Name = "Tipo Contrato")] 
        [DataType (DataType.MultilineText)]   
        public String? TipoContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOper 
        /// </Resumen> 
        [Display(Name = "Modelo Oper")] 
        [DataType (DataType.MultilineText)]   
        public String? ModeloOper{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Operador 
        /// </Resumen> 
        [Display(Name = "Operador")] 
        [DataType (DataType.MultilineText)]   
        public String? Operador{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





