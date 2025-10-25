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
     /// Clase Model Base para  SuficienciaEquiposMenaje
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class SuficienciaEquiposMenajeModelBase : ModelObject
    {
		    public SuficienciaEquiposMenajeModelBase() 
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
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
                         
        public string? sID  
                {
                     get;
                     set;
                }
        [Display(Name = "SinNombre")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: elemento 
        /// </Resumen> 
        [Display(Name = "elemento")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? elemento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_caracteristica 
        /// </Resumen> 
        [Display(Name = "caracteristica")] 
        public Decimal? id_caracteristica{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantidadInicial 
        /// </Resumen> 
        [Display(Name = "Cantidad Inicial")] 
        public Decimal? CantidadInicial{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantidadFinal 
        /// </Resumen> 
        [Display(Name = "Cantidad Final")] 
        public Decimal? CantidadFinal{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoInicalInsuficiente 
        /// </Resumen> 
        [Display(Name = "Complemento Inical Insuficiente")] 
        public Decimal? ComplementoInicalInsuficiente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoIncialAceptable 
        /// </Resumen> 
        [Display(Name = "Complemento Incial Aceptable")] 
        public Decimal? ComplementoIncialAceptable{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoFinalAceptable 
        /// </Resumen> 
        [Display(Name = "Complemento Final Aceptable")] 
        public Decimal? ComplementoFinalAceptable{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoInicialSuficiente 
        /// </Resumen> 
        [Display(Name = "Complemento Inicial Suficiente")] 
        public Decimal? ComplementoInicialSuficiente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ComplementoFinalSuficiente 
        /// </Resumen> 
        [Display(Name = "Complemento Final Suficiente")] 
        public Decimal? ComplementoFinalSuficiente{ get; set; }

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





