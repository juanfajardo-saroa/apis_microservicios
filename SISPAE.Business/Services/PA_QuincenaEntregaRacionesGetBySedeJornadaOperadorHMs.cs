/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:Business (Business Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_Business_Base.Cs)   clase 
/// </Derechos_Reservados>


using SISPAE.DataAccess.DataMapper;
using SISPAE.Model;





namespace SISPAE.Business
/// <Resumen>
/// Clase del Business  para  PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH
/// 
/// </Resumen>


    {



    #region Metodos de negocio


    public partial class PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHMs
        {

        #region Implementacion Metodos


        public List<PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH> GetPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH(int? Id_Operador, DateTime? FechaIni, DateTime? FechaFin)
            {
            var returnedEntities = new List<PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH>();

            try
                {
                using(var repository = new PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHRepository())
                    {
                    foreach(var entity in repository.GetPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH(Id_Operador, FechaIni, FechaFin))
                        {
                        returnedEntities.Add(entity);
                        }
                    }

                return returnedEntities;
                }
            catch(Exception ex)
                {
                throw new Exception("BusinessLogic:PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHBusiness::GetPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHError occured.::Error occured. "+ ex.Message.ToString(), ex);
                }
            }











        #endregion Implementacion Metodos


        }
    #endregion Metodos de Negocio

    }