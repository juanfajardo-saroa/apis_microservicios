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
     /// Clase Model Base para  PA_repositoriosGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_repositoriosGetAllWithRelationModelBase : ModelObject
    {
		private DateTime _createdfechaArchivo; 
private DateTime _createdfechaCarga; 
    public PA_repositoriosGetAllWithRelationModelBase() 
    {  
    _createdfechaArchivo= DateTime.MinValue; 
    _createdfechaCarga= DateTime.MinValue; 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idTipoArchivo 
        /// </Resumen> 
        [Display(Name = "id Tipo Archivo")] 
        public int? idTipoArchivo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idCategoria 
        /// </Resumen> 
        [Display(Name = "id Categoria")] 
        public int? idCategoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: idVigencia 
        /// </Resumen> 
        [Display(Name = "id Vigencia")] 
        public int? idVigencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NPAHTArchivo 
        /// </Resumen> 
        [Display(Name = "P A H T Archivo")] 
        [DataType (DataType.MultilineText)]   
        public String? PAHTArchivo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Nombre 
        /// </Resumen> 
        [Display(Name = "Nombre")] 
        [DataType (DataType.MultilineText)]   
        public String? Nombre{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Descripcion 
        /// </Resumen> 
        [Display(Name = "Descripcion")] 
        [DataType (DataType.MultilineText)]   
        public String? Descripcion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: fechaArchivo 
        /// </Resumen> 
        [Display(Name = "fecha Archivo")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? fechaArchivo

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: fechaCarga 
        /// </Resumen> 
        [Display(Name = "fecha Carga")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? fechaCarga

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_TipoModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Tipo Modelo Operacion")] 
        public int? id_TipoModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreResolucion 
        /// </Resumen> 
        [Display(Name = "Nombre Resolucion")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreResolucion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: tamanoArchivo 
        /// </Resumen> 
        [Display(Name = "tamano Archivo")] 
        public string? tamanoArchivo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sid_TipoModeloOperacion 
        /// </Resumen> 
        [Display(Name = "s Tipo Modelo Operacion")] 
        [DataType (DataType.MultilineText)]   
        public String? sid_TipoModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sidCategoria 
        /// </Resumen> 
        [Display(Name = "sid Categoria")] 
        [DataType (DataType.MultilineText)]   
        public String? sidCategoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sidTipoArchivo 
        /// </Resumen> 
        [Display(Name = "sid Tipo Archivo")] 
        [DataType (DataType.MultilineText)]   
        public String? sidTipoArchivo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sidVigencia 
        /// </Resumen> 
        [Display(Name = "sid Vigencia")] 
        [DataType (DataType.MultilineText)]   
        public String? sidVigencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DiferenciaHoras 
        /// </Resumen> 
        [Display(Name = "Diferencia Horas")] 
        [DataType (DataType.MultilineText)]   
        public String? DiferenciaHoras{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





