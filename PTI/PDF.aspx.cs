using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Spire.Pdf;
using System.Drawing.Imaging;

namespace PDF_to_Images
{
    public partial class PDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            if (UpPdf.HasFile)
            {
                string pdfPath = Server.MapPath("~/pdf/");
                //Spire实现PDF转Images
                //if (!System.IO.Directory.Exists(pdfPath))
                //{
                //需要注意的是，需要对这个物理路径有足够的权限，否则会报错
                //另外，这个路径应该是在网站之下，而将网站部署在C盘却把文件保存在D盘
                //    System.IO.Directory.CreateDirectory(pdfPath);
                //}
                pdfPath = pdfPath + "\\" + UpPdf.FileName;
                //UpPdf.SaveAs(pdfPath);//保存文件
                //PdfDocument doc = new PdfDocument();
                //doc.LoadFromFile(pdfPath);
                //for (int i = 0; i < doc.Pages.Count; i++)
                //{
                //    string imgpath = Server.MapPath("~/images/");
                //    if (!System.IO.Directory.Exists(imgpath))
                //    {
                //        System.IO.Directory.CreateDirectory(imgpath);
                //    }
                //    System.Drawing.Image bmp = doc.SaveAsImage(i);
                //    String imageFileName = String.Format("" + imgpath + "Image-{0}.png", i);
                //    bmp.Save(imageFileName, System.Drawing.Imaging.ImageFormat.Png);
                //}
                //doc.Close();
                //O2S方式实现
                string imgpath = Server.MapPath("~/images/");
                string imageName = UpPdf.FileName.Substring(0, UpPdf.FileName.Length - 4);
                bool seccess=  PTI.Program.ConvertPDF2Image(pdfPath, imgpath, imageName, 0, 10000, ImageFormat.Png, PTI.Program.Definition.Five);
                if (seccess)
                {
                    Response.Write("转换成功，请前往上传地址查看！");
                }
                else
                {
                    Response.Write("转换失败");
                }
               

            }
        }
    }
}