using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;

namespace GetCorlor
{
    public partial class Main : System.Web.UI.Page
    {
        public int[,,] RGBdata;
        public int[,,] intRGB;
        public int intAllC;
        public string strOriLocalAdd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            tbColor.Text = "";
            if (OriDataFile.PostedFile != null && OriDataFile.PostedFile.ContentLength > 0)
            {
                string fn = System.IO.Path.GetFileName(OriDataFile.PostedFile.FileName);
                string SaveLocation = Server.MapPath("Upload") + "\\" + fn;
                try
                {
                    OriDataFile.PostedFile.SaveAs(SaveLocation);
                    strOriLocalAdd = SaveLocation;
                    imgOri.ImageUrl = ("/showing.aspx?Address=" + SaveLocation);     
                }
                catch (Exception ex)
                {
                    //Response.Write("Error: " + ex.Message);
                    //ShowMsgHelper.Alert_Error("Error: " + ex.Message);
                }
            }
            else
            {
                //Response.Write("Please select a file to upload.");
                //ShowMsgHelper.Alert_Error("Please select a file to upload.");
            }
        }

        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void GetColor(string strAdd)
        {
            try
            {
                Bitmap curBitmap = (Bitmap)System.Drawing.Image.FromFile(strAdd);
                int intW = curBitmap.Width;
                int intH = curBitmap.Height;
                RGBdata = new int[intW, intH, 3];
                intRGB = new int[256, 256, 256];
                intAllC = 0;
                for (int x = 0; x < intW; x++)
                {
                    for (int y = 0; y < intH; y++)
                    {
                        Color c = curBitmap.GetPixel(x, y);
                        RGBdata[x, y, 0] = c.R;
                        RGBdata[x, y, 1] = c.G;
                        RGBdata[x, y, 2] = c.B;
                        intRGB[c.R, c.G, c.B] = intRGB[c.R, c.G, c.B] + 1;
                        intAllC++;
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        protected void btn_Analysis_Click(object sender, EventArgs e)
        {
            GetColor(strOriLocalAdd);
            labAll.Text = "It have " + intAllC + "Pixs";
            for (int R = 0; R < 256; R++)
            {
                for (int G = 0; G < 256; G++)
                {
                    for (int B = 0; B < 256; B++)
                    {
                        if (intRGB[R, G, B] != 0)
                        {
                            tbColor.Text = tbColor.Text + "R:" + R + "G:" + G + "B:" + B + "::" + intRGB[R, G, B] + "\r\n";
                        }
                    }
                }
            }
        }
    }
}