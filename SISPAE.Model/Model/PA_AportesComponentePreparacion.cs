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
	/// Clase Model Base para  PA_AportesComponentePreparacion
	/// No haga cambios sobre esta clase,
	/// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
	/// esta es una clase abstracta que decora la clase principal
	/// </Resumen>


	public class PA_AportesComponentePreparacionModelBase : ModelObject
	{
		public PA_AportesComponentePreparacionModelBase()
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
		/// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoComponnete 
		/// </Resumen> 
		[Display(Name = "Tipo Componente")]
		public int? ID_TipoComponente { get; set; }

		/// <Resumen>  
		/// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Componente 
		/// </Resumen> 
		[Display(Name = "Componente")]
		[DataType(DataType.MultilineText)]
		public String? Componente { get; set; }

		/// <Resumen>  
		/// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PesoNeto 
		/// </Resumen> 
		[Display(Name = "Peso Neto")]
		public Double? PesoNeto { get; set; }

		/// <Resumen>  
		/// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoModeloOperacion 
		/// </Resumen> 
		[Display(Name = "Tipo Modelo Operacion")]
		public int? ID_TipoModeloOperacion { get; set; }

		/// <Resumen>  
		/// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Complemento 
		/// </Resumen> 
		[Display(Name = "Complemento")]
		public int? ID_Complemento { get; set; }

		/// <Resumen>  
		/// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoNivelEducativo 
		/// </Resumen> 
		[Display(Name = "Tipo Nivel Educativo")]
		public int? ID_TipoNivelEducativo { get; set; }

		public String? filtro { get; set; }
		#endregion Public Members    



	}
}





