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
     /// Clase Model Base para  PA_ETCMunicipioRacion
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ETCMunicipioRacionModelBase : ModelObject
    {
		    public PA_ETCMunicipioRacionModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? id_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre  
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipiosBeneficiarios 
        /// </Resumen> 
        [Display(Name = "Total Municipios Beneficiarios")] 
        public int? TotalMunicipiosBeneficiarios{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipios100Sedes 
        /// </Resumen> 
        [Display(Name = "Total Municipios100 Sedes")] 
        public int? TotalMunicipios100Sedes{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipiosmenos100Sedes 
        /// </Resumen> 
        [Display(Name = "Total Municipiosmenos100 Sedes")] 
        public int? TotalMunicipiosmenos100Sedes{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipiosNingunaSede 
        /// </Resumen> 
        [Display(Name = "Total Municipios Ninguna Sede")] 
        public int? TotalMunicipiosNingunaSede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedesBeneficiarias 
        /// </Resumen> 
        [Display(Name = "Total Sedes Beneficiarias")] 
        public int? TotalSedesBeneficiarias{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedesRacionCompleta 
        /// </Resumen> 
        [Display(Name = "Total Sedes Racion Completa")] 
        public int? TotalSedesRacionCompleta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedesRacionIncompleta 
        /// </Resumen> 
        [Display(Name = "Total Sedes Racion Incompleta")] 
        public int? TotalSedesRacionIncompleta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedespendientes 
        /// </Resumen> 
        [Display(Name = "Total Sedespendientes")] 
        public int? TotalSedespendientes{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





