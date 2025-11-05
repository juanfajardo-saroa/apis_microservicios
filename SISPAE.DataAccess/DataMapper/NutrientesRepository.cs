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
     /// Clase Abstracta para  Nutrientes
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class NutrientesRepository : DataObject , INutrientes 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public NutrientesRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public NutrientesRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public Nutrientes GetById(Nutrientes pNutrientes)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientes.id);                                    


    				Nutrientes o = SqlMapper.QueryFirstOrDefault<Nutrientes>(con, "API.PA_NutrientesGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  Nutrientes  ->" + ex.Message);
				}
			}

			public List<Nutrientes> GetAll()
			{
				try 
                {
                        List<Nutrientes> l = SqlMapper.Query<Nutrientes>(con, "API.PA_NutrientesGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  Nutrientes  ->" + ex.Message);
				}
			}

			public List<Nutrientes> GetAllFull()
			{
				try 
				{
                    List<Nutrientes> l = SqlMapper.Query<Nutrientes>(con, "API.PA_NutrientesGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  Nutrientes  ->" + ex.Message);
				}
			}
			
			public List<Nutrientes> GetAllByWithRelation()
			{
				try 
                {
                    List<Nutrientes> l = SqlMapper.Query<Nutrientes>(con, "API.PA_NutrientesGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  Nutrientes  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<Nutrientes> GetByFilter(Nutrientes pNutrientes, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pNutrientes.id== null || pNutrientes.id==0) ? vintNUll :pNutrientes.id);
                    p.Add("@ID_TipoNutriente",(pNutrientes.ID_TipoNutriente== null || pNutrientes.ID_TipoNutriente==0) ? vintNUll :pNutrientes.ID_TipoNutriente);
                    p.Add("@Nombre",(pNutrientes.Nombre== null) ? vintNUll :pNutrientes.Nombre);
                    p.Add("@Calculado",(pNutrientes.Calculado== null) ? vintNUll :pNutrientes.Calculado);
                    p.Add("@Porcentaje",(pNutrientes.Porcentaje== null) ? vintNUll :pNutrientes.Porcentaje);
                    p.Add("@ValorConstante",(pNutrientes.ValorConstante== null) ? vintNUll :pNutrientes.ValorConstante);
                    p.Add("@Id_NutrienteBase",(pNutrientes.Id_NutrienteBase== null || pNutrientes.Id_NutrienteBase==0) ? vintNUll :pNutrientes.Id_NutrienteBase);
                    p.Add("@orden",(pNutrientes.orden== null) ? vintNUll :pNutrientes.orden);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<Nutrientes> l = SqlMapper.Query<Nutrientes>(con, "API.PA_NutrientesGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  Nutrientes  ->" + ex.Message);
				}
			}

			public Nutrientes Add(Nutrientes pNutrientes)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pNutrientes.id==null ? 0 : pNutrientes.id);
p.Add("@ID_TipoNutriente",pNutrientes.ID_TipoNutriente==null ? 0 : pNutrientes.ID_TipoNutriente);
                    p.Add("@Nombre", pNutrientes.Nombre);
                    p.Add("@Calculado", pNutrientes.Calculado);
                    p.Add("@Porcentaje", pNutrientes.Porcentaje);
p.Add("@ValorConstante",pNutrientes.ValorConstante==null ? 0 : pNutrientes.ValorConstante);
p.Add("@Id_NutrienteBase",pNutrientes.Id_NutrienteBase==null ? 0 : pNutrientes.Id_NutrienteBase);
p.Add("@orden",pNutrientes.orden==null ? 0 : pNutrientes.orden);
                    p.Add("@auditoria", pNutrientes.auditoria);

                         


                    Nutrientes o = SqlMapper.QueryFirstOrDefault<Nutrientes>(con, "API.PA_NutrientesAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  Nutrientes  ->" + ex.Message);
				}
			}

			public Nutrientes  Update(Nutrientes pNutrientes)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pNutrientes.id==null ? 0 : pNutrientes.id);
p.Add("@ID_TipoNutriente",pNutrientes.ID_TipoNutriente==null ? 0 : pNutrientes.ID_TipoNutriente);
                    p.Add("@Nombre", pNutrientes.Nombre);
                    p.Add("@Calculado", pNutrientes.Calculado);
                    p.Add("@Porcentaje", pNutrientes.Porcentaje);
p.Add("@ValorConstante",pNutrientes.ValorConstante==null ? 0 : pNutrientes.ValorConstante);
p.Add("@Id_NutrienteBase",pNutrientes.Id_NutrienteBase==null ? 0 : pNutrientes.Id_NutrienteBase);
p.Add("@orden",pNutrientes.orden==null ? 0 : pNutrientes.orden);
                    p.Add("@auditoria", pNutrientes.auditoria);

                         


                    Nutrientes o = SqlMapper.QueryFirstOrDefault<Nutrientes>(con, "API.PA_NutrientesUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  Nutrientes  ->" + ex.Message);
				}
			}

			public bool Delete(Nutrientes pNutrientes)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pNutrientes.id);
                    p.Add("@auditoria", pNutrientes.auditoria);

                

 

					Nutrientes o = SqlMapper.QueryFirstOrDefault<Nutrientes>(con, "API.PA_NutrientesDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) Nutrientes  ->" + ex.Message);
				}
			}

		



            public List<Nutrientes> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<Nutrientes> NutrientesList = new List<Nutrientes>();

                    NutrientesList = SqlMapper.Query<Nutrientes>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return NutrientesList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) Nutrientes  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<Nutrientes> b)
            {
                DapperPlusManager.Entity<Nutrientes>().Table("Nutrientes");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}