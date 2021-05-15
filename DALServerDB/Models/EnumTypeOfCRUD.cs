using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DALServerDB.Models
{
    public enum EnumTypeOfCRUD
    {
        Add = 1,
        Change = 2
    }
    public enum EnumForm
    {
        Sage = 1,
        Book = 2,
        SageBook = 3
    }
    public class Cols : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            // 51, 153, 255 - устанавливаем голубой цвет выбранного элемента
            // (или задаете свой)
            get { return Color.FromArgb(30, 30, 30); }
        }
        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(40, 40, 40); }
            //get { return Color.Black; }
        }
        public override Color ImageMarginGradientBegin
        {
            get { return Color.FromArgb(40, 40, 40); }
            //get { return Color.Black; }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return Color.FromArgb(40, 40, 40); }
            //get { return Color.Black; }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return Color.FromArgb(40, 40, 40); }
            //get { return Color.Black; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(40, 40, 40); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(40, 40, 40); }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(40, 40, 40); }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.FromArgb(40, 40, 40); }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(40, 40, 40); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(40, 40, 40); }
        }
    }
    public static class SetWhiteToolStrip
    {
        public static void SetWhiteColor(ToolStripMenuItem item)
        {
            item.ForeColor = Color.White;
            foreach (ToolStripMenuItem it in item.DropDownItems)
            {
                SetWhiteColor(it);
            }
        }
    }
    public class Crypter
    {
        private static string key = "<RSAKeyValue><Modulus>u2Tc/r3+PCF/RJKzItIK0PvH6hI9Nm4JyVAceslyB/1ii1pHTzUycu+zEDPKGLwBf4zoxBDH9FoD5E3I+d0m3Ape+mzCcvexP4E5W6/kba4fWM5LFOCO+eSQmoR8nEsEI32QFOUjX5nsxVxahElxGRZVgdmQTLOaV626aShIRnE=</Modulus><Exponent>AQAB</Exponent><P>6ReHfDakGxwAevHkCFb/wQgh6JUdgOt/8MF9LCLepV/RQAaRn2mBC76Ghr6EVgKJt436FTTElBsV3rep9JHEmQ==</P><Q>zc+ZLtodrTYSCv/rqGZxrmnsY2UYOtQW0oezSQRuI7KwH5uPxsvE4RG0ELP1QYN2RG7VtPBdFYvuE2KPqv1fmQ==</Q><DP>0K+rMm9tP4Qzfd9hTIIvmnAgg641av3tXuysl75kXeVKX6tB51o7GfurT6n0q1i8WeU4GJJUyVDypKME+50iSQ==</DP><DQ>Ut5H+4lvcZLX6P3q0T+Ofn+/4rWN8AH9vn9NPRU/k7gbGl70oULi3wzVx/PtyJc6Q4utGNG/aTGShtOkrWCf4Q==</DQ><InverseQ>k4C24Kg3+dJEBj2VNz6Vrwjicq/idnWoL1+TzYliwSWs/Yai/oL5aaa1ZKCrVqqOJZdIz/yGcpQwrxvmbLD9Hg==</InverseQ><D>A2Rz+BGeRrOQNKss3oUWaIpHqCC3O83EqWtk70JyfnCzcL825MPGBhzO7Uy+txwU29yuwbk7DBz4DpFA7D25FxaP6CDbSRBI5Q0nJ608D7DJHXzxSVoxfe4rjIuQBA3fvwtTKYdjTegwyNX/4bevAEfrkfejp/EOFwvhvmfiJXE=</D></RSAKeyValue>";
        public static string GetCrypt(string str)
        {
            string res;
            try { res = Crypter.Decrypt(str); }
            catch { res = str; }
            return res;
        }
        public static string SetCrypt(string str)
        {
            return Crypter.Encrypt(str);
        }
        internal static string Decrypt(string str)
        {
            byte[] decrByte = null;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            decrByte = rsa.Decrypt(Convert.FromBase64String(str), true);
            return Encoding.UTF8.GetString(decrByte);
        }
        internal static string Encrypt(string str)
        {
            byte[] encByte = null;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            encByte = rsa.Encrypt(Encoding.UTF8.GetBytes(str), true);

            return Convert.ToBase64String(encByte);
        }
    }
}
