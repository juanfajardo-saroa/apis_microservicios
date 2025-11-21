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
     /// Clase Model Base para  PA_PrioSedeAsignaRacion
     /// No haga cambios sobre esta clase,
     /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
     /// esta es una clase abstracta que decora la clase principal
     /// </Resumen>
	 	 
	
    public class PA_PrioSedeAsignaRacionModelBase : ModelObject
    {
		    public PA_PrioSedeAsignaRacionModelBase() 
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
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        public int? id_Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Municipio 
        /// </Resumen> 
        [Display(Name = "Municipio")] 
        [DataType (DataType.MultilineText)]   
        public String? Municipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_InstEducativa 
        /// </Resumen> 
        [Display(Name = "Inst Educativa")] 
        public int? id_InstEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: InstEducativa 
        /// </Resumen> 
        [Display(Name = "Inst Educativa")] 
        [DataType (DataType.MultilineText)]   
        public String? InstEducativa{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_sede 
        /// </Resumen> 
        [Display(Name = "sede")] 
        public int? id_sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Sede 
        /// </Resumen> 
        [Display(Name = "Sede")] 
        [DataType (DataType.MultilineText)]   
        public String? Sede{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: CodigoDane 
        /// </Resumen> 
        [Display(Name = "Codigo Dane")]    
        public String? CodigoDane{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: MatriculaSIMAT 
        /// </Resumen> 
        [Display(Name = "Matricula S I M A T")] 
        public int? MatriculaSIMAT{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOperacion 
        /// </Resumen> 
        [Display(Name = "Modelo Operacion")] 
        [DataType (DataType.MultilineText)]   
        public String? ModeloOperacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModeloOperacionER 
        /// </Resumen> 
        [Display(Name = "Modelo Operacion E R")] 
        [DataType (DataType.MultilineText)]   
        public String? ModeloOperacionER{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: ModalidadSugerida 
        /// </Resumen> 
        [Display(Name = "Modalidad Sugerida")] 
        [DataType (DataType.MultilineText)]   
        public String? ModalidadSugerida{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: RacionDiaria 
        /// </Resumen> 
        [Display(Name = "Racion Diaria")] 
        public int? RacionDiaria{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_TipoMunicipio 
        /// </Resumen> 
        [Display(Name = "Tipo Municipio")] 
        public int? Id_TipoMunicipio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Jornada 
        /// </Resumen> 
        [Display(Name = "Jornada")] 
        public int? Id_Jornada{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_NivelEducativo 
        /// </Resumen> 
        [Display(Name = "Nivel Educativo")] 
        public int? Id_NivelEducativo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_Zona 
        /// </Resumen> 
        [Display(Name = "Zona")] 
        public int? Id_Zona{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_CriterioVul 
        /// </Resumen> 
        [Display(Name = "Criterio Vul")] 
        public int? Id_CriterioVul{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Id_EstadoPrio 
        /// </Resumen> 
        [Display(Name = "Estado Prio")] 
        public int? Id_EstadoPrio{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: EstadoPriorizacion 
        /// </Resumen> 
        [Display(Name = "Estado Priorizacion")] 
        [DataType (DataType.MultilineText)]   
        public String? EstadoPriorizacion{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: BanderaAmarilla 
        /// </Resumen> 
        [Display(Name = "Bandera Amarilla")] 
        public int? BanderaAmarilla{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: BanderaRoja 
        /// </Resumen> 
        [Display(Name = "Bandera Roja")] 
        public int? BanderaRoja{ get; set; }

        public String? filtro { get; set; }
#endregion Public Members    



    }
}





