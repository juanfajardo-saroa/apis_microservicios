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
     /// Clase Model Base para  StgAnexo6a
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class StgAnexo6aModelBase : ModelObject
    {
		private DateTime _createdFECHA_NACIMIENTO; 
    public StgAnexo6aModelBase() 
    {  
    _createdFECHA_NACIMIENTO= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ANNO_INF 
        /// </Resumen> 
        [Display(Name = "A N N O I N F")] 
        public int? ANNO_INF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PER_ID 
        /// </Resumen> 
        [Display(Name = "P E R I D")] 
        public int? PER_ID{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TIPO_DOCUMENTO 
        /// </Resumen> 
        [Display(Name = "T I P O D O C U M E N T O")] 
        public int? TIPO_DOCUMENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NRO_DOCUMENTO 
        /// </Resumen> 
        [Display(Name = "N R O D O C U M E N T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NRO_DOCUMENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: APELLIDO1 
        /// </Resumen> 
        [Display(Name = "A P E L L I D O1")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? APELLIDO1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: APELLIDO2 
        /// </Resumen> 
        [Display(Name = "A P E L L I D O2")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? APELLIDO2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE1 
        /// </Resumen> 
        [Display(Name = "N O M B R E1")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE2 
        /// </Resumen> 
        [Display(Name = "N O M B R E2")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EDAD 
        /// </Resumen> 
        [Display(Name = "E D A D")] 
        public int? EDAD{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FECHA_NACIMIENTO 
        /// </Resumen> 
        [Display(Name = "F E C H A N A C I M I E N T O")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FECHA_NACIMIENTO

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NIV_CONPES 
        /// </Resumen> 
        [Display(Name = "N I V C O N P E S")] 
        public int? NIV_CONPES{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: JORNADA 
        /// </Resumen> 
        [Display(Name = "J O R N A D A")] 
        public int? JORNADA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GRADO 
        /// </Resumen> 
        [Display(Name = "G R A D O")] 
        public int? GRADO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        public int? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_DANE 
        /// </Resumen> 
        [Display(Name = "C O D I G O D A N E")] 
        public Decimal? CODIGO_DANE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_ESTABLECIMIENTO 
        /// </Resumen> 
        [Display(Name = "N O M B R E E S T A B L E C I M I E N T O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE_ESTABLECIMIENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_DANE_SEDE 
        /// </Resumen> 
        [Display(Name = "C O D I G O D A N E S E D E")] 
        public Decimal? CODIGO_DANE_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_SEDE 
        /// </Resumen> 
        [Display(Name = "N O M B R E S E D E")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ESTADO_SEDE 
        /// </Resumen> 
        [Display(Name = "E S T A D O S E D E")] 
        public int? ESTADO_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CTE_ID_ZONA 
        /// </Resumen> 
        [Display(Name = "C T E Z O N A")] 
        public int? CTE_ID_ZONA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Divipola_MUNICIPIO 
        /// </Resumen> 
        [Display(Name = "Divipola M U N I C I P I O")] 
        public int? Divipola_MUNICIPIO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: POB_VICT_CONF 
        /// </Resumen> 
        [Display(Name = "P O B V I C T C O N F")] 
        public int? POB_VICT_CONF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DISCAPACIDAD_HOMOLGADA_2021 
        /// </Resumen> 
        [Display(Name = "D I S C A P A C I D A D H O M O L G A D A 2021")] 
        public int? DISCAPACIDAD_HOMOLGADA_2021{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GRUPO_ETNICO 
        /// </Resumen> 
        [Display(Name = "G R U P O E T N I C O")] 
        public int? GRUPO_ETNICO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SISBEN 
        /// </Resumen> 
        [Display(Name = "S I S B E N")] 
        public int? SISBEN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GENERO 
        /// </Resumen> 
        [Display(Name = "G E N E R O")] 
        [StringLength(1 , ErrorMessage = " El campo {0} no debe tener mas de 1 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? GENERO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_PAIS_ORIGEN 
        /// </Resumen> 
        [Display(Name = "C O D I G O P A I S O R I G E N")] 
        public int? CODIGO_PAIS_ORIGEN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_PAIS_ORIGEN 
        /// </Resumen> 
        [Display(Name = "N O M B R E P A I S O R I G E N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE_PAIS_ORIGEN{ get; set; }

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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





