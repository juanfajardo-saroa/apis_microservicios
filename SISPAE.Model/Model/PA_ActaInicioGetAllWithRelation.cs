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
     /// Clase Model Base para  PA_ActaInicioGetAllWithRelation
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_ActaInicioGetAllWithRelationModelBase : ModelObject
    {
		private DateTime _createdFechaActa; 
private DateTime _createdFechaInicioOPeracionAutorizada; 
    public PA_ActaInicioGetAllWithRelationModelBase() 
    {  
    _createdFechaActa= DateTime.MinValue; 
    _createdFechaInicioOPeracionAutorizada= DateTime.MinValue; 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_PlanesAlistamiento 
        /// </Resumen> 
        [Display(Name = "Planes Alistamiento")] 
        public int? ID_PlanesAlistamiento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_CiclosMenu 
        /// </Resumen> 
        [Display(Name = "Ciclos Menu")] 
        public int? ID_CiclosMenu{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaActa 
        /// </Resumen> 
        [Display(Name = "Fecha Acta")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaActa

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreSupervisor 
        /// </Resumen> 
        [Display(Name = "Nombre Supervisor")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreSupervisor{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CedulaSupervisor 
        /// </Resumen> 
        [Display(Name = "Cedula Supervisor")] 
        [DataType (DataType.MultilineText)]   
        public String? CedulaSupervisor{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LugarCedulaSupervisor 
        /// </Resumen> 
        [Display(Name = "Lugar Cedula Supervisor")] 
        [DataType (DataType.MultilineText)]   
        public String? LugarCedulaSupervisor{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreRepresentanteLegalOperador 
        /// </Resumen> 
        [Display(Name = "Nombre Representante Legal Operador")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreRepresentanteLegalOperador{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CedulaRepresentanteOperador 
        /// </Resumen> 
        [Display(Name = "Cedula Representante Operador")] 
        [DataType (DataType.MultilineText)]   
        public String? CedulaRepresentanteOperador{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LugarCedulaRepresentante 
        /// </Resumen> 
        [Display(Name = "Lugar Cedula Representante")] 
        [DataType (DataType.MultilineText)]   
        public String? LugarCedulaRepresentante{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaInicioOPeracionAutorizada 
        /// </Resumen> 
        [Display(Name = "Fecha Inicio O Peracion Autorizada")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaInicioOPeracionAutorizada

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoInicioOperacion 
        /// </Resumen> 
        [Display(Name = "Estado Inicio Operacion")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoInicioOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Menu1 
        /// </Resumen> 
        [Display(Name = "Menu1")] 
        public int? Menu1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Menu2 
        /// </Resumen> 
        [Display(Name = "Menu2")] 
        public int? Menu2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Menu3 
        /// </Resumen> 
        [Display(Name = "Menu3")] 
        public int? Menu3{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





