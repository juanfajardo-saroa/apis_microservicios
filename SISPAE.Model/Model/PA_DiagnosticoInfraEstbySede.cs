using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SISPAE.Model
{
    /// <Resumen>
    /// Clase Model Base para  PA_DiagnosticoInfraEst
    /// No haga cambios sobre esta clase,
    /// El codigo adicional debe insertarlo en la clase derivada o parcial o en el business que se ecnuentra en la subraiz  
    /// esta es una clase abstracta que decora la clase principal
    /// </Resumen>


    public class PA_DiagnosticoInfraEstbySedeModelBase : ModelObject
    {
        public PA_DiagnosticoInfraEstbySedeModelBase()
        {
        }

        ///  Estas son las propiedades Base de esta clase  
        ///    
        /// <Resumen>  
        /// ( Gets or Sets ) Obtiene o establece el valor de la propiedad: id_sede 
        /// </Resumen> 
        [Display(Name = "Afectadas")]
        public int Afectadas { get; set; }





    }
}





