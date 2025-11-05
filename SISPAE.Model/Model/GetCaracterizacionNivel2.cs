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
     /// Clase Model Base para  GetCaracterizacionNivel2
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class GetCaracterizacionNivel2ModelBase : ModelObject
    {
		    public GetCaracterizacionNivel2ModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: OrdenPregunta 
        /// </Resumen> 
        [Display(Name = "Orden Pregunta")] 
        public int? OrdenPregunta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idPreguntaPadre 
        /// </Resumen> 
        [Display(Name = "id Pregunta Padre")] 
        public int? idPreguntaPadre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TercerNivel 
        /// </Resumen> 
        [Display(Name = "Tercer Nivel")] 
        public int? TercerNivel{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id 
        /// </Resumen> 
        [Display(Name = "SinNombre")] 
        public int? id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: activar 
        /// </Resumen> 
        [Display(Name = "activar")] 
        public Boolean? activar{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: valorRespuesta 
        /// </Resumen> 
        [Display(Name = "valor Respuesta")] 
        public int? valorRespuesta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: contenidoRespuesta 
        /// </Resumen> 
        [Display(Name = "contenido Respuesta")] 
        [DataType (DataType.MultilineText)]   
        public String? contenidoRespuesta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: tipoPregunta 
        /// </Resumen> 
        [Display(Name = "tipo Pregunta")] 
        public int? tipoPregunta{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: mostrarIcono 
        /// </Resumen> 
        [Display(Name = "mostrar Icono")] 
        public Boolean? mostrarIcono{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





