using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string sablonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sablon.png");
        private readonly string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Poppins-Bold.ttf");

        private Button btnFoto, btnKaydet;
        private TextBox txtBaslik;
        private string? fotoPath;

        public Form1()
        {
            Text = "Haber G�rseli � 1080�1440";
            Width = 400; Height = 230;

            btnFoto = new Button { Text = "Foto�raf Se�", Dock = DockStyle.Top, Height = 40 };
            txtBaslik = new TextBox { Dock = DockStyle.Top, Multiline = true, Height = 60 };
            btnKaydet = new Button { Text = "Kaydet", Dock = DockStyle.Top, Height = 40 };

            Controls.AddRange(new Control[] { btnKaydet, txtBaslik, btnFoto });

            btnFoto.Click += (_, __) => Sec();
            btnKaydet.Click += (_, __) => Olustur();
        }

        private void Sec()
        {
            using var ofd = new OpenFileDialog { Filter = "Resim Dosyalar�|*.jpg;*.jpeg;*.png" };
            if (ofd.ShowDialog() == DialogResult.OK)
                fotoPath = ofd.FileName;
        }

        private void Olustur()
        {
            if (string.IsNullOrEmpty(fotoPath) || string.IsNullOrWhiteSpace(txtBaslik.Text))
            {
                MessageBox.Show("Foto�raf ve ba�l�k gerekli!");
                return;
            }

            // 1) Poppins-Bold y�kle
            PrivateFontCollection pfc = new();
            if (!File.Exists(fontPath))
            {
                MessageBox.Show("Poppins-Bold.ttf bulunamad�!\n" + fontPath);
                return;
            }
            pfc.AddFontFile(fontPath);
            FontFamily poppinsB = pfc.Families[0];

            // 2) Canvas
            using var bmp = new Bitmap(1080, 1440, PixelFormat.Format32bppArgb);
            using var g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            // 3) Foto�raf� tam 1080�1440�a crop-center (kenar at, siyah YOK)
            using var src = Image.FromFile(fotoPath);
            var destRect = CropFill(src.Size, 1080, 1440);
            g.DrawImage(src, destRect);

            // 4) �ablonu foto�raf�n �ST�NE �iz (transparent PNG varsa logo g�r�n�r)
            if (File.Exists(sablonPath))
            {
                using var sablon = Image.FromFile(sablonPath);
                g.DrawImage(sablon, 0, 0, 1080, 1440);
            }
            else
            {
                MessageBox.Show("sablon.png bulunamad�!\n" + sablonPath);
                return;
            }

            // 5) Merkezin alt�ndan 233 px, s�k��t�r�lm�� sat�r bo�lu�u
            int textTop = 720 + 233;
            int textHeight = 140;                          // 2 sat�r i�in yeterli alan
            RectangleF textRect = new RectangleF(0, textTop, 1080, textHeight);

            using var font = new Font(poppinsB, 60f, FontStyle.Bold, GraphicsUnit.Pixel);

            // sat�r y�ksekli�ini %50 indir
            float lineHeight = font.GetHeight(g) * 0.8f;

            // �ok-sat�r boyutunu kendimiz �l�elim
            SizeF size = g.MeasureString(txtBaslik.Text, font, 1080,
                                         new StringFormat
                                         {
                                             Alignment = StringAlignment.Center,
                                             FormatFlags = StringFormatFlags.NoClip,
                                             Trimming = StringTrimming.None
                                         });

            // ka� sat�r var?
            int lines = (int)Math.Ceiling(size.Height / lineHeight);

            // ba�latma Y koordinat�
            float startY = textRect.Y + (textRect.Height - lines * lineHeight) / 2f;

            // sat�r sat�r yaz
            string[] satirlar = txtBaslik.Text.Split('\n');
            for (int i = 0; i < satirlar.Length; i++)
            {
                float y = startY + i * lineHeight;
                g.DrawString(satirlar[i], font, Brushes.White,
                             new PointF(textRect.X + textRect.Width / 2f, y),
                             new StringFormat { Alignment = StringAlignment.Center });
            }
            // 6) Kaydet
            using var sfd = new SaveFileDialog
            {
                Filter = "JPEG|*.jpg|PNG|*.png",
                FileName = "haber.jpg"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Kaydedildi:\n" + sfd.FileName);
            }
        }

        private Rectangle CropFill(Size src, int w, int h)
        {
            double scale = Math.Max((double)w / src.Width, (double)h / src.Height);
            int newW = (int)(src.Width * scale);
            int newH = (int)(src.Height * scale);
            int x = (w - newW) / 2;
            int y = (h - newH) / 2;
            return new Rectangle(x, y, newW, newH);
        }
    }
}