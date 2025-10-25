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


using Dapper;

using SISPAE.DataAccess.DataInterfaces;
using SISPAE.Model;

using System.Data;
using System.Data.SqlClient;

using static Dapper.SqlMapper;



namespace SISPAE.DataAccess.DataMapper
    {
    /// <Resumen>
    /// Clase Abstracta para  PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHRepository : DataObject, IPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHRepository()
            {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
            }

        public PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations

        #region Class Methods

        public List<PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH> GetPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH(int? Id_Operador, DateTime? Fecha_Ini, DateTime? Fecha_Fin)
            {
            try
                {

                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@Id_Operador", Id_Operador);
                p.Add("@Fecha_Ini", Fecha_Ini);
                p.Add("@Fecha_Fin", Fecha_Fin);

                List<PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH> l = SqlMapper.Query<PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH>(con, "SeguimientoRaciones.PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH", p, commandType: CommandType.StoredProcedure).AsList();

                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH)  PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH  ->" + ex.Message);
                }
            }


        #endregion Class Methods
        }

    }