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
     /// Clase Model Base para  PA_PrioSedeInformacion
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_PrioSedeInformacionModelBase : ModelObject
    {
		    public PA_PrioSedeInformacionModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_sede 
        /// </Resumen> 
        [Display(Name = "sede")] 
        public int? Id_sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOperativo 
        /// </Resumen> 
        [Display(Name = "Modelo Operativo")] 
        [DataType (DataType.MultilineText)]   
        public String? ModeloOperativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PoblacionVul 
        /// </Resumen> 
        [Display(Name = "Poblacion Vul")] 
        public Decimal? PoblacionVul{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoMunicipio 
        /// </Resumen> 
        [Display(Name = "Tipo Municipio")] 
        [DataType (DataType.MultilineText)]   
        public String? TipoMunicipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModalidaSugerida 
        /// </Resumen> 
        [Display(Name = "Modalida Sugerida")] 
        [DataType (DataType.MultilineText)]   
        public String? ModalidaSugerida{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoAsignacion 
        /// </Resumen> 
        [Display(Name = "Estado Asignacion")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoAsignacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstudianteSisbenAB 
        /// </Resumen> 
        [Display(Name = "Estudiante Sisben A B")] 
        public Decimal? EstudianteSisbenAB{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoModeloOperativo 
        /// </Resumen> 
        [Display(Name = "Tipo Modelo Operativo")] 
        public int? id_TipoModeloOperativo{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





