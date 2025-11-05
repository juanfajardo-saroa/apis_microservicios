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
     /// Clase Model Base para  PA_ContratosSedeJornadaBeneficiarios
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ContratosSedeJornadaBeneficiariosModelBase : ModelObject
    {
		    public PA_ContratosSedeJornadaBeneficiariosModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        [DataType (DataType.MultilineText)]   
        public String? Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: InstitucionEdu 
        /// </Resumen> 
        [Display(Name = "Institucion Edu")] 
        [DataType (DataType.MultilineText)]   
        public String? InstitucionEdu{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SedeEducativa 
        /// </Resumen> 
        [Display(Name = "Sede Educativa")] 
        [DataType (DataType.MultilineText)]   
        public String? SedeEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Jornada 
        /// </Resumen> 
        [Display(Name = "Jornada")] 
        [DataType (DataType.MultilineText)]   
        public String? Jornada{ get; set; }

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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CompleRI 
        /// </Resumen> 
        [Display(Name = "Comple R I")] 
        public int? CompleRI{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: AlmuerzoCatering 
        /// </Resumen> 
        [Display(Name = "Almuerzo Catering")] 
        public int? AlmuerzoCatering{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CompCatering 
        /// </Resumen> 
        [Display(Name = "Comp Catering")] 
        public int? CompCatering{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalRacionesDia 
        /// </Resumen> 
        [Display(Name = "Total Raciones Dia")] 
        public int? TotalRacionesDia{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





