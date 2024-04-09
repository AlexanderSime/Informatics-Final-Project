using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f2
{
    public class ImageUploader
    {
        public static void UploadImage(string username, byte[] image)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=UserRecords; Integrated Security=True;"))
            {
                sqlCon.Open();

                string imgQuery = "UPDATE UserInfo SET img=@img WHERE username=@username";

                using (SqlCommand cmd = new SqlCommand(imgQuery, sqlCon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@img", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
