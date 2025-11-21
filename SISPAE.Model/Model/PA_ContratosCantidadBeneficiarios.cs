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
     /// Clase Model Base para  PA_ContratosCantidadBeneficiarios
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ContratosCantidadBeneficiariosModelBase : ModelObject
    {
		    public PA_ContratosCantidadBeneficiariosModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CodigoDane 
        /// </Resumen> 
        [Display(Name = "Codigo Dane")]
        public String? CodigoDane{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Matricula 
        /// </Resumen> 
        [Display(Name = "Matricula")] 
        public int? Matricula{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacionesDiaria 
        /// </Resumen> 
        [Display(Name = "Raciones Diaria")] 
        public int? RacionesDiaria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalBeneficiarios 
        /// </Resumen> 
        [Display(Name = "Total Beneficiarios")] 
        public int? TotalBeneficiarios{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        public int? id_Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: insid 
        /// </Resumen> 
        [Display(Name = "insid")] 
        public int? insid{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Sede 
        /// </Resumen> 
        [Display(Name = "Sede")] 
        public int? id_Sede{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





