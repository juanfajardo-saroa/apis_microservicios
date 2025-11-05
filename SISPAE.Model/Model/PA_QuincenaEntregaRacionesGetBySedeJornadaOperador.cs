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
     /// Clase Model Base para  PA_QuincenaEntregaRacionesGetBySedeJornadaOperador
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorModelBase : ModelObject
    {
		    public PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idContrato 
        /// </Resumen> 
        [Display(Name = "id Contrato")] 
        public int? idContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroContrato 
        /// </Resumen> 
        [Display(Name = "Numero Contrato")] 
        [DataType (DataType.MultilineText)]   
        public String? NumeroContrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idDivipola 
        /// </Resumen> 
        [Display(Name = "id Divipola")] 
        public int? idDivipola{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: nombreDivipola 
        /// </Resumen> 
        [Display(Name = "nombre Divipola")] 
        [DataType (DataType.MultilineText)]   
        public String? nombreDivipola{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idInstitucionEducativa 
        /// </Resumen> 
        [Display(Name = "id Institucion Educativa")] 
        public int? idInstitucionEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: nombreInstitucionEducativa 
        /// </Resumen> 
        [Display(Name = "nombre Institucion Educativa")] 
        [DataType (DataType.MultilineText)]   
        public String? nombreInstitucionEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idSede 
        /// </Resumen> 
        [Display(Name = "id Sede")] 
        public int? idSede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: nombreSede 
        /// </Resumen> 
        [Display(Name = "nombre Sede")] 
        [DataType (DataType.MultilineText)]   
        public String? nombreSede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        public int? id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idJornada 
        /// </Resumen> 
        [Display(Name = "id Jornada")] 
        public int? idJornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: nombreJornada 
        /// </Resumen> 
        [Display(Name = "nombre Jornada")] 
        [DataType (DataType.MultilineText)]   
        public String? nombreJornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idEstadoQuincena 
        /// </Resumen> 
        [Display(Name = "id Estado Quincena")] 
        public int? idEstadoQuincena{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: nombreEstadoQuincena 
        /// </Resumen> 
        [Display(Name = "nombre Estado Quincena")] 
        [DataType (DataType.MultilineText)]   
        public String? nombreEstadoQuincena{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





