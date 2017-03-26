using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace GetCorlor
{
    public partial class showing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Address = Request.Params["Address"].ToString();
            Bitmap img = (Bitmap)System.Drawing.Image.FromFile(Address);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            Response.ClearContent();
            Response.ContentType = "image/Jpeg";
            Response.BinaryWrite(ms.ToArray());
        }
    }
}