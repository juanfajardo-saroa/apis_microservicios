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
     /// Clase Model Base para  PA_GradosSedesJornadasGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_GradosSedesJornadasGetAllWithRelationModelBase : ModelObject
    {
		    public PA_GradosSedesJornadasGetAllWithRelationModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_SedeJornada 
        /// </Resumen> 
        [Display(Name = "Sede Jornada")] 
        public int? ID_SedeJornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Grado 
        /// </Resumen> 
        [Display(Name = "Grado")] 
        public int? ID_Grado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Matricula 
        /// </Resumen> 
        [Display(Name = "Matricula")] 
        public int? Matricula{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantlndigVicDis 
        /// </Resumen> 
        [Display(Name = "Cantlndig Vic Dis")] 
        public int? CantlndigVicDis{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantSisbenAB 
        /// </Resumen> 
        [Display(Name = "Cant Sisben A B")] 
        public int? CantSisbenAB{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantDiscapacitados 
        /// </Resumen> 
        [Display(Name = "Cant Discapacitados")] 
        public int? CantDiscapacitados{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CantIndigenasDiscapacidad 
        /// </Resumen> 
        [Display(Name = "Cant Indigenas Discapacidad")] 
        public int? CantIndigenasDiscapacidad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CambioMatricula 
        /// </Resumen> 
        [Display(Name = "Cambio Matricula")] 
        public Boolean? CambioMatricula{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sID_Grado 
        /// </Resumen> 
        [Display(Name = "s Grado")] 
        [DataType (DataType.MultilineText)]   
        public String? sID_Grado{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





