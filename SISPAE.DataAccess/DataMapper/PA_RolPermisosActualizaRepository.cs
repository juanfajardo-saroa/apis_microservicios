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
     /// Clase Abstracta para  PA_RolPermisosActualiza
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class PA_RolPermisosActualizaRepository : DataObject , IPA_RolPermisosActualiza 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public PA_RolPermisosActualizaRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public PA_RolPermisosActualizaRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods
	
			public List<PA_RolPermisosActualiza> GetPA_RolPermisosActualiza( int? id,String? id_Rol,int? id_Modulo,Boolean? Ver,Boolean? Crear,Boolean? Editar,Boolean? Eliminar,Boolean? Aprobar,Boolean? Imprimir,String? auditoria)
			{
				try
				{

					int? vintNUll = null;
					DynamicParameters p = new DynamicParameters();

					p.Add("@id",id);
p.Add("@id_Rol",id_Rol);
p.Add("@id_Modulo",id_Modulo);
p.Add("@Ver",Ver);
p.Add("@Crear",Crear);
p.Add("@Editar",Editar);
p.Add("@Eliminar",Eliminar);
p.Add("@Aprobar",Aprobar);
p.Add("@Imprimir",Imprimir);
p.Add("@auditoria",auditoria);

					List<PA_RolPermisosActualiza> l = SqlMapper.Query<PA_RolPermisosActualiza>(con, "Seguridad.PA_RolPermisosActualiza" , p, commandType: CommandType.StoredProcedure).AsList();

					return l;
				}
				catch (Exception ex)
				{
						throw new Exception("DataMapper:(GetPA_RolPermisosActualiza)  PA_RolPermisosActualiza  ->" + ex.Message);
				}
			}

		
	    #endregion Class Methods
	}

}