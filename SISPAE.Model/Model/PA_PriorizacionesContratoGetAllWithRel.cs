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
     /// Clase Model Base para  PA_PriorizacionesContratoGetAllWithRel
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_PriorizacionesContratoGetAllWithRelModelBase : ModelObject
    {
		    public PA_PriorizacionesContratoGetAllWithRelModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        public int? id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Contrato 
        /// </Resumen> 
        [Display(Name = "Contrato")] 
        public int? ID_Contrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_GradoSedeJornada 
        /// </Resumen> 
        [Display(Name = "Grado Sede Jornada")] 
        public int? ID_GradoSedeJornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoModelooperacion 
        /// </Resumen> 
        [Display(Name = "Tipo Modelooperacion")] 
        public int? ID_TipoModelooperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoModalidadRacion 
        /// </Resumen> 
        [Display(Name = "Tipo Modalidad Racion")] 
        public int? ID_TipoModalidadRacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoRacion 
        /// </Resumen> 
        [Display(Name = "Tipo Racion")] 
        public int? ID_TipoRacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroRaciones 
        /// </Resumen> 
        [Display(Name = "Numero Raciones")] 
        public int? NumeroRaciones{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TiposRacion 
        /// </Resumen> 
        [Display(Name = "s Tipos Racion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TiposRacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Contratos 
        /// </Resumen> 
        [Display(Name = "s Contratos")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Contratos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TiposModeloOperacion 
        /// </Resumen> 
        [Display(Name = "s Tipos Modelo Operacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TiposModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TiposModalidadRacion 
        /// </Resumen> 
        [Display(Name = "s Tipos Modalidad Racion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TiposModalidadRacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Grado 
        /// </Resumen> 
        [Display(Name = "s Grado")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Grado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_jornada 
        /// </Resumen> 
        [Display(Name = "sjornada")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_jornada{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





