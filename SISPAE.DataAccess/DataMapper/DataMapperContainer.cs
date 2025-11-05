/// <Derechos_Reservados>
  /// Aplicacion		:SISPAE 
  /// Autor			:TiGlobal SAS y SoftManagement
  /// Generacion		:Este archivo es generado automaticamente mediante generador GeneraApp.
  /// Ano			    :2022
  /// Arquitectura	:Patron MVC Repository Microservicios Net Core ,Bootstrap, AJAX, JSON, JQuery, Razor, SQL Server, IIS, 
  /// Capa			:DataAccess (Data Access Layer) - Contenedor de 	Interfaces Repository  (Source: MVC7_DataMaperInterface.cs)   Interfaces 
  /// </Derechos_Reservados>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISPAE.DataAccess.DataInterfaces;


namespace SISPAE.DataAccess.DataMapper
{
    public class DataMapperContainer : IRepositoryContainer
    {

      private readonly DataMapperSource _dataSource;

        public DataMapperContainer(DataMapperSource dataSource) 
        {
            _dataSource = dataSource;
        }

		        public IPA_EstadoNotificaciones PA_EstadoNotificaciones
            {
                get{return new PA_EstadoNotificacionesRepository(_dataSource);            }
                set{new PA_EstadoNotificacionesRepository(_dataSource);}
            }

        public IPA_ObtenerNotificaciones PA_ObtenerNotificaciones
            {
                get{return new PA_ObtenerNotificacionesRepository(_dataSource);            }
                set{new PA_ObtenerNotificacionesRepository(_dataSource);}
            }

        public IPA_RegistrarNotificacion PA_RegistrarNotificacion
            {
                get{return new PA_RegistrarNotificacionRepository(_dataSource);            }
                set{new PA_RegistrarNotificacionRepository(_dataSource);}
            }

        public IPA_AprobacionesGetAllWithRel PA_AprobacionesGetAllWithRel
            {
                get{return new PA_AprobacionesGetAllWithRelRepository(_dataSource);            }
                set{new PA_AprobacionesGetAllWithRelRepository(_dataSource);}
            }

        public IPA_MunicipiosGetbyContrato PA_MunicipiosGetbyContrato
            {
                get{return new PA_MunicipiosGetbyContratoRepository(_dataSource);            }
                set{new PA_MunicipiosGetbyContratoRepository(_dataSource);}
            }

        public IPA_SedeExcedentes PA_SedeExcedentes
            {
                get{return new PA_SedeExcedentesRepository(_dataSource);            }
                set{new PA_SedeExcedentesRepository(_dataSource);}
            }

        public IPA_ContratosCantidadBeneficiarios PA_ContratosCantidadBeneficiarios
            {
                get{return new PA_ContratosCantidadBeneficiariosRepository(_dataSource);            }
                set{new PA_ContratosCantidadBeneficiariosRepository(_dataSource);}
            }

        public IPA_ContratosGetbyOperador PA_ContratosGetbyOperador
            {
                get{return new PA_ContratosGetbyOperadorRepository(_dataSource);            }
                set{new PA_ContratosGetbyOperadorRepository(_dataSource);}
            }

        public IPA_ContratosIE PA_ContratosIE
            {
                get{return new PA_ContratosIERepository(_dataSource);            }
                set{new PA_ContratosIERepository(_dataSource);}
            }

        public IPA_ContratosSedeJornadaBeneficiarios PA_ContratosSedeJornadaBeneficiarios
            {
                get{return new PA_ContratosSedeJornadaBeneficiariosRepository(_dataSource);            }
                set{new PA_ContratosSedeJornadaBeneficiariosRepository(_dataSource);}
            }

        public IPA_ContratosSedeJornadaListaBenef PA_ContratosSedeJornadaListaBenef
            {
                get{return new PA_ContratosSedeJornadaListaBenefRepository(_dataSource);            }
                set{new PA_ContratosSedeJornadaListaBenefRepository(_dataSource);}
            }

        public IPA_ContratosSedeJornadaRPI PA_ContratosSedeJornadaRPI
            {
                get{return new PA_ContratosSedeJornadaRPIRepository(_dataSource);            }
                set{new PA_ContratosSedeJornadaRPIRepository(_dataSource);}
            }

        public IPA_ContratosSedeNovedades PA_ContratosSedeNovedades
            {
                get{return new PA_ContratosSedeNovedadesRepository(_dataSource);            }
                set{new PA_ContratosSedeNovedadesRepository(_dataSource);}
            }

        public IPA_OperadorContratos PA_OperadorContratos
            {
                get{return new PA_OperadorContratosRepository(_dataSource);            }
                set{new PA_OperadorContratosRepository(_dataSource);}
            }

        public IPA_ReporteExcedentes PA_ReporteExcedentes
            {
                get{return new PA_ReporteExcedentesRepository(_dataSource);            }
                set{new PA_ReporteExcedentesRepository(_dataSource);}
            }

        public IGetCaracterizacionNivel GetCaracterizacionNivel
            {
                get{return new GetCaracterizacionNivelRepository(_dataSource);            }
                set{new GetCaracterizacionNivelRepository(_dataSource);}
            }

        public IGetCaracterizacionNivel2 GetCaracterizacionNivel2
            {
                get{return new GetCaracterizacionNivel2Repository(_dataSource);            }
                set{new GetCaracterizacionNivel2Repository(_dataSource);}
            }

        public IGetCaracterizacionNivel3 GetCaracterizacionNivel3
            {
                get{return new GetCaracterizacionNivel3Repository(_dataSource);            }
                set{new GetCaracterizacionNivel3Repository(_dataSource);}
            }

        public IGetCaracterizacionNivel4 GetCaracterizacionNivel4
            {
                get{return new GetCaracterizacionNivel4Repository(_dataSource);            }
                set{new GetCaracterizacionNivel4Repository(_dataSource);}
            }

        public IGetCaracterizacionValidacion GetCaracterizacionValidacion
            {
                get{return new GetCaracterizacionValidacionRepository(_dataSource);            }
                set{new GetCaracterizacionValidacionRepository(_dataSource);}
            }

        public IPA_DiagnosticoInfraEst PA_DiagnosticoInfraEst
            {
                get{return new PA_DiagnosticoInfraEstRepository(_dataSource);            }
                set{new PA_DiagnosticoInfraEstRepository(_dataSource);}
            }

        public IPA_DiagnosticoSituacionalGetAllFullbyEtc PA_DiagnosticoSituacionalGetAllFullbyEtc
            {
                get{return new PA_DiagnosticoSituacionalGetAllFullbyEtcRepository(_dataSource);            }
                set{new PA_DiagnosticoSituacionalGetAllFullbyEtcRepository(_dataSource);}
            }

        public IPA_ETCMunicipioRacion PA_ETCMunicipioRacion
            {
                get{return new PA_ETCMunicipioRacionRepository(_dataSource);            }
                set{new PA_ETCMunicipioRacionRepository(_dataSource);}
            }

        public IPA_ETCSedesCHSFavorable PA_ETCSedesCHSFavorable
            {
                get{return new PA_ETCSedesCHSFavorableRepository(_dataSource);            }
                set{new PA_ETCSedesCHSFavorableRepository(_dataSource);}
            }

        public IPA_MatrizRiesgoModOper PA_MatrizRiesgoModOper
            {
                get{return new PA_MatrizRiesgoModOperRepository(_dataSource);            }
                set{new PA_MatrizRiesgoModOperRepository(_dataSource);}
            }

        public IPA_MatrizRiesgosSede PA_MatrizRiesgosSede
            {
                get{return new PA_MatrizRiesgosSedeRepository(_dataSource);            }
                set{new PA_MatrizRiesgosSedeRepository(_dataSource);}
            }

        public IPA_MatrizRiesgosSedeDetalleArea PA_MatrizRiesgosSedeDetalleArea
            {
                get{return new PA_MatrizRiesgosSedeDetalleAreaRepository(_dataSource);            }
                set{new PA_MatrizRiesgosSedeDetalleAreaRepository(_dataSource);}
            }

        public IPA_MatrizRiesgosSedeDetalleDimension PA_MatrizRiesgosSedeDetalleDimension
            {
                get{return new PA_MatrizRiesgosSedeDetalleDimensionRepository(_dataSource);            }
                set{new PA_MatrizRiesgosSedeDetalleDimensionRepository(_dataSource);}
            }

        public IPA_RiesgoETCModeloOper PA_RiesgoETCModeloOper
            {
                get{return new PA_RiesgoETCModeloOperRepository(_dataSource);            }
                set{new PA_RiesgoETCModeloOperRepository(_dataSource);}
            }

        public IPA_RiesgoETCSedesModeloOper PA_RiesgoETCSedesModeloOper
            {
                get{return new PA_RiesgoETCSedesModeloOperRepository(_dataSource);            }
                set{new PA_RiesgoETCSedesModeloOperRepository(_dataSource);}
            }

        public IPA_SedePregRespuesta PA_SedePregRespuesta
            {
                get{return new PA_SedePregRespuestaRepository(_dataSource);            }
                set{new PA_SedePregRespuestaRepository(_dataSource);}
            }

        public IPA_ContratosPlanAlistamientoGetAll PA_ContratosPlanAlistamientoGetAll
            {
                get{return new PA_ContratosPlanAlistamientoGetAllRepository(_dataSource);            }
                set{new PA_ContratosPlanAlistamientoGetAllRepository(_dataSource);}
            }

        public IPA_ActualiarFlatAmarilla PA_ActualiarFlatAmarilla
            {
                get{return new PA_ActualiarFlatAmarillaRepository(_dataSource);            }
                set{new PA_ActualiarFlatAmarillaRepository(_dataSource);}
            }

        public IPA_DivipolasGetbyETC PA_DivipolasGetbyETC
            {
                get{return new PA_DivipolasGetbyETCRepository(_dataSource);            }
                set{new PA_DivipolasGetbyETCRepository(_dataSource);}
            }

        public IPA_ETCSedesPriorizacion PA_ETCSedesPriorizacion
            {
                get{return new PA_ETCSedesPriorizacionRepository(_dataSource);            }
                set{new PA_ETCSedesPriorizacionRepository(_dataSource);}
            }

        public IPA_InstutucionesEduGetbyETC PA_InstutucionesEduGetbyETC
            {
                get{return new PA_InstutucionesEduGetbyETCRepository(_dataSource);            }
                set{new PA_InstutucionesEduGetbyETCRepository(_dataSource);}
            }

        public IPA_JornadaGetbyETC PA_JornadaGetbyETC
            {
                get{return new PA_JornadaGetbyETCRepository(_dataSource);            }
                set{new PA_JornadaGetbyETCRepository(_dataSource);}
            }

        public IPA_ModalidadModelobySede PA_ModalidadModelobySede
            {
                get{return new PA_ModalidadModelobySedeRepository(_dataSource);            }
                set{new PA_ModalidadModelobySedeRepository(_dataSource);}
            }

        public IPA_NivelEduGetbyETC PA_NivelEduGetbyETC
            {
                get{return new PA_NivelEduGetbyETCRepository(_dataSource);            }
                set{new PA_NivelEduGetbyETCRepository(_dataSource);}
            }

        public IPA_Paso1Fin PA_Paso1Fin
            {
                get{return new PA_Paso1FinRepository(_dataSource);            }
                set{new PA_Paso1FinRepository(_dataSource);}
            }

        public IPA_PrioAsistida PA_PrioAsistida
            {
                get{return new PA_PrioAsistidaRepository(_dataSource);            }
                set{new PA_PrioAsistidaRepository(_dataSource);}
            }

        public IPA_PriorizacionesContratoGetAllWithRel PA_PriorizacionesContratoGetAllWithRel
            {
                get{return new PA_PriorizacionesContratoGetAllWithRelRepository(_dataSource);            }
                set{new PA_PriorizacionesContratoGetAllWithRelRepository(_dataSource);}
            }

        public IPA_PriorizacionesGetAllWithRel PA_PriorizacionesGetAllWithRel
            {
                get{return new PA_PriorizacionesGetAllWithRelRepository(_dataSource);            }
                set{new PA_PriorizacionesGetAllWithRelRepository(_dataSource);}
            }

        public IPA_PriorizaUpdateEstadoPrio PA_PriorizaUpdateEstadoPrio
            {
                get{return new PA_PriorizaUpdateEstadoPrioRepository(_dataSource);            }
                set{new PA_PriorizaUpdateEstadoPrioRepository(_dataSource);}
            }

        public IPA_PrioSedeAsignaRacion PA_PrioSedeAsignaRacion
            {
                get{return new PA_PrioSedeAsignaRacionRepository(_dataSource);            }
                set{new PA_PrioSedeAsignaRacionRepository(_dataSource);}
            }

        public IPA_PrioSedeAsignaRacionPiv PA_PrioSedeAsignaRacionPiv
            {
                get{return new PA_PrioSedeAsignaRacionPivRepository(_dataSource);            }
                set{new PA_PrioSedeAsignaRacionPivRepository(_dataSource);}
            }

        public IPA_PrioSedeBeneficiarias PA_PrioSedeBeneficiarias
            {
                get{return new PA_PrioSedeBeneficiariasRepository(_dataSource);            }
                set{new PA_PrioSedeBeneficiariasRepository(_dataSource);}
            }

        public IPA_PrioSedeInformacion PA_PrioSedeInformacion
            {
                get{return new PA_PrioSedeInformacionRepository(_dataSource);            }
                set{new PA_PrioSedeInformacionRepository(_dataSource);}
            }

        public IPA_SedeGetbyETC PA_SedeGetbyETC
            {
                get{return new PA_SedeGetbyETCRepository(_dataSource);            }
                set{new PA_SedeGetbyETCRepository(_dataSource);}
            }

        public IPA_TiporacionbyModalidad PA_TiporacionbyModalidad
            {
                get{return new PA_TiporacionbyModalidadRepository(_dataSource);            }
                set{new PA_TiporacionbyModalidadRepository(_dataSource);}
            }

        public IPA_ZonaGetbyETC PA_ZonaGetbyETC
            {
                get{return new PA_ZonaGetbyETCRepository(_dataSource);            }
                set{new PA_ZonaGetbyETCRepository(_dataSource);}
            }

        public IPA_AporteNutricionalAlimentoICBF PA_AporteNutricionalAlimentoICBF
            {
                get{return new PA_AporteNutricionalAlimentoICBFRepository(_dataSource);            }
                set{new PA_AporteNutricionalAlimentoICBFRepository(_dataSource);}
            }

        public IPA_AporteNutricionalAlimentoICBFDet PA_AporteNutricionalAlimentoICBFDet
            {
                get{return new PA_AporteNutricionalAlimentoICBFDetRepository(_dataSource);            }
                set{new PA_AporteNutricionalAlimentoICBFDetRepository(_dataSource);}
            }

        public IPA_AporteNutricionalIngredientes PA_AporteNutricionalIngredientes
            {
                get{return new PA_AporteNutricionalIngredientesRepository(_dataSource);            }
                set{new PA_AporteNutricionalIngredientesRepository(_dataSource);}
            }

        public IPA_AporteNutricionalIngredientesDet PA_AporteNutricionalIngredientesDet
            {
                get{return new PA_AporteNutricionalIngredientesDetRepository(_dataSource);            }
                set{new PA_AporteNutricionalIngredientesDetRepository(_dataSource);}
            }

        public IPA_AporteNutricionalProducto PA_AporteNutricionalProducto
            {
                get{return new PA_AporteNutricionalProductoRepository(_dataSource);            }
                set{new PA_AporteNutricionalProductoRepository(_dataSource);}
            }

        public IPA_AporteNutricionalProductoDet PA_AporteNutricionalProductoDet
            {
                get{return new PA_AporteNutricionalProductoDetRepository(_dataSource);            }
                set{new PA_AporteNutricionalProductoDetRepository(_dataSource);}
            }

        public IPA_AportesComponentePreparacion PA_AportesComponentePreparacion
            {
                get{return new PA_AportesComponentePreparacionRepository(_dataSource);            }
                set{new PA_AportesComponentePreparacionRepository(_dataSource);}
            }

        public IPA_AportesComponentePreparacionDet PA_AportesComponentePreparacionDet
            {
                get{return new PA_AportesComponentePreparacionDetRepository(_dataSource);            }
                set{new PA_AportesComponentePreparacionDetRepository(_dataSource);}
            }

        public Ipa_BuscarPreparaciones pa_BuscarPreparaciones
            {
                get{return new pa_BuscarPreparacionesRepository(_dataSource);            }
                set{new pa_BuscarPreparacionesRepository(_dataSource);}
            }

        public IPA_BuscarProductos PA_BuscarProductos
            {
                get{return new PA_BuscarProductosRepository(_dataSource);            }
                set{new PA_BuscarProductosRepository(_dataSource);}
            }

        public IPA_CicloMenuAportesNutricionalesIndustrialesPiv PA_CicloMenuAportesNutricionalesIndustrialesPiv
            {
                get{return new PA_CicloMenuAportesNutricionalesIndustrialesPivRepository(_dataSource);            }
                set{new PA_CicloMenuAportesNutricionalesIndustrialesPivRepository(_dataSource);}
            }

        public IPA_CicloMenuAportesNutricionalesIndustrialesPivSem PA_CicloMenuAportesNutricionalesIndustrialesPivSem
            {
                get{return new PA_CicloMenuAportesNutricionalesIndustrialesPivSemRepository(_dataSource);            }
                set{new PA_CicloMenuAportesNutricionalesIndustrialesPivSemRepository(_dataSource);}
            }

        public IPA_CicloMenuAportesNutricionalesPiv PA_CicloMenuAportesNutricionalesPiv
            {
                get{return new PA_CicloMenuAportesNutricionalesPivRepository(_dataSource);            }
                set{new PA_CicloMenuAportesNutricionalesPivRepository(_dataSource);}
            }

        public IPA_CicloMenuAportesNutricionalesPivMAER PA_CicloMenuAportesNutricionalesPivMAER
            {
                get{return new PA_CicloMenuAportesNutricionalesPivMAERRepository(_dataSource);            }
                set{new PA_CicloMenuAportesNutricionalesPivMAERRepository(_dataSource);}
            }

        public IPA_CicloMenuAportesNutricionalesPivMAERsem PA_CicloMenuAportesNutricionalesPivMAERsem
            {
                get{return new PA_CicloMenuAportesNutricionalesPivMAERsemRepository(_dataSource);            }
                set{new PA_CicloMenuAportesNutricionalesPivMAERsemRepository(_dataSource);}
            }

        public IPA_CicloMenuAportesNutricionalesPivSem PA_CicloMenuAportesNutricionalesPivSem
            {
                get{return new PA_CicloMenuAportesNutricionalesPivSemRepository(_dataSource);            }
                set{new PA_CicloMenuAportesNutricionalesPivSemRepository(_dataSource);}
            }

        public IPA_conteoIntercambios PA_conteoIntercambios
            {
                get{return new PA_conteoIntercambiosRepository(_dataSource);            }
                set{new PA_conteoIntercambiosRepository(_dataSource);}
            }

        public IPA_Departamentos PA_Departamentos
            {
                get{return new PA_DepartamentosRepository(_dataSource);            }
                set{new PA_DepartamentosRepository(_dataSource);}
            }

        public IPA_GetPreparacion PA_GetPreparacion
            {
                get{return new PA_GetPreparacionRepository(_dataSource);            }
                set{new PA_GetPreparacionRepository(_dataSource);}
            }

        public IPA_IngredientesPreparacion PA_IngredientesPreparacion
            {
                get{return new PA_IngredientesPreparacionRepository(_dataSource);            }
                set{new PA_IngredientesPreparacionRepository(_dataSource);}
            }

        public IPA_NivelEducativoPesoServidoPiv PA_NivelEducativoPesoServidoPiv
            {
                get{return new PA_NivelEducativoPesoServidoPivRepository(_dataSource);            }
                set{new PA_NivelEducativoPesoServidoPivRepository(_dataSource);}
            }

        public IPA_ValidaFrecuencia PA_ValidaFrecuencia
            {
                get{return new PA_ValidaFrecuenciaRepository(_dataSource);            }
                set{new PA_ValidaFrecuenciaRepository(_dataSource);}
            }

        public IPA_ActualizaAprobacionSemana PA_ActualizaAprobacionSemana
            {
                get{return new PA_ActualizaAprobacionSemanaRepository(_dataSource);            }
                set{new PA_ActualizaAprobacionSemanaRepository(_dataSource);}
            }

        public IPA_ComplementosEntregadosGrado PA_ComplementosEntregadosGrado
            {
                get{return new PA_ComplementosEntregadosGradoRepository(_dataSource);            }
                set{new PA_ComplementosEntregadosGradoRepository(_dataSource);}
            }

        public IPA_ComplemetosEntregadosPorGrados PA_ComplemetosEntregadosPorGrados
            {
                get{return new PA_ComplemetosEntregadosPorGradosRepository(_dataSource);            }
                set{new PA_ComplemetosEntregadosPorGradosRepository(_dataSource);}
            }

        public IPA_DiasPaeSemana PA_DiasPaeSemana
            {
                get{return new PA_DiasPaeSemanaRepository(_dataSource);            }
                set{new PA_DiasPaeSemanaRepository(_dataSource);}
            }

        public IPA_FechasQuincenaRaciones PA_FechasQuincenaRaciones
            {
                get{return new PA_FechasQuincenaRacionesRepository(_dataSource);            }
                set{new PA_FechasQuincenaRacionesRepository(_dataSource);}
            }

        public IPA_IngresoSemanaEntregaRaciones PA_IngresoSemanaEntregaRaciones
            {
                get{return new PA_IngresoSemanaEntregaRacionesRepository(_dataSource);            }
                set{new PA_IngresoSemanaEntregaRacionesRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetBySedeJornadaOperador PA_QuincenaEntregaRacionesGetBySedeJornadaOperador
            {
                get{return new PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorH
            {
                get{return new PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetBySedeJornadaOperadorHRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetDatosCompletos PA_QuincenaEntregaRacionesGetDatosCompletos
            {
                get{return new PA_QuincenaEntregaRacionesGetDatosCompletosRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetDatosCompletosRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetDatosCompletosH PA_QuincenaEntregaRacionesGetDatosCompletosH
            {
                get{return new PA_QuincenaEntregaRacionesGetDatosCompletosHRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetDatosCompletosHRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetDiasPae PA_QuincenaEntregaRacionesGetDiasPae
            {
                get{return new PA_QuincenaEntregaRacionesGetDiasPaeRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetDiasPaeRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetDiasPaeH PA_QuincenaEntregaRacionesGetDiasPaeH
            {
                get{return new PA_QuincenaEntregaRacionesGetDiasPaeHRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetDiasPaeHRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetxGrado PA_QuincenaEntregaRacionesGetxGrado
            {
                get{return new PA_QuincenaEntregaRacionesGetxGradoRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetxGradoRepository(_dataSource);}
            }

        public IPA_QuincenaEntregaRacionesGetxGradoH PA_QuincenaEntregaRacionesGetxGradoH
            {
                get{return new PA_QuincenaEntregaRacionesGetxGradoHRepository(_dataSource);            }
                set{new PA_QuincenaEntregaRacionesGetxGradoHRepository(_dataSource);}
            }

        public IPA_SedeJornadaMesSemana PA_SedeJornadaMesSemana
            {
                get{return new PA_SedeJornadaMesSemanaRepository(_dataSource);            }
                set{new PA_SedeJornadaMesSemanaRepository(_dataSource);}
            }

        public IPA_SeguimientoRacionesDetalleSemana PA_SeguimientoRacionesDetalleSemana
            {
                get{return new PA_SeguimientoRacionesDetalleSemanaRepository(_dataSource);            }
                set{new PA_SeguimientoRacionesDetalleSemanaRepository(_dataSource);}
            }

        public IPA_GetMenuRol PA_GetMenuRol
            {
                get{return new PA_GetMenuRolRepository(_dataSource);            }
                set{new PA_GetMenuRolRepository(_dataSource);}
            }

        public IPA_GetMenuRolAll PA_GetMenuRolAll
            {
                get{return new PA_GetMenuRolAllRepository(_dataSource);            }
                set{new PA_GetMenuRolAllRepository(_dataSource);}
            }

        public IPA_GetRolPermisos PA_GetRolPermisos
            {
                get{return new PA_GetRolPermisosRepository(_dataSource);            }
                set{new PA_GetRolPermisosRepository(_dataSource);}
            }

        public IPA_MenuRolActualiza PA_MenuRolActualiza
            {
                get{return new PA_MenuRolActualizaRepository(_dataSource);            }
                set{new PA_MenuRolActualizaRepository(_dataSource);}
            }

        public IPA_RolPermisosActualiza PA_RolPermisosActualiza
            {
                get{return new PA_RolPermisosActualizaRepository(_dataSource);            }
                set{new PA_RolPermisosActualizaRepository(_dataSource);}
            }

        public INivelEducativoGetAllBySedeJornada NivelEducativoGetAllBySedeJornada
            {
                get{return new NivelEducativoGetAllBySedeJornadaRepository(_dataSource);            }
                set{new NivelEducativoGetAllBySedeJornadaRepository(_dataSource);}
            }

        public IPA_ActualizaSedesPrioModeloOper PA_ActualizaSedesPrioModeloOper
            {
                get{return new PA_ActualizaSedesPrioModeloOperRepository(_dataSource);            }
                set{new PA_ActualizaSedesPrioModeloOperRepository(_dataSource);}
            }

        public IPA_InstitucionEducativaGetbyOperadorContratoMunicipio PA_InstitucionEducativaGetbyOperadorContratoMunicipio
            {
                get{return new PA_InstitucionEducativaGetbyOperadorContratoMunicipioRepository(_dataSource);            }
                set{new PA_InstitucionEducativaGetbyOperadorContratoMunicipioRepository(_dataSource);}
            }

        public IPA_JornadaGetbyContratoMunicipio PA_JornadaGetbyContratoMunicipio
            {
                get{return new PA_JornadaGetbyContratoMunicipioRepository(_dataSource);            }
                set{new PA_JornadaGetbyContratoMunicipioRepository(_dataSource);}
            }

        public IPA_SedesGetbyContratoMunicipio PA_SedesGetbyContratoMunicipio
            {
                get{return new PA_SedesGetbyContratoMunicipioRepository(_dataSource);            }
                set{new PA_SedesGetbyContratoMunicipioRepository(_dataSource);}
            }



     }
}