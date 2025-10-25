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
     /// Clase Model Base para  AlimentosMinutaF3
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class AlimentosMinutaF3ModelBase : ModelObject
    {
		    public AlimentosMinutaF3ModelBase() 
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
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int id{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_MinutaPatronAlimento 
        /// </Resumen> 
        [Display(Name = "Minuta Patron Alimento")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_MinutaPatronAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoComponente 
        /// </Resumen> 
        [Display(Name = "Tipo Componente")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_TipoComponente{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_GrupoAlimento 
        /// </Resumen> 
        [Display(Name = "Grupo Alimento")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_GrupoAlimento{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: frecuencia 
        /// </Resumen> 
        [Display(Name = "frecuencia")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int frecuencia{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MingramoPesoBruto 
        /// </Resumen> 
        [Display(Name = "Mingramo Peso Bruto")] 
        public int? MingramoPesoBruto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MaxgramoPesoBruto 
        /// </Resumen> 
        [Display(Name = "Maxgramo Peso Bruto")] 
        public int? MaxgramoPesoBruto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MingramoPesoNeto 
        /// </Resumen> 
        [Display(Name = "Mingramo Peso Neto")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int MingramoPesoNeto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MaxgramoPesoNeto 
        /// </Resumen> 
        [Display(Name = "Maxgramo Peso Neto")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int MaxgramoPesoNeto{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MingramoPesoPorcionServida 
        /// </Resumen> 
        [Display(Name = "Mingramo Peso Porcion Servida")] 
        public int? MingramoPesoPorcionServida{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MaxgramoPesoPorcionServida 
        /// </Resumen> 
        [Display(Name = "Maxgramo Peso Porcion Servida")] 
        public int? MaxgramoPesoPorcionServida{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: normativa 
        /// </Resumen> 
        [Display(Name = "normativa")] 
        [DataType (DataType.MultilineText)]   
        public String? normativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_SubGrupoAlimento 
        /// </Resumen> 
        [Display(Name = "Sub Grupo Alimento")] 
        public int? ID_SubGrupoAlimento{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





