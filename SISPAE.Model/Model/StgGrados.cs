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
     /// Clase Model Base para  StgGrados
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class StgGradosModelBase : ModelObject
    {
		private DateTime _createdcreated_at; 
private DateTime _createdupdated_at; 
    public StgGradosModelBase() 
    {  
    _createdcreated_at= DateTime.MinValue; 
    _createdupdated_at= DateTime.MinValue; 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IdGrado 
        /// </Resumen> 
        [Display(Name = "Id Grado")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int IdGrado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Grado 
        /// </Resumen> 
        [Display(Name = "Grado")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String Grado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: LimiteEdad 
        /// </Resumen> 
        [Display(Name = "Limite Edad")] 
        public int? LimiteEdad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IdNivel 
        /// </Resumen> 
        [Display(Name = "Id Nivel")] 
        public int? IdNivel{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IdNivelMediaTotal 
        /// </Resumen> 
        [Display(Name = "Id Nivel Media Total")] 
        public int? IdNivelMediaTotal{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: IdNivelCine 
        /// </Resumen> 
        [Display(Name = "Id Nivel Cine")] 
        public int? IdNivelCine{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: created_at 
        /// </Resumen> 
        [Display(Name = "created at")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? created_at

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: updated_at 
        /// </Resumen> 
        [Display(Name = "updated at")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? updated_at

                {
                     get;
                     set;

                }
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





