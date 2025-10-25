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
     /// Clase Model Base para  PA_CiclosMenusGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_CiclosMenusGetAllWithRelationModelBase : ModelObject
    {
		    public PA_CiclosMenusGetAllWithRelationModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Tipo Modelo Operacion")] 
        public int? ID_TipoModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Complemento")] 
        public int? ID_TipoComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoModalidadComplemento 
        /// </Resumen> 
        [Display(Name = "Tipo Modalidad Complemento")] 
        public int? ID_TipoModalidadComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_CiclosMenuReferencia 
        /// </Resumen> 
        [Display(Name = "Ciclos Menu Referencia")] 
        public int? ID_CiclosMenuReferencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoNivelEducativo 
        /// </Resumen> 
        [Display(Name = "Tipo Nivel Educativo")] 
        public int? ID_TipoNivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Zona 
        /// </Resumen> 
        [Display(Name = "Zona")] 
        public int? ID_Zona{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_EstadoRegistro 
        /// </Resumen> 
        [Display(Name = "Estado Registro")] 
        public int? ID_EstadoRegistro{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MenuReferencia 
        /// </Resumen> 
        [Display(Name = "Menu Referencia")] 
        public Boolean? MenuReferencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MenusParaTodosNiveles 
        /// </Resumen> 
        [Display(Name = "Menus Para Todos Niveles")] 
        public Boolean? MenusParaTodosNiveles{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MenusParaTodasZonas 
        /// </Resumen> 
        [Display(Name = "Menus Para Todas Zonas")] 
        public Boolean? MenusParaTodasZonas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantidadMenus 
        /// </Resumen> 
        [Display(Name = "Cantidad Menus")] 
        [DataType (DataType.MultilineText)]   
        public String? CantidadMenus{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_MinutaAprobacion 
        /// </Resumen> 
        [Display(Name = "Minuta Aprobacion")] 
        public int? ID_MinutaAprobacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_EstadoRegistro 
        /// </Resumen> 
        [Display(Name = "s Estado Registro")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_EstadoRegistro{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_ETC 
        /// </Resumen> 
        [Display(Name = "s E T C")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_MinutaAprobacion 
        /// </Resumen> 
        [Display(Name = "s Minuta Aprobacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_MinutaAprobacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoComplemento 
        /// </Resumen> 
        [Display(Name = "s Tipo Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoModalidadComplemento 
        /// </Resumen> 
        [Display(Name = "s Tipo Modalidad Complemento")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoModalidadComplemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_TipoModeloOperacion 
        /// </Resumen> 
        [Display(Name = "s Tipo Modelo Operacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_TipoModeloOperacion{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





