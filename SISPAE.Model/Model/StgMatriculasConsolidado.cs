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
     /// Clase Model Base para  StgMatriculasConsolidado
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class StgMatriculasConsolidadoModelBase : ModelObject
    {
		    public StgMatriculasConsolidadoModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID 
        /// </Resumen> 
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID 
        /// </Resumen> 
        [Display(Name = "I D")] 
                         
        public string? sID  
                {
                     get;
                     set;
                }
        [Display(Name = "I D")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NRO_FILA 
        /// </Resumen> 
        [Display(Name = "N R O F I L A")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int NRO_FILA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ProcesoCargue 
        /// </Resumen> 
        [Display(Name = "Proceso Cargue")] 
        public int? ID_ProcesoCargue{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_TipoProcesoCargue 
        /// </Resumen> 
        [Display(Name = "Tipo Proceso Cargue")] 
        [Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        public int ID_TipoProcesoCargue{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ANNO_INF 
        /// </Resumen> 
        [Display(Name = "A N N O I N F")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ANNO_INF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MUN_CODIGO 
        /// </Resumen> 
        [Display(Name = "M U N C O D I G O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? MUN_CODIGO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_DANE 
        /// </Resumen> 
        [Display(Name = "C O D I G O D A N E")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CODIGO_DANE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_DANE_SEDE 
        /// </Resumen> 
        [Display(Name = "C O D I G O D A N E S E D E")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CODIGO_DANE_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TIPO_DOCUMENTO 
        /// </Resumen> 
        [Display(Name = "T I P O D O C U M E N T O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TIPO_DOCUMENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NRO_DOCUMENTO 
        /// </Resumen> 
        [Display(Name = "N R O D O C U M E N T O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NRO_DOCUMENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: APELLIDO1 
        /// </Resumen> 
        [Display(Name = "A P E L L I D O1")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? APELLIDO1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: APELLIDO2 
        /// </Resumen> 
        [Display(Name = "A P E L L I D O2")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? APELLIDO2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE1 
        /// </Resumen> 
        [Display(Name = "N O M B R E1")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE2 
        /// </Resumen> 
        [Display(Name = "N O M B R E2")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FECHA_NACIMIENTO 
        /// </Resumen> 
        [Display(Name = "F E C H A N A C I M I E N T O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? FECHA_NACIMIENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GENERO 
        /// </Resumen> 
        [Display(Name = "G E N E R O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? GENERO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TIPO_JORNADA 
        /// </Resumen> 
        [Display(Name = "T I P O J O R N A D A")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TIPO_JORNADA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ESPECIALIDAD 
        /// </Resumen> 
        [Display(Name = "E S P E C I A L I D A D")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ESPECIALIDAD{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GRADO 
        /// </Resumen> 
        [Display(Name = "G R A D O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? GRADO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GRUPO 
        /// </Resumen> 
        [Display(Name = "G R U P O")] 
        [DataType (DataType.MultilineText)]   
        public String? GRUPO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PER_ID 
        /// </Resumen> 
        [Display(Name = "P E R I D")] 
        [DataType (DataType.MultilineText)]   
        public String? PER_ID{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_SED 
        /// </Resumen> 
        [Display(Name = "C O D I G O S E D")] 
        [DataType (DataType.MultilineText)]   
        public String? CODIGO_SED{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DPTO_CARGA 
        /// </Resumen> 
        [Display(Name = "D P T O C A R G A")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? DPTO_CARGA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_ESTABLECIMIENTO 
        /// </Resumen> 
        [Display(Name = "N O M B R E E S T A B L E C I M I E N T O")] 
        [DataType (DataType.MultilineText)]   
        public String? NOMBRE_ESTABLECIMIENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CTE_ID_SECTOR 
        /// </Resumen> 
        [Display(Name = "C T E S E C T O R")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CTE_ID_SECTOR{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_SEDE 
        /// </Resumen> 
        [Display(Name = "N O M B R E S E D E")] 
        [DataType (DataType.MultilineText)]   
        public String? NOMBRE_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CTE_ID_ZONA 
        /// </Resumen> 
        [Display(Name = "C T E Z O N A")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CTE_ID_ZONA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Divipola_MUNICIPIO 
        /// </Resumen> 
        [Display(Name = "Divipola M U N I C I P I O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? Divipola_MUNICIPIO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EDAD 
        /// </Resumen> 
        [Display(Name = "E D A D")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? EDAD{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NIV_CONPES 
        /// </Resumen> 
        [Display(Name = "N I V C O N P E S")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NIV_CONPES{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_PAIS_ORIGEN 
        /// </Resumen> 
        [Display(Name = "C O D I G O P A I S O R I G E N")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CODIGO_PAIS_ORIGEN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_PAIS_ORIGEN 
        /// </Resumen> 
        [Display(Name = "N O M B R E P A I S O R I G E N")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE_PAIS_ORIGEN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SISBEN 
        /// </Resumen> 
        [Display(Name = "S I S B E N")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? SISBEN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: POB_VICT_CONF 
        /// </Resumen> 
        [Display(Name = "P O B V I C T C O N F")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? POB_VICT_CONF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DISCAPACIDAD_HOMOLGADA_2021 
        /// </Resumen> 
        [Display(Name = "D I S C A P A C I D A D H O M O L G A D A 2021")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? DISCAPACIDAD_HOMOLGADA_2021{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ETNIA 
        /// </Resumen> 
        [Display(Name = "E T N I A")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ETNIA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ID_ETC 
        /// </Resumen> 
        [Display(Name = "E T C")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ID_ETC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ESTADO_SEDE 
        /// </Resumen> 
        [Display(Name = "E S T A D O S E D E")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ESTADO_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_CARGO 
        /// </Resumen> 
        [Display(Name = "N O M B R E C A R G O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE_CARGO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EMAIL 
        /// </Resumen> 
        [Display(Name = "E M A I L")] 
        [StringLength(200 , ErrorMessage = " El campo {0} no debe tener mas de 200 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? EMAIL{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TEL_CELULAR 
        /// </Resumen> 
        [Display(Name = "T E L C E L U L A R")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TEL_CELULAR{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TEL_FIJO 
        /// </Resumen> 
        [Display(Name = "T E L F I J O")] 
        public Byte[]? TEL_FIJO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Estatus 
        /// </Resumen> 
        [Display(Name = "Estatus")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? Estatus{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Error 
        /// </Resumen> 
        [Display(Name = "Error")] 
        [DataType (DataType.MultilineText)]   
        public String? Error{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Auditoria 
        /// </Resumen> 
        [Display(Name = "Auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? Auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FECHA_VINCULACION 
        /// </Resumen> 
        [Display(Name = "F E C H A V I N C U L A C I O N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? FECHA_VINCULACION{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NIVEL_EDUCATIVO_APROBADO 
        /// </Resumen> 
        [Display(Name = "N I V E L E D U C A T I V O A P R O B A D O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NIVEL_EDUCATIVO_APROBADO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: UBICACION 
        /// </Resumen> 
        [Display(Name = "U B I C A C I O N")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? UBICACION{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TIPO_VINCULACION 
        /// </Resumen> 
        [Display(Name = "T I P O V I N C U L A C I O N")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TIPO_VINCULACION{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NIVEL_ENSENANZA 
        /// </Resumen> 
        [Display(Name = "N I V E L E N S E N A N Z A")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NIVEL_ENSENANZA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ESTADO_CIVIL 
        /// </Resumen> 
        [Display(Name = "E S T A D O C I V I L")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ESTADO_CIVIL{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ESTATUTO 
        /// </Resumen> 
        [Display(Name = "E S T A T U T O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ESTATUTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PARENTESCO 
        /// </Resumen> 
        [Display(Name = "P A R E N T E S C O")] 
        [StringLength(100 , ErrorMessage = " El campo {0} no debe tener mas de 100 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? PARENTESCO{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





