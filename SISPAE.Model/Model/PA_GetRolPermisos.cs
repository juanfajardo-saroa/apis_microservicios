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
     /// Clase Model Base para  PA_GetRolPermisos
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_GetRolPermisosModelBase : ModelObject
    {
		    public PA_GetRolPermisosModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        public int? Id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Rol 
        /// </Resumen> 
        [Display(Name = "Rol")] 
        [DataType (DataType.MultilineText)]   
        public String? Id_Rol{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Modulo 
        /// </Resumen> 
        [Display(Name = "Modulo")] 
        public int? Id_Modulo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Modulo 
        /// </Resumen> 
        [Display(Name = "Modulo")] 
        [DataType (DataType.MultilineText)]   
        public String? Modulo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Sistema 
        /// </Resumen> 
        [Display(Name = "Sistema")] 
        public int? Id_Sistema{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Sistema 
        /// </Resumen> 
        [Display(Name = "Sistema")] 
        [DataType (DataType.MultilineText)]   
        public String? Sistema{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Ver 
        /// </Resumen> 
        [Display(Name = "Ver")] 
        public Boolean? Ver{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Crear 
        /// </Resumen> 
        [Display(Name = "Crear")] 
        public Boolean? Crear{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Editar 
        /// </Resumen> 
        [Display(Name = "Editar")] 
        public Boolean? Editar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Eliminar 
        /// </Resumen> 
        [Display(Name = "Eliminar")] 
        public Boolean? Eliminar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Aprobar 
        /// </Resumen> 
        [Display(Name = "Aprobar")] 
        public Boolean? Aprobar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Imprimir 
        /// </Resumen> 
        [Display(Name = "Imprimir")] 
        public Boolean? Imprimir{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Rol 
        /// </Resumen> 
        [Display(Name = "Rol")] 
        [DataType (DataType.MultilineText)]   
        public String? Rol{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





