using System;
using System.Windows.Forms; // Windows Forms için gerekli kütüphane

namespace WindowsFormsApp3 // Sizin projenizin namespace'i (muhtemelen bu)
{
    static class Program // Main metodunu içeren sınıf
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread] // Windows Forms uygulamaları için önemli
        static void Main()
        {
            Application.EnableVisualStyles(); // Görsel stilleri etkinleştirir
            Application.SetCompatibleTextRenderingDefault(false); // Varsayılan metin işleme uyumluluğunu ayarlar

            // BURASI ÖNEMLİ: Uygulamanızın FrmGiris ile başlamasını sağlar.
            Application.Run(new FrmGiris());
        }
    }
}
