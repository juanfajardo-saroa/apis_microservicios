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
        /// Clase Model Base para  PA_PrioSedeAsignaRacionPiv
        /// No haga cambios sobre esta clase,
        /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
        /// esta es una clase abstracta que decora la clase principal
        /// </Resumen>


        public class PA_PrioSedeAsignaRacionPivModelBase : ModelObject
        {
                public PA_PrioSedeAsignaRacionPivModelBase()
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
                /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Jornada 
                /// </Resumen> 
                [Display(Name = "Jornada")]
                [DataType(DataType.MultilineText)]
                public String? Jornada { get; set; }

                /// <Resumen>  
                /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Grado 
                /// </Resumen> 
                [Display(Name = "Grado")]
                [DataType(DataType.MultilineText)]
                public String? Grado { get; set; }

                /// <Resumen>  
                /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: Matricula 
                /// </Resumen> 
                [Display(Name = "Matricula")]
                public int? Matricula { get; set; }

                /// <Resumen>  
                /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: TotalRaciones 
                /// </Resumen> 
                [Display(Name = "Total Raciones")]
                public int? TotalRaciones { get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m1_ComplementoAlmuerzo 
        /// </Resumen> 
        [Display(Name = "m1 Complemento Almuerzo")] 
        public int? m1_ComplementoAlmuerzo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m1_ComplementoAlmuerzoCualificado 
        /// </Resumen> 
        [Display(Name = "m1 Complemento Almuerzo Cualificado")] 
        public int? m1_ComplementoAlmuerzoCualificado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m1_ComplementoAMPM 
        /// </Resumen> 
        [Display(Name = "m1 Complemento A M P M")] 
        public int? m1_ComplementoAMPM{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m2_ComplementoAlmuerzo 
        /// </Resumen> 
        [Display(Name = "m2 Complemento Almuerzo")] 
        public int? m2_ComplementoAlmuerzo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m2_ComplementoAlmuerzoCualificado 
        /// </Resumen> 
        [Display(Name = "m2 Complemento Almuerzo Cualificado")] 
        public int? m2_ComplementoAlmuerzoCualificado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m2_ComplementoAMPM 
        /// </Resumen> 
        [Display(Name = "m2 Complemento A M P M")] 
        public int? m2_ComplementoAMPM{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m3_ComplementoAlmuerzo 
        /// </Resumen> 
        [Display(Name = "m3 Complemento Almuerzo")] 
        public int? m3_ComplementoAlmuerzo{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m3_ComplementoAlmuerzoCualificado 
        /// </Resumen> 
        [Display(Name = "m3 Complemento Almuerzo Cualificado")] 
        public int? m3_ComplementoAlmuerzoCualificado{ get; set; }

        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: m3_ComplementoAMPM 
        /// </Resumen> 
        [Display(Name = "m3 Complemento A M P M")] 
        public int? m3_ComplementoAMPM{ get; set; }


                public String? filtro { get; set; }
                #endregion Public Members    



        }
}





