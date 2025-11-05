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
     /// Clase Model Base para  PA_DiagnosticoInfraEst
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_DiagnosticoInfraEstModelBase : ModelObject
    {
		    public PA_DiagnosticoInfraEstModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_sede 
        /// </Resumen> 
        [Display(Name = "sede")] 
        public int? id_sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        [DataType (DataType.MultilineText)]   
        public String? Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: InstEducativa 
        /// </Resumen> 
        [Display(Name = "Inst Educativa")] 
        [DataType (DataType.MultilineText)]   
        public String? InstEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Sede 
        /// </Resumen> 
        [Display(Name = "Sede")] 
        [DataType (DataType.MultilineText)]   
        public String? Sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PriorizadaPAE 
        /// </Resumen> 
        [Display(Name = "Priorizada P A E")] 
        public Boolean? PriorizadaPAE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ConHigienico 
        /// </Resumen> 
        [Display(Name = "Con Higienico")] 
        public Boolean? ConHigienico{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DotacionEq 
        /// </Resumen> 
        [Display(Name = "Dotacion Eq")] 
        public int? DotacionEq{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Electricidad 
        /// </Resumen> 
        [Display(Name = "Electricidad")] 
        public Boolean? Electricidad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Alcantarillado 
        /// </Resumen> 
        [Display(Name = "Alcantarillado")] 
        public Boolean? Alcantarillado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RecBasuras 
        /// </Resumen> 
        [Display(Name = "Rec Basuras")] 
        public Boolean? RecBasuras{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: AguaPotable 
        /// </Resumen> 
        [Display(Name = "Agua Potable")] 
        public Boolean? AguaPotable{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Gas 
        /// </Resumen> 
        [Display(Name = "Gas")] 
        public Boolean? Gas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Almacenamiento 
        /// </Resumen> 
        [Display(Name = "Almacenamiento")] 
        public Boolean? Almacenamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Preparacion 
        /// </Resumen> 
        [Display(Name = "Preparacion")] 
        public Boolean? Preparacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Consumo 
        /// </Resumen> 
        [Display(Name = "Consumo")] 
        public Boolean? Consumo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DispResiduos 
        /// </Resumen> 
        [Display(Name = "Disp Residuos")] 
        public Boolean? DispResiduos{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: AreaSanitarias 
        /// </Resumen> 
        [Display(Name = "Area Sanitarias")] 
        public Boolean? AreaSanitarias{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Diagnostico 
        /// </Resumen> 
        [Display(Name = "Diagnostico")] 
        public int? Diagnostico{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoCaract  
        /// </Resumen> 
        [Display(Name = "Estado Caract")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoCaract { get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





