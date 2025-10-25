
using Microsoft.AspNetCore.OData.Query; using ElmahCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;


namespace SISPAE.WebAPI.OperationFilter
    {
    public class AddApiParameters : IOperationFilter
        {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
            {
            var filterPipeline = context.ApiDescription.ActionDescriptor.FilterDescriptors;
            var isOdata = filterPipeline.Select(filterInfo => filterInfo.Filter).Any(filter => filter is EnableQueryAttribute);
            if(!isOdata) return;

            operation.Parameters.Add(new OpenApiParameter
                {
                Name = "$filter",
                Description = "Filtra los Resultados usa Sintaxis OData. \n\n (p.e.  Todos los usuarios ID_Usuario eq '5458745-54545',Devolver todos los productos con precio inferior a 10 --> precio lt 10, \n\n Devuelva todos los productos donde el precio > = 5 y el precio < = 15 --> precio ge 5 and precio le 5  \n\n Devuelve todos los productos con 'zz' en el nombre  --> $filter=substringof('zz',Campo)  \n\n  Devolver todos los productos con fecha mayor de 2005 --> $filter=year(CampoFecha) gt 2023)  \n\n Operadores Clave con $filter=: \n\n          Eq = igual ;\n\n          Ne = No igual;\n\n          Gt = Mayor que;\n\n          Le = Menor que;\n\n          Ge = Mayor o igual a;\n\n          Le = Menor o igual que ;\n\n          and = y;\n\n          Or = o ;\n\n          Not = No ;\n\n          substringof('cadena a boscar',campo) = Buscar una cadena en un string;\n\n          startswith(campo,'letras que inicia') = Buscar cadenas que inician con';\n\n          endswith(campo,'letras que finaliza') = Buscar cadenas que finalizan con';\n\n          substring(pos inicial,pos final,'cadena a buscar') = Buscar cadenas entre ciertos criterios';\n\n          toupper(campo) tolower(campo) = MAYUSCULAS O MINUSCULAS';          ",
                Required = false,
                AllowEmptyValue = true,
                In = ParameterLocation.Query,
                Schema = new OpenApiSchema
                    {
                    Type = "String"
                    }
                });

            operation.Parameters.Add(new OpenApiParameter
                {
                Name = "$select",
                Description = "Selecciona los campos a mostrar  \n\n(p.e. $select=PrimerNombre,PrimerApellido,ID_Usuario)",
                Required = false,
                AllowEmptyValue = true,
                In = ParameterLocation.Query,
                Schema = new OpenApiSchema
                    {
                    Type = "String"

                    }
                });

            operation.Parameters.Add(new OpenApiParameter
                {
                Name = "$orderby",
                Description = "Ordena los resultados usando la sintaxis Odata.  \n\n(p.e.  Ordenar por precio --> $orderby=Price \n\n ordenar precio descendente --> $orderby=price desc)",
                Required = false,
                AllowEmptyValue = true,
                In = ParameterLocation.Query,
                Schema = new OpenApiSchema
                    {
                    Type = "String"

                    }
                });

            operation.Parameters.Add(new OpenApiParameter
                {
                Name = "$skip",
                Description = "La Cantidad de resultados para saltar.  \n\n (p.e.  traer 10 registros de la tercera pagina o sea del 21 al 30  --> $top=10$skip=20)",
                Required = false,
                AllowEmptyValue = true,
                In = ParameterLocation.Query,
                Schema = new OpenApiSchema
                    {
                    Type = "String"

                    }
                });

            operation.Parameters.Add(new OpenApiParameter
                {
                Name = "$top",
                Description = "La Cantidad de resultados a mostrar.  \n\n(p.e.  Top 10 de registros $top=10)",
                Required = false,
                AllowEmptyValue = true,
                In = ParameterLocation.Query,
                Schema = new OpenApiSchema
                    {
                    Type = "String"

                    }
                });

            operation.Parameters.Add(new OpenApiParameter
                {
                Name = "$expand",
                In = ParameterLocation.Query,
                Schema = new OpenApiSchema
                    {
                    Type = "string",
                    },
                Description = "Incluye solo los obtetos seleccionados  \n\n(p.e. Childrens, Locations)",
                Required = false
                });




            }
        }
    }