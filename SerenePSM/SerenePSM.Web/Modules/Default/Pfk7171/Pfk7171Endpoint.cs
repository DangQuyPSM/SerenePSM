
using Azure;
using Microsoft.AspNetCore.Mvc;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
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
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
    [FromServices] IPfk7171ListHandler handler)
        {
            // Initialize the response variable
            ListResponse<MyRow> response = new ListResponse<MyRow>();

            // Kiểm tra xem EqualityFilter có chứa key "BasicCode" không
            if (request.EqualityFilter != null && request.EqualityFilter.ContainsKey("BasicCode"))
            {
                var basicCode = (string)request.EqualityFilter["BasicCode"];

                // Kiểm tra nếu basicCode không null hoặc rỗng
                if (!string.IsNullOrEmpty(basicCode))
                {
                    // Tạo điều kiện Criteria
                    var criteria = new Criteria(Pfk7171Row.Fields.K7171_BasicSel) == basicCode;

                    // Initialize request.Criteria if it's null
                    if (request.Criteria.IsEmpty)
                    {
                        request.Criteria = criteria;
                    }
                    else
                    {
                        // Combine with existing criteria
                        request.Criteria = request.Criteria & criteria;
                    }

                    // Lấy phản hồi phân trang từ handler
                    response = handler.List(connection, request);
                }
            }

            // Trả về phản hồi
            return response;
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
