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
     /// Clase Model Base para  Trayectos
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class TrayectosModelBase : ModelObject
    {
		    public TrayectosModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TrayectoId 
        /// </Resumen> 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TrayectoId 
        /// </Resumen> 
        [Display(Name = "Trayecto Id")] 
                         
        public string? sID  
                {
                     get;
                     set;
                }
        [Display(Name = "Trayecto Id")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int TrayectoId{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoTransporteId 
        /// </Resumen> 
        [Display(Name = "Tipo Transporte Id")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int TipoTransporteId{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sTipoTransporteId { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MedioTransporteId 
        /// </Resumen> 
        [Display(Name = "Medio Transporte Id")] 
        public int? MedioTransporteId{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sMedioTransporteId { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SedeId 
        /// </Resumen> 
        [Display(Name = "Sede Id")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int SedeId{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sSedeId { get; set; }
        /// 
 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NumPosicion 
        /// </Resumen> 
        [Display(Name = "Num Posicion")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int NumPosicion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Costo 
        /// </Resumen> 
        [Display(Name = "Costo")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int Costo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Kilometros 
        /// </Resumen> 
        [Display(Name = "Kilometros")] 
        public int? Kilometros{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Horas 
        /// </Resumen> 
        [Display(Name = "Horas")] 
        public int? Horas{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Destino 
        /// </Resumen> 
        [Display(Name = "Destino")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? Destino{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CabeceraMunicipal 
        /// </Resumen> 
        [Display(Name = "Cabecera Municipal")] 
        public Boolean? CabeceraMunicipal{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CentroAcopio 
        /// </Resumen> 
        [Display(Name = "Centro Acopio")] 
        public Boolean? CentroAcopio{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





