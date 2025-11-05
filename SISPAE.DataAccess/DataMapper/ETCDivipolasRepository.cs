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
     /// Clase Abstracta para  ETCDivipolas
     /// No haga cambios sobre esta clase,
     /// 
     /// </Resumen>
	public partial class ETCDivipolasRepository : DataObject , IETCDivipolas 
        {
		#region Class Declarations

			private readonly DataAccess.DataMapper.DataMapperSource _dataSource;
            private readonly SqlConnection con;


			 public ETCDivipolasRepository() 
            {
				_dataSource = new DataMapperSource();
                con = new SqlConnection(_dataSource.cadena);
            }			
			
			public ETCDivipolasRepository(DataAccess.DataMapper.DataMapperSource dataSource) 
			{
				_dataSource = dataSource;
			}
		
		#endregion Class Declarations

		#region Class Methods

			public ETCDivipolas GetById(ETCDivipolas pETCDivipolas)
            {

                try  
                   {    
                     DynamicParameters p = new DynamicParameters();
p.Add("@id",pETCDivipolas.id);                                    


    				ETCDivipolas o = SqlMapper.QueryFirstOrDefault<ETCDivipolas>(con, "API.PA_ETCDivipolasGetByKey", p, commandType: CommandType.StoredProcedure);
					return o;
					
					}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetById)  ETCDivipolas  ->" + ex.Message);
				}
			}

			public List<ETCDivipolas> GetAll()
			{
				try 
                {
                        List<ETCDivipolas> l = SqlMapper.Query<ETCDivipolas>(con, "API.PA_ETCDivipolasGetAll").AsList();
					    return l;
			    }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAll)  ETCDivipolas  ->" + ex.Message);
				}
			}

			public List<ETCDivipolas> GetAllFull()
			{
				try 
				{
                    List<ETCDivipolas> l = SqlMapper.Query<ETCDivipolas>(con, "API.PA_ETCDivipolasGetAllFull").AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllFull)  ETCDivipolas  ->" + ex.Message);
				}
			}
			
			public List<ETCDivipolas> GetAllByWithRelation()
			{
				try 
                {
                    List<ETCDivipolas> l = SqlMapper.Query<ETCDivipolas>(con, "API.PA_ETCDivipolasGetAllWithRelation").AsList();
                    return l;
                }
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetAllByWithRelation)  ETCDivipolas  ->" + ex.Message);
				}
			}
			
 
						
			
			public List<ETCDivipolas> GetByFilter(ETCDivipolas pETCDivipolas, int pageSize , int Page , string OrderByC )
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

                                        p.Add("@id",(pETCDivipolas.id== null || pETCDivipolas.id==0) ? vintNUll :pETCDivipolas.id);
                    p.Add("@DepartamentoCode",(pETCDivipolas.DepartamentoCode== null) ? vintNUll :pETCDivipolas.DepartamentoCode);
                    p.Add("@MunicipioCode",(pETCDivipolas.MunicipioCode== null) ? vintNUll :pETCDivipolas.MunicipioCode);
                    p.Add("@CentroPobladoCode",(pETCDivipolas.CentroPobladoCode== null) ? vintNUll :pETCDivipolas.CentroPobladoCode);
                    p.Add("@DepartamentoNombre",(pETCDivipolas.DepartamentoNombre== null) ? vintNUll :pETCDivipolas.DepartamentoNombre);
                    p.Add("@Nombre",(pETCDivipolas.Nombre== null) ? vintNUll :pETCDivipolas.Nombre);
                    p.Add("@CentroPobladoNombre",(pETCDivipolas.CentroPobladoNombre== null) ? vintNUll :pETCDivipolas.CentroPobladoNombre);
                    p.Add("@ETCNombre",(pETCDivipolas.ETCNombre== null) ? vintNUll :pETCDivipolas.ETCNombre);
                    p.Add("@diagnostico",(pETCDivipolas.diagnostico== null) ? vintNUll :pETCDivipolas.diagnostico);
                        p.Add("@TamPag",pageSize);
                        p.Add("@pag",Page);
                        p.Add("@OrdenBy",OrderByC);

                         

                    List<ETCDivipolas> l = SqlMapper.Query<ETCDivipolas>(con, "API.PA_ETCDivipolasGetByFilter", p, commandType: CommandType.StoredProcedure).AsList();
					return l;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(GetByFilter)  ETCDivipolas  ->" + ex.Message);
				}
			}

			public ETCDivipolas Add(ETCDivipolas pETCDivipolas)
			{
				try 
				{
                    int? vintNUll = null;
                    DynamicParameters p = new DynamicParameters();

					p.Add("@id",pETCDivipolas.id==null ? 0 : pETCDivipolas.id);
                    p.Add("@DepartamentoCode", pETCDivipolas.DepartamentoCode);
                    p.Add("@MunicipioCode", pETCDivipolas.MunicipioCode);
                    p.Add("@CentroPobladoCode", pETCDivipolas.CentroPobladoCode);
                    p.Add("@DepartamentoNombre", pETCDivipolas.DepartamentoNombre);
                    p.Add("@Nombre", pETCDivipolas.Nombre);
                    p.Add("@CentroPobladoNombre", pETCDivipolas.CentroPobladoNombre);
                    p.Add("@ETCNombre", pETCDivipolas.ETCNombre);
                    p.Add("@diagnostico", pETCDivipolas.diagnostico);
                    p.Add("@auditoria", pETCDivipolas.auditoria);

                         


                    ETCDivipolas o = SqlMapper.QueryFirstOrDefault<ETCDivipolas>(con, "API.PA_ETCDivipolasAdd", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Add)  ETCDivipolas  ->" + ex.Message);
				}
			}

			public ETCDivipolas  Update(ETCDivipolas pETCDivipolas)
			{
				try 
				{
					int? vintNUll = null;

                    DynamicParameters p= new DynamicParameters();
			
					p.Add("@id",pETCDivipolas.id==null ? 0 : pETCDivipolas.id);
                    p.Add("@DepartamentoCode", pETCDivipolas.DepartamentoCode);
                    p.Add("@MunicipioCode", pETCDivipolas.MunicipioCode);
                    p.Add("@CentroPobladoCode", pETCDivipolas.CentroPobladoCode);
                    p.Add("@DepartamentoNombre", pETCDivipolas.DepartamentoNombre);
                    p.Add("@Nombre", pETCDivipolas.Nombre);
                    p.Add("@CentroPobladoNombre", pETCDivipolas.CentroPobladoNombre);
                    p.Add("@ETCNombre", pETCDivipolas.ETCNombre);
                    p.Add("@diagnostico", pETCDivipolas.diagnostico);
                    p.Add("@auditoria", pETCDivipolas.auditoria);

                         


                    ETCDivipolas o = SqlMapper.QueryFirstOrDefault<ETCDivipolas>(con, "API.PA_ETCDivipolasUpdate", p, commandType: CommandType.StoredProcedure);

                    return o;
				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper:(Update)  ETCDivipolas  ->" + ex.Message);
				}
			}

			public bool Delete(ETCDivipolas pETCDivipolas)
        {
                 try
                 {
DynamicParameters p = new DynamicParameters();
p.Add("@id",pETCDivipolas.id);
                    p.Add("@auditoria", pETCDivipolas.auditoria);

                

 

					ETCDivipolas o = SqlMapper.QueryFirstOrDefault<ETCDivipolas>(con, "API.PA_ETCDivipolasDelete", p, commandType: CommandType.StoredProcedure);

                return true;

				}
				catch (Exception ex)
				{
					throw new Exception("DataMapper: (Delete) ETCDivipolas  ->" + ex.Message);
				}
			}

		



            public List<ETCDivipolas> execProcedureQuery(DynamicParameters sqlparametersvaluesList, string Procedimiento)
            {
                try
                {
                    List<ETCDivipolas> ETCDivipolasList = new List<ETCDivipolas>();

                    ETCDivipolasList = SqlMapper.Query<ETCDivipolas>(con, Procedimiento, sqlparametersvaluesList, commandType: CommandType.StoredProcedure).AsList();

                    return ETCDivipolasList;
                }
                catch (Exception ex)
                {
                    throw new Exception("DataMapper:(ExecProcedureQuery) ETCDivipolas  ->" + ex.Message);
                }
            }


            public void BulkInsert(List<ETCDivipolas> b)
            {
                DapperPlusManager.Entity<ETCDivipolas>().Table("ETCDivipolas");
                con.BulkInsert(b);
            }
		}
	#endregion Class Methods

}