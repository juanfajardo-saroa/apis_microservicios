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
     /// Clase Model Base para  ErroresCargue
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class ErroresCargueModelBase : ModelObject
    {
		    public ErroresCargueModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ProcesosCargue 
        /// </Resumen> 
        [Display(Name = "Procesos Cargue")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_ProcesosCargue{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_ProcesosCargue { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoProcesoCargue 
        /// </Resumen> 
        [Display(Name = "Tipo Proceso Cargue")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_TipoProcesoCargue{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_TipoProcesoCargue { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoErroresCargue 
        /// </Resumen> 
        [Display(Name = "Tipo Errores Cargue")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_TipoErroresCargue{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sID_TipoErroresCargue { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PER_ID 
        /// </Resumen> 
        [Display(Name = "P E R I D")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? PER_ID{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Fila 
        /// </Resumen> 
        [Display(Name = "Fila")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int Fila{ get; set; }

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





