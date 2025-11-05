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
     /// Clase Model Base para  PA_RolPermisosActualiza
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_RolPermisosActualizaModelBase : ModelObject
    {
		    public PA_RolPermisosActualizaModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Estado 
        /// </Resumen> 
        [Display(Name = "Estado")] 
        public Boolean? Estado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Auditoria 
        /// </Resumen> 
        [Display(Name = "Auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? Auditoria{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





