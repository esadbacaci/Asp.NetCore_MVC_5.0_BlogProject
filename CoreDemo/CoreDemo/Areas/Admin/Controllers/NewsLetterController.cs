using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class NewsLetterController : Controller
    {
        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("MailListesi");
                worksheet.Cell(1, 1).Value = "Mail ID";
                worksheet.Cell(1, 2).Value = "Mail";

                int NewsLetterRowCount = 2;
                foreach (var item in NewsLetterTitleList())
                {
                    worksheet.Cell(NewsLetterRowCount, 1).Value = item.ID;
                    worksheet.Cell(NewsLetterRowCount, 2).Value = item.Mail;
                    NewsLetterRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformatas-officedocument.spreadsheethtml.sheet", "AboneTablosu.xlsx");
                }
            }
        }
        public List<NewsLetterModel> NewsLetterTitleList()
        {
            List<NewsLetterModel> bm = new List<NewsLetterModel>();
            using (var c = new Context())
            {
                bm = c.NewsLetters.Select(x => new NewsLetterModel
                {
                    ID = x.MailId,
                    Mail = x.Mail

                }).ToList();
            }
            return bm;
        }
        public IActionResult NewsLetterTitleListExcel()
        {
            return View();
        }
    }
}
