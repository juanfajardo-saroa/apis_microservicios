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
     /// Clase Model Base para  GetCaracterizacionNivel4
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class GetCaracterizacionNivel4ModelBase : ModelObject
    {
		    public GetCaracterizacionNivel4ModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Categoria1erNivel 
        /// </Resumen> 
        [Display(Name = "Categoria1er Nivel")] 
        [DataType (DataType.MultilineText)]   
        public String? Categoria1erNivel{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idCategoria2doNivel 
        /// </Resumen> 
        [Display(Name = "id Categoria2do Nivel")] 
        [DataType (DataType.MultilineText)]   
        public String? idCategoria2doNivel{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Categoria2doNivel 
        /// </Resumen> 
        [Display(Name = "Categoria2do Nivel")] 
        [DataType (DataType.MultilineText)]   
        public String? Categoria2doNivel{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IconoCategoria 
        /// </Resumen> 
        [Display(Name = "Icono Categoria")] 
        [DataType (DataType.MultilineText)]   
        public String? IconoCategoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idPregunta 
        /// </Resumen> 
        [Display(Name = "id Pregunta")] 
        public int? idPregunta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Pregunta 
        /// </Resumen> 
        [Display(Name = "Pregunta")] 
        [DataType (DataType.MultilineText)]   
        public String? Pregunta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IconoPregunta2doNivel 
        /// </Resumen> 
        [Display(Name = "Icono Pregunta2do Nivel")] 
        [DataType (DataType.MultilineText)]   
        public String? IconoPregunta2doNivel{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idEscala 
        /// </Resumen> 
        [Display(Name = "id Escala")] 
        public int? idEscala{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreEscala 
        /// </Resumen> 
        [Display(Name = "Nombre Escala")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreEscala{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SI 
        /// </Resumen> 
        [Display(Name = "S I")] 
        public int? SI{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NO 
        /// </Resumen> 
        [Display(Name = "N O")] 
        public int? NO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SI_CHSFAV 
        /// </Resumen> 
        [Display(Name = "S I C H S F A V")] 
        public int? SI_CHSFAV{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SI_CHSREQ 
        /// </Resumen> 
        [Display(Name = "S I C H S R E Q")] 
        public int? SI_CHSREQ{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SI_CHSDESF 
        /// </Resumen> 
        [Display(Name = "S I C H S D E S F")] 
        public int? SI_CHSDESF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NO_NOCHS 
        /// </Resumen> 
        [Display(Name = "N O N O C H S")] 
        public int? NO_NOCHS{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





