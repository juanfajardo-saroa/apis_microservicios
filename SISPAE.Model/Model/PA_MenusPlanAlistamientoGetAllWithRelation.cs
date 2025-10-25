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
     /// Clase Model Base para  PA_MenusPlanAlistamientoGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_MenusPlanAlistamientoGetAllWithRelationModelBase : ModelObject
    {
		    public PA_MenusPlanAlistamientoGetAllWithRelationModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoValidacion 
        /// </Resumen> 
        [Display(Name = "Estado Validacion")] 
        public int? ID_EstadoValidacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_UsuarioEntidad 
        /// </Resumen> 
        [Display(Name = "Usuario Entidad")] 
        public int? ID_UsuarioEntidad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_CiclosMenu 
        /// </Resumen> 
        [Display(Name = "Ciclos Menu")] 
        public int? ID_CiclosMenu{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_PlanesAlistamiento 
        /// </Resumen> 
        [Display(Name = "Planes Alistamiento")] 
        public int? ID_PlanesAlistamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoModalidadComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Modalidad Complemento")] 
        public int? ID_TipoModalidadComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        public int? ID_NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Complemento")] 
        public int? ID_TipoComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Jornada 
        /// </Resumen> 
        [Display(Name = "Jornada")] 
        public int? ID_Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Modelo Operacion")] 
        public int? ID_ModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumeroMenu 
        /// </Resumen> 
        [Display(Name = "Numero Menu")] 
        public int? NumeroMenu{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_CiclosMenu 
        /// </Resumen> 
        [Display(Name = "s Ciclos Menu")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_CiclosMenu{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_EstadoValidacion 
        /// </Resumen> 
        [Display(Name = "s Estado Validacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_EstadoValidacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_NivelEducativo 
        /// </Resumen> 
        [Display(Name = "s Nivel Educativo")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoModalidadComplemento 
        /// </Resumen> 
        [Display(Name = "s Tipo Modalidad Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoModalidadComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "s Tipo Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_UsuarioEntidad 
        /// </Resumen> 
        [Display(Name = "s Usuario Entidad")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_UsuarioEntidad{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





