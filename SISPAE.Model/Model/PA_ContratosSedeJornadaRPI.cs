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
     /// Clase Model Base para  PA_ContratosSedeJornadaRPI
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ContratosSedeJornadaRPIModelBase : ModelObject
    {
		    public PA_ContratosSedeJornadaRPIModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_sede 
        /// </Resumen> 
        [Display(Name = "sede")] 
        public int? id_sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Jornada 
        /// </Resumen> 
        [Display(Name = "Jornada")] 
        [DataType (DataType.MultilineText)]   
        public String? Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Grado 
        /// </Resumen> 
        [Display(Name = "Grado")] 
        [DataType (DataType.MultilineText)]   
        public String? Grado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: AlmuerzoRPS 
        /// </Resumen> 
        [Display(Name = "Almuerzo R P S")] 
        public int? AlmuerzoRPS{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CompleRPS 
        /// </Resumen> 
        [Display(Name = "Comple R P S")] 
        public int? CompleRPS{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalRacionesDia 
        /// </Resumen> 
        [Display(Name = "Total Raciones Dia")] 
        public int? TotalRacionesDia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalBeneficiarios 
        /// </Resumen> 
        [Display(Name = "Total Beneficiarios")] 
        public int? TotalBeneficiarios{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Matricula 
        /// </Resumen> 
        [Display(Name = "Matricula")] 
        public int? Matricula{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





