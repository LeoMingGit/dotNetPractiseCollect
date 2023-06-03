using Microsoft.Office.Interop.Word;
using NPOI.XWPF.UserModel;
using System;
using System.Diagnostics;
using System.IO;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.pdmodel.font;
using org.apache.pdfbox.pdmodel.edit;
using NPOI.XWPF.Extractor;

namespace WordToPdfSln
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = 3;
            if (flag == 1)
            {
                AsposeConvertWordToPdf(@"E:\代码练习\dotNetPractiseCollect\word转Pdf\测试数据\2022年全国甲卷高考理综真题及答案.doc",
          Path.GetTempPath() + $"{ Guid.NewGuid().ToString()}.pdf");

            }
            if (flag == 2)
            {
                ApplicationConvertWordToPdf(@"E:\代码练习\dotNetPractiseCollect\word转Pdf\测试数据\2022年全国甲卷高考理综真题及答案.doc",
               Path.GetTempPath() + $"{ Guid.NewGuid().ToString()}.pdf");
            }
            if (flag==3){
                SpireConvertToPdf(@"E:\代码练习\dotNetPractiseCollect\word转Pdf\测试数据\2022年全国甲卷高考理综真题及答案.doc",
             Path.GetTempPath() + $"{ Guid.NewGuid().ToString()}.pdf");
            }

        
        }

        /// <summary>
        /// 这个有水印，需要商业授权,并且只转换20页的word文档
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <param name="outputFilePath"></param>
        public static void AsposeConvertWordToPdf(string inputFilePath, string outputFilePath)
        {
            // Start timer
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // Load the Word document
            var doc = new Aspose.Words.Document(inputFilePath);

            // Save the document as PDF
            doc.Save(outputFilePath, Aspose.Words.SaveFormat.Pdf);
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Conversion complete. PDF saved at " + outputFilePath);
            var elapsedSec = elapsedMs / 1000.0;
            Console.WriteLine("Time elapsed: " + elapsedSec + " seconds");
        }

        /// <summary>
        /// 开源免费，可商业使用
        /// 缺点：20M的word转成Pdf,需要30秒，且运行环境性须安装了word才行
        /// </summary>
        /// <param name="inputPath"></param>
        /// <param name="outputPath"></param>
        static void ApplicationConvertWordToPdf(string inputPath, string outputPath)
        {
            // Start timer
            var watch = System.Diagnostics.Stopwatch.StartNew();

            // Create new Word application
            Application wordApp = new Application();

            // Open Word document
            var wordDoc = wordApp.Documents.Open(inputPath);

            // Save Word document as PDF
            wordDoc.SaveAs2(outputPath, WdSaveFormat.wdFormatPDF);

            // Close Word document and application
            wordDoc.Close();
            wordApp.Quit();

            // Stop timer and calculate elapsed time
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Conversion complete. PDF saved at " + outputPath);
            var elapsedSec = elapsedMs / 1000.0;
            Console.WriteLine("Time elapsed: " + elapsedSec + " seconds");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <param name="outputFilePath"></param>
        public static void SpireConvertToPdf(string inputFilePath, string outputFilePath)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Load the Word document
            var doc = new Spire.Doc.Document();
            doc.LoadFromFile(inputFilePath);

            // Save the document as PDF
            doc.SaveToFile(outputFilePath, Spire.Doc.FileFormat.PDF);

            stopwatch.Stop();
            Console.WriteLine("Conversion completed in {0} seconds", stopwatch.Elapsed.TotalSeconds);
        }
    }
    
}
