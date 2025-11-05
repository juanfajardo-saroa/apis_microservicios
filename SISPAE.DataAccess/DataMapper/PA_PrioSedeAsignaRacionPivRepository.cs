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
using System.Collections;
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
    /// Clase Abstracta para  PA_PrioSedeAsignaRacionPiv
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class PA_PrioSedeAsignaRacionPivRepository : DataObject, IPA_PrioSedeAsignaRacionPiv
    {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_PrioSedeAsignaRacionPivRepository()
        {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
        }

        public PA_PrioSedeAsignaRacionPivRepository(DataAccess.DataMapper.DataMapperSource dataSource)
        {
            _dataSource = dataSource;
        }

        #endregion Class Declarations

        #region Class Methods

        public IEnumerable GetPA_PrioSedeAsignaRacionPiv(int? Id_sede, int? id_Vigencia, int? jor, int? nivel, int? modalidad, int? tipoRac, int? relleno)
        {
            try
            {

                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id_sede", Id_sede);
                p.Add("@id_Vigencia",id_Vigencia);
                p.Add("@jor", jor);
                p.Add("@nivel", nivel);
                p.Add("@modalidad", modalidad);
                p.Add("@tipoRac", tipoRac);
                p.Add("@relleno", relleno);

                var l = con.Query("Priorizacion.PA_PrioSedeAsignaRacionPiv", p, commandType: CommandType.StoredProcedure);

                return l;
            }
            catch (Exception ex)
            {
                throw new Exception("DataMapper:(GetPA_PrioSedeAsignaRacionPiv)  PA_PrioSedeAsignaRacionPiv  ->" + ex.Message);
            }
        }


        #endregion Class Methods
    }

}