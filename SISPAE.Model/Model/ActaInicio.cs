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
     /// Clase Model Base para  ActaInicio
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class ActaInicioModelBase : ModelObject
    {
		private DateTime _createdFechaActa; 
private DateTime _createdFechaInicioOPeracionAutorizada; 
    public ActaInicioModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_PlanAlistamiento 
        /// </Resumen> 
        [Display(Name = "Plan Alistamiento")] 
        public int? ID_PlanAlistamiento{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_PlanAlistamiento { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_Contrato 
        /// </Resumen> 
        [Display(Name = "Contrato")] 
        public int? ID_Contrato{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_CicloMenu 
        /// </Resumen> 
        [Display(Name = "Ciclo Menu")] 
        public int? ID_CicloMenu{ get; set; }

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
        [StringLength(150 , ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreSupervisor{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CedulaSupervisor 
        /// </Resumen> 
        [Display(Name = "Cedula Supervisor")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CedulaSupervisor{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LugarCedulaSupervisor 
        /// </Resumen> 
        [Display(Name = "Lugar Cedula Supervisor")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? LugarCedulaSupervisor{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NombreRepresentanteLegalOperador 
        /// </Resumen> 
        [Display(Name = "Nombre Representante Legal Operador")] 
        [StringLength(150 , ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NombreRepresentanteLegalOperador{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CedulaRepresentanteOperador 
        /// </Resumen> 
        [Display(Name = "Cedula Representante Operador")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CedulaRepresentanteOperador{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LugarCedulaRepresentante 
        /// </Resumen> 
        [Display(Name = "Lugar Cedula Representante")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
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
        public Boolean? EstadoInicioOperacion{ get; set; }

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

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





