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
    /// Clase Abstracta para  PA_SeguimientoRacionesDetalleSemana
    /// No haga cambios sobre esta clase,
    /// 
    /// </Resumen>
    public partial class PA_SeguimientoRacionesDetalleSemanaRepository : DataObject, IPA_SeguimientoRacionesDetalleSemana
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_SeguimientoRacionesDetalleSemanaRepository()
            {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
            }

        public PA_SeguimientoRacionesDetalleSemanaRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        #endregion Class Declarations

        #region Class Methods

        public List<PA_SeguimientoRacionesDetalleSemana> GetPA_SeguimientoRacionesDetalleSemana(int? id_contrato, int? id_sede, int? id_jornada, DateTime? fecha)
            {
            try
                {

                int? vintNUll = null;
                DynamicParameters p = new DynamicParameters();

                p.Add("@id_contrato", id_contrato);
                p.Add("@id_sede", id_sede);
                p.Add("@id_jornada", id_jornada);
                p.Add("@fecha", fecha.Value);

                List<PA_SeguimientoRacionesDetalleSemana> l = SqlMapper.Query<PA_SeguimientoRacionesDetalleSemana>(con,
                    "SeguimientoRaciones.PA_SeguimientoRacionesDetalleSemana", p,
                    commandType: CommandType.StoredProcedure).AsList();

                List<PA_DiasPaeSemana> dps;

                for(int i = 0; i < l.Count; i++)
                    {
                    l[i].dias_pae = new List<PA_DiasPaeSemana>();

                    l[i].dias_pae
                        .AddRange(new PA_DiasPaeSemanaRepository().GetPA_DiasPaeSemana(l[i].Fecha_inicial,
                            l[i].Fecha_final, id_sede.Value));

                    }

                return l;
                }
            catch(Exception ex)
                {
                throw new Exception(
                    "DataMapper:(GetPA_SeguimientoRacionesDetalleSemana)  PA_SeguimientoRacionesDetalleSemana  ->" +
                    ex.Message);
                }

            #endregion Class Methods

            }

        }
    }