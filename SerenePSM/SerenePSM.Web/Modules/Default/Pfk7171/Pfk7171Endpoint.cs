
using Azure;
using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using Serenity.Data;
using Serenity.Services;
using System.Collections.Generic;
using System.Linq;
using MyRow = SerenePSM.Default.Pfk7171Row;

namespace SerenePSM.Default.Endpoints
{
    [Route("Services/Default/Pfk7171/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class Pfk7171Endpoint : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IPfk7171SaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IPfk7171SaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IPfk7171DeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IPfk7171RetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost, AuthorizeList(typeof(MyRow))]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request, [FromServices] IPfk7171ListHandler handler)
        {
            // Check if EqualityFilter contains the key "BasicCode"
            if (request.EqualityFilter != null && request.EqualityFilter.ContainsKey("BasicCode"))
            {
                var basicCode = (string)request.EqualityFilter["BasicCode"];

                // Check if basicCode is not null or empty
                if (!string.IsNullOrEmpty(basicCode))
                {
                    // Apply filter criteria based on K7171_BasicSel equal to the BasicCode value
                    request.Criteria = new Criteria("BasicSel") == new ValueCriteria(basicCode);

                    // Retrieve the filtered list from the handler
                    var response = handler.List(connection, request);

                    // Debug: Log the number of results returned
                    Console.WriteLine("Number of results: " + response.Entities.Count);

                    // Return the filtered response
                    return response;
                }
            }

            // If no BasicCode filter is provided, return the full list
            return handler.List(connection, request);
        }





        [HttpPost, AuthorizeList(typeof(MyRow))]
        public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
            [FromServices] IPfk7171ListHandler handler,
            [FromServices] IExcelExporter exporter)
        {
            var data = List(connection, request, handler).Entities;
            var bytes = exporter.Export(data, typeof(Columns.Pfk7171Columns), request.ExportColumns);
            return ExcelContentResult.Create(bytes, "Pfk7171List_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
        }
    }
}
