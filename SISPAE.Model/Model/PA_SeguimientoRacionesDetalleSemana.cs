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
     /// Clase Model Base para  PA_SeguimientoRacionesDetalleSemana
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_SeguimientoRacionesDetalleSemanaModelBase : ModelObject
    {
		private DateTime _createdFecha_inicial; 
private DateTime _createdFecha_final; 
    public PA_SeguimientoRacionesDetalleSemanaModelBase() 
    {  
    _createdFecha_inicial= DateTime.MinValue; 
    _createdFecha_final= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Numero_semana 
        /// </Resumen> 
        [Display(Name = "Numero semana")] 
        public int? Numero_semana{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Fecha_inicial 
        /// </Resumen> 
        [Display(Name = "Fecha inicial")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha_inicial

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Fecha_final 
        /// </Resumen> 
        [Display(Name = "Fecha final")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? Fecha_final

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Estado 
        /// </Resumen> 
        [Display(Name = "Estado")] 
        [DataType (DataType.MultilineText)]   
        public String? Estado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: dias_pae 
        /// </Resumen> 
        [Display(Name = "dias pae")] 
        [DataType (DataType.MultilineText)]
        public List<PA_DiasPaeSemana> dias_pae { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Complementos_preparar 
        /// </Resumen> 
        [Display(Name = "Complementos preparar")] 
        public int? Complementos_preparar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Complemetos_almuerzos 
        /// </Resumen> 
        [Display(Name = "Complemetos almuerzos")] 
        public int? Complemetos_almuerzos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Complemetos_anpm 
        /// </Resumen> 
        [Display(Name = "Complemetos anpm")] 
        public int? Complemetos_anpm{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Total_complementos_Programados 
        /// </Resumen> 
        [Display(Name = "Total complementos Programados")] 
        public int? Total_complementos_Programados{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Total_complementos_Preparados 
        /// </Resumen> 
        [Display(Name = "Total complementos Preparados")] 
        public int? Total_complementos_Preparados{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Total_complementos_no_Preparados 
        /// </Resumen> 
        [Display(Name = "Total complementos no Preparados")] 
        public int? Total_complementos_no_Preparados{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ColorEstado 
        /// </Resumen> 
        [Display(Name = "Color Estado")] 
        [DataType (DataType.MultilineText)]   
        public String? ColorEstado{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    
///    


    }
}





