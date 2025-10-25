using Dapper;

using SISPAE.DataAccess.DataInterfaces;
using SISPAE.Model;

using System.Data;
using System.Data.SqlClient;

namespace SISPAE.DataAccess.DataMapper
    {
    public partial class PA_PriorizaUpdateEstadoPrioRepository : DataObject, IPA_PriorizaUpdateEstadoPrio
        {
        #region Class Declarations

        private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
        private readonly SqlConnection con;


        public PA_PriorizaUpdateEstadoPrioRepository()
            {
            _dataSource = new DataMapperSource();
            con = new SqlConnection(_dataSource.cadena);
            }

        public PA_PriorizaUpdateEstadoPrioRepository(DataAccess.DataMapper.DataMapperSource dataSource)
            {
            _dataSource = dataSource;
            }

        public List<PA_PriorizaUpdateEstadoPrio> GetPA_PriorizaUpdateEstadoPrio(int? id_Sede, int? id_Vigencia, int? ID_TipoEstadoPriorizacion, string? auditoria)
            {
            throw new NotImplementedException();
            }

        #endregion Class Declarations


        #region Class Methods

        public int PA_PriorizaUpdateEstadoPrio(int? id_Sede, int? id_Vigencia, int? ID_TipoEstadoPriorizacion, string? auditoria)
            {
            try
                {
                DynamicParameters p = new DynamicParameters();

                p.Add("@id_Sede ", id_Sede);
                p.Add("@ID_TipoEstadoPriorizacion ", ID_TipoEstadoPriorizacion);
                p.Add("@auditoria", auditoria);
                p.Add("@id_Vigencia", id_Vigencia);

                int l = SqlMapper.Query<int>(con, "Priorizacion.PA_PriorizaUpdateEstadoPrio", p, commandType: CommandType.StoredProcedure).FirstOrDefault();

                return l;
                }
            catch(Exception ex)
                {
                throw new Exception("DataMapper:(GetPA_ETCMunicipioRacion)  PA_ETCMunicipioRacion  ->" + ex.Message);
                }
            }


        #endregion Class Methods

        }


    }
