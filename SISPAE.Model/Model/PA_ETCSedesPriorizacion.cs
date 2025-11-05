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
     /// Clase Model Base para  PA_ETCSedesPriorizacion
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ETCSedesPriorizacionModelBase : ModelObject
    {
		    public PA_ETCSedesPriorizacionModelBase() 
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
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipios 
        /// </Resumen> 
        [Display(Name = "Total Municipios")] 
        public int? TotalMunicipios{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipios100SedesClas 
        /// </Resumen> 
        [Display(Name = "Total Municipios100 Sedes Clas")] 
        public int? TotalMunicipios100SedesClas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipiosmenos100SedesClas 
        /// </Resumen> 
        [Display(Name = "Total Municipiosmenos100 Sedes Clas")] 
        public int? TotalMunicipiosmenos100SedesClas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMunicipiosCeroSedeClas 
        /// </Resumen> 
        [Display(Name = "Total Municipios Cero Sede Clas")] 
        public int? TotalMunicipiosCeroSedeClas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedes 
        /// </Resumen> 
        [Display(Name = "Total Sedes")] 
        public int? TotalSedes{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedesPriorizadaPAE 
        /// </Resumen> 
        [Display(Name = "Total Sedes Priorizada P A E")] 
        public int? TotalSedesPriorizadaPAE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedesNOPriorizadaPAE 
        /// </Resumen> 
        [Display(Name = "Total Sedes N O Priorizada P A E")] 
        public int? TotalSedesNOPriorizadaPAE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalSedeClasificar 
        /// </Resumen> 
        [Display(Name = "Total Sede Clasificar")] 
        public int? TotalSedeClasificar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalEstudiantes 
        /// </Resumen> 
        [Display(Name = "Total Estudiantes")] 
        public int? TotalEstudiantes{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalEstudiantesSedePriorizadaPAE 
        /// </Resumen> 
        [Display(Name = "Total Estudiantes Sede Priorizada P A E")] 
        public int? TotalEstudiantesSedePriorizadaPAE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalEstudiantesSedeNOPriorizadaPAE 
        /// </Resumen> 
        [Display(Name = "Total Estudiantes Sede N O Priorizada P A E")] 
        public int? TotalEstudiantesSedeNOPriorizadaPAE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalEstudiantesSedesClasificar 
        /// </Resumen> 
        [Display(Name = "Total Estudiantes Sedes Clasificar")] 
        public int? TotalEstudiantesSedesClasificar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMatriMAEM 
        /// </Resumen> 
        [Display(Name = "Total Matri M A E M")] 
        public int? TotalMatriMAEM{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMatriMAER 
        /// </Resumen> 
        [Display(Name = "Total Matri M A E R")] 
        public int? TotalMatriMAER{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMatriMAIP 
        /// </Resumen> 
        [Display(Name = "Total Matri M A I P")] 
        public int? TotalMatriMAIP{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalMatriPAEC 
        /// </Resumen> 
        [Display(Name = "Total Matri P A E C")] 
        public int? TotalMatriPAEC{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





