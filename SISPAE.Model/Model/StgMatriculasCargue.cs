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
     /// Clase Model Base para  StgMatriculasCargue
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class StgMatriculasCargueModelBase : ModelObject
    {
		private DateTime _createdFechaCarga; 
    public StgMatriculasCargueModelBase() 
    {  
    _createdFechaCarga= DateTime.MinValue; 
    }  
        

		

        ///Definicion de miembros o metodos privados    
#region Private Members 
#endregion Private Members    


        ///Definicion de miembros o metodos publicos  - Property Declarations  
#region Public Members 
 
        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ANO_INF 
        /// </Resumen> 
        [Display(Name = "A N O I N F")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ANO_INF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MUN_CODIGO 
        /// </Resumen> 
        [Display(Name = "M U N C O D I G O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? MUN_CODIGO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_DANE 
        /// </Resumen> 
        [Display(Name = "C O D I G O D A N E")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CODIGO_DANE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CODIGO_DANE_SEDE 
        /// </Resumen> 
        [Display(Name = "C O D I G O D A N E S E D E")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CODIGO_DANE_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CONS_SEDE 
        /// </Resumen> 
        [Display(Name = "C O N S S E D E")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CONS_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TIPO_DOCUMENTO 
        /// </Resumen> 
        [Display(Name = "T I P O D O C U M E N T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TIPO_DOCUMENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NRO_DOCUMENTO 
        /// </Resumen> 
        [Display(Name = "N R O D O C U M E N T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NRO_DOCUMENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EXP_DEPTO 
        /// </Resumen> 
        [Display(Name = "E X P D E P T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? EXP_DEPTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EXP_MUN 
        /// </Resumen> 
        [Display(Name = "E X P M U N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? EXP_MUN{ get; set; }

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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DIRECCION_RESIDENCIA 
        /// </Resumen> 
        [Display(Name = "D I R E C C I O N R E S I D E N C I A")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? DIRECCION_RESIDENCIA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TEL 
        /// </Resumen> 
        [Display(Name = "T E L")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TEL{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RES_DEPTO 
        /// </Resumen> 
        [Display(Name = "R E S D E P T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? RES_DEPTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RES_MUN 
        /// </Resumen> 
        [Display(Name = "R E S M U N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? RES_MUN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ESTRATO 
        /// </Resumen> 
        [Display(Name = "E S T R A T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ESTRATO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SISBEN 
        /// </Resumen> 
        [Display(Name = "S I S B E N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? SISBEN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FECHA_NACIMIENTO 
        /// </Resumen> 
        [Display(Name = "F E C H A N A C I M I E N T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? FECHA_NACIMIENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NAC_DEPTO 
        /// </Resumen> 
        [Display(Name = "N A C D E P T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NAC_DEPTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NAC_MUN 
        /// </Resumen> 
        [Display(Name = "N A C M U N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NAC_MUN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GENERO 
        /// </Resumen> 
        [Display(Name = "G E N E R O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? GENERO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: POB_VICT_CONF 
        /// </Resumen> 
        [Display(Name = "P O B V I C T C O N F")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? POB_VICT_CONF{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DPTO_EXP 
        /// </Resumen> 
        [Display(Name = "D P T O E X P")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? DPTO_EXP{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MUN_EXP 
        /// </Resumen> 
        [Display(Name = "M U N E X P")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? MUN_EXP{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PROVIENE_SECTOR_PRIV 
        /// </Resumen> 
        [Display(Name = "P R O V I E N E S E C T O R P R I V")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? PROVIENE_SECTOR_PRIV{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PROVIENE_OTRO_MUN 
        /// </Resumen> 
        [Display(Name = "P R O V I E N E O T R O M U N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? PROVIENE_OTRO_MUN{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TIPO_DISCAPACIDAD 
        /// </Resumen> 
        [Display(Name = "T I P O D I S C A P A C I D A D")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TIPO_DISCAPACIDAD{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CAP_EXC 
        /// </Resumen> 
        [Display(Name = "C A P E X C")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CAP_EXC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ETNIA 
        /// </Resumen> 
        [Display(Name = "E T N I A")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ETNIA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RES 
        /// </Resumen> 
        [Display(Name = "R E S")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? RES{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: INS_FAMILIAR 
        /// </Resumen> 
        [Display(Name = "I N S F A M I L I A R")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? INS_FAMILIAR{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TIPO_JORNADA 
        /// </Resumen> 
        [Display(Name = "T I P O J O R N A D A")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TIPO_JORNADA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CARACTER 
        /// </Resumen> 
        [Display(Name = "C A R A C T E R")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CARACTER{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ESPECIALIDAD 
        /// </Resumen> 
        [Display(Name = "E S P E C I A L I D A D")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ESPECIALIDAD{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GRADO 
        /// </Resumen> 
        [Display(Name = "G R A D O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? GRADO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: GRUPO 
        /// </Resumen> 
        [Display(Name = "G R U P O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? GRUPO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: METODOLOGIA 
        /// </Resumen> 
        [Display(Name = "M E T O D O L O G I A")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? METODOLOGIA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SUBSIDIADO 
        /// </Resumen> 
        [Display(Name = "S U B S I D I A D O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? SUBSIDIADO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: REPITENTE 
        /// </Resumen> 
        [Display(Name = "R E P I T E N T E")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? REPITENTE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NUEVO 
        /// </Resumen> 
        [Display(Name = "N U E V O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NUEVO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: SIT_ACAD_ANO_ANT 
        /// </Resumen> 
        [Display(Name = "S I T A C A D A N O A N T")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? SIT_ACAD_ANO_ANT{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CON_ALUM_ANO_ANT 
        /// </Resumen> 
        [Display(Name = "C O N A L U M A N O A N T")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CON_ALUM_ANO_ANT{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FUE_RECU 
        /// </Resumen> 
        [Display(Name = "F U E R E C U")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? FUE_RECU{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ZON_ALU 
        /// </Resumen> 
        [Display(Name = "Z O N A L U")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? ZON_ALU{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CAB_FAMILIA 
        /// </Resumen> 
        [Display(Name = "C A B F A M I L I A")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CAB_FAMILIA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: BEN_MAD_FLIA 
        /// </Resumen> 
        [Display(Name = "B E N M A D F L I A")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? BEN_MAD_FLIA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: BEN_VET_FP 
        /// </Resumen> 
        [Display(Name = "B E N V E T F P")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? BEN_VET_FP{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: BEN_HER_NAC 
        /// </Resumen> 
        [Display(Name = "B E N H E R N A C")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? BEN_HER_NAC{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: INTERNADO 
        /// </Resumen> 
        [Display(Name = "I N T E R N A D O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? INTERNADO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: VAL_DES_PERIODO1 
        /// </Resumen> 
        [Display(Name = "V A L D E S P E R I O D O1")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? VAL_DES_PERIODO1{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: VAL_DES_PERIODO2 
        /// </Resumen> 
        [Display(Name = "V A L D E S P E R I O D O2")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? VAL_DES_PERIODO2{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NUM_CONVENIO 
        /// </Resumen> 
        [Display(Name = "N U M C O N V E N I O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NUM_CONVENIO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_CONTRATIST 
        /// </Resumen> 
        [Display(Name = "N O M B R E C O N T R A T I S T")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? NOMBRE_CONTRATIST{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CTE_MOD_CONTRATO 
        /// </Resumen> 
        [Display(Name = "C T E M O D C O N T R A T O")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CTE_MOD_CONTRATO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CTE_TIPO_DOCENTE 
        /// </Resumen> 
        [Display(Name = "C T E T I P O D O C E N T E")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? CTE_TIPO_DOCENTE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PAIS_ORIGEN 
        /// </Resumen> 
        [Display(Name = "P A I S O R I G E N")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? PAIS_ORIGEN{ get; set; }

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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: sector 
        /// </Resumen> 
        [Display(Name = "sector")] 
        [StringLength(10 , ErrorMessage = " El campo {0} no debe tener mas de 10 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? sector{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: calendario 
        /// </Resumen> 
        [Display(Name = "calendario")] 
        [StringLength(50 , ErrorMessage = " El campo {0} no debe tener mas de 50 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? calendario{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Encabezado 
        /// </Resumen> 
        [Display(Name = "Encabezado")] 
        public int? id_Encabezado{ get; set; }

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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: auditoria 
        /// </Resumen> 
        [Display(Name = "auditoria")] 
        [DataType (DataType.MultilineText)]   
        public String? auditoria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TipoAnexo 
        /// </Resumen> 
        [Display(Name = "Tipo Anexo")] 
        [StringLength(5 , ErrorMessage = " El campo {0} no debe tener mas de 5 caracteres.")] 
        [DataType (DataType.Text)]   
        public String? TipoAnexo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_ESTABLECIMIENTO 
        /// </Resumen> 
        [Display(Name = "N O M B R E E S T A B L E C I M I E N T O")] 
        [StringLength(150 , ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NOMBRE_ESTABLECIMIENTO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_SEDE 
        /// </Resumen> 
        [Display(Name = "N O M B R E S E D E")] 
        [StringLength(150 , ErrorMessage = " El campo {0} no debe tener mas de 150 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NOMBRE_SEDE{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CTE_ID_ZONA 
        /// </Resumen> 
        [Display(Name = "C T E Z O N A")] 
        public int? CTE_ID_ZONA{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: PER_ID 
        /// </Resumen> 
        [Display(Name = "P E R I D")] 
        public int? PER_ID{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Edad 
        /// </Resumen> 
        [Display(Name = "Edad")] 
        public int? Edad{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NIV_CONPES 
        /// </Resumen> 
        [Display(Name = "N I V C O N P E S")] 
        public int? NIV_CONPES{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: DISCAPACIDAD_HOMOLGADA_ 
        /// </Resumen> 
        [Display(Name = "D I S C A P A C I D A D H O M O L G A D A")] 
        public int? DISCAPACIDAD_HOMOLGADA_{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CORREO 
        /// </Resumen> 
        [Display(Name = "C O R R E O")] 
        [StringLength(255 , ErrorMessage = " El campo {0} no debe tener mas de 255 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? CORREO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: NOMBRE_CARGO 
        /// </Resumen> 
        [Display(Name = "N O M B R E C A R G O")] 
        [StringLength(255 , ErrorMessage = " El campo {0} no debe tener mas de 255 caracteres.")] 
        [DataType (DataType.MultilineText)]   
        public String? NOMBRE_CARGO{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: FechaCarga 
        /// </Resumen> 
        [Display(Name = "Fecha Carga")] 
        [DataType(DataType.Date,ErrorMessage ="En el campo  {0} debe ingresar una fecha valida !")] 
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime? FechaCarga

                {
                     get;
                     set;

                }
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_cargue 
        /// </Resumen> 
        [Display(Name = "cargue")] 
        public int? id_cargue{ get; set; }

        ///[Required(ErrorMessage =" El Campo {0} es obligatorio, no puede estar vacio !")] 
        /// Esta propiedad corresponde a las Foreing Key, la (s) inicial se pone porque el objeto no se puede llamar igual que la clase 
        public String? sid_cargue { get; set; }
        /// 
 
        public String? filtro { get; set; }
#endregion Public Members    



    }
}





