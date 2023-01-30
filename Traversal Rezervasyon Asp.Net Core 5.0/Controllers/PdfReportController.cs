using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document= new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph= new Paragraph("traversal rezervasyon pdf raporu");
            document.Add(paragraph);

            document.Close();

            return File("/PdfReport/dosya1.pdf","application/pdf","dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(2);

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Eylül");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("111111111111");

            pdfPTable.AddCell("Kemal");
            pdfPTable.AddCell("Yıldırım");
            pdfPTable.AddCell("222222222222");

            pdfPTable.AddCell("Egemen");
            pdfPTable.AddCell("Ağustos");
            pdfPTable.AddCell("33333333333");

            document.Add(pdfPTable);

            document.Close();

            return File("/PdfReport/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
    }
}
