using Tesseract;

namespace Т.Core
{
    public class TextExtractorcs
    {
        public string ReadEng()
        {
            var text = string.Empty;
            var path = @"C:\Users\Primas\Pictures\Saved Pictures\TesseractPicture.PNG";
            var language = "eng";
            var tessdata = @"./tessdata";

            using (var engine = new TesseractEngine(tessdata, language, EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(path))
                {
                    using (var page = engine.Process(img))
                    {
                        text = page.GetText();
                    }
                }
            }

            return text;
        }

        public string ReadBg(string path = @"C:\Users\Primas\Pictures\Saved Pictures\TesseractPictureBg.PNG")
        {
            var text = string.Empty;
            var language = "bul";
            var tessdata = @"./tessdata";

            using (var engine = new TesseractEngine(tessdata, language, EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(path))
                {
                    using (var page = engine.Process(img))
                    {
                        text = page.GetText();
                    }
                }
            }

            return text;
        }
    }
}
