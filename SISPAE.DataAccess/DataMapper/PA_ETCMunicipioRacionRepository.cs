/// <Derechos_Reservados>
/// Aplicacion		:SISPAE 
/// Autor			:TiGlobal SAS y SoftManagement
/// Generacion		:Este archivo es generado automaticamente mediante generador :GeneraApp.
/// Ano				:2022
/// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS,
/// Capa			:DataAccess (DataAccess Access Layer) - Capa del DataMapper, Esta clase implementa la interface presentada, 
///                  aca desarrolla los metodos del CRUD para cada Objeto que representa los metodos que deben ser implementados 
///                  (Source: MVC7_DAL_DataMapperBase.Cs)   clase 
/// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SISPAE.Model;
using SISPAE.DataAccess.DataInterfaces;
using Dapper;
using static Dapper.SqlMapper;
using Z.Dapper.Plus;



namespace SISPAE.DataAccess.DataMapper
{
    /// <Resumen>
    /// Clase Abstracta para  PA_ETCMunicipioRacion
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class PA_ETCMunicipioRacionRepository : DataObject, IPA_ETCMunicipioRacion
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_ETCMunicipioRacionRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public PA_ETCMunicipioRacionRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public List<PA_ETCMunicipioRacion> GetPA_ETCMunicipioRacion(int? Id_ETC, int? Id_vigencia, int? Id_institucionEducativa)
        {
            try
            {

                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id_ETC", Id_ETC);
                p.Add("@Id_vigencia", Id_vigencia);
                p.Add("@Id_institucionEducativa", Id_institucionEducativa);

                List<PA_ETCMunicipioRacion> l = SqlMapper.Query<PA_ETCMunicipioRacion>(con, "Infraestructura.PA_ETCMunicipioRacion", p, commandType: CommandType.StoredProcedure).AsList();

                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetPA_ETCMunicipioRacion)  PA_ETCMunicipioRacion  ->" + ex.Message);
            }
        }


        #endregion Class Methods
    }

}