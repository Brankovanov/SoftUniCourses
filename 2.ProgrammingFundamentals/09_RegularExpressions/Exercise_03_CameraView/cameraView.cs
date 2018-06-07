using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_03_CameraView
{
    public class cameraView
    {
        public static void Main(string[] args)
        {
            ReceiveCameraviews();
        }

        //Приема вход от конзолата.
        static void ReceiveCameraviews()
        {
            var num = Console.ReadLine();
            var codec = num.Split(' ');
            var cameras = Console.ReadLine();
            var pic = string.Empty;

            SortCameras(cameras, codec, pic);
        }

        //Сортира камерите и отделя неактивните.
        static void SortCameras(string cameras, string[] codec, string pic)
        {
            var findCameras = @"\|";
            var camerasArray = Regex.Split(cameras, findCameras).ToList();
            StringBuilder output = new StringBuilder();

            for (var cam = 0; cam <= camerasArray.Count - 1; cam++)
            {
                if (!camerasArray[cam].Contains("<"))
                {
                    camerasArray.Remove(camerasArray[cam]);
                    cam--;
                }
                else
                {
                    var pics = camerasArray[cam].ToString().Remove(0, 1);
                    TakePics(pics, codec, pic, output);
                }
            }

            PrintPictures(output);
        }

        //Сортира истинските снимки.
        static void TakePics(string pics, string[] codec, string pic, StringBuilder output)
        {
            var p = string.Empty;

            if (pics.Length >= int.Parse(codec[0]))
            {
                p = pics.Remove(0, int.Parse(codec[0]));
            }
            else
            {
                p = pics.Remove(0, pics.Length);
            }

            while (p.Length > 0)
            {
                try
                {
                    output.Append(p.Substring(0, int.Parse(codec[1]))).Append(", ");
                    p = p.Remove(0, int.Parse(codec[1]));
                }
                catch (ArgumentOutOfRangeException)
                {
                    output.Append(p).Append(", ");
                    p = string.Empty;
                }
            }
        }

        //Отпечатва финалните снимки.
        static void PrintPictures(StringBuilder output)
        {
            Console.WriteLine(output.ToString().TrimEnd(',', ' '));
        }
    }
}