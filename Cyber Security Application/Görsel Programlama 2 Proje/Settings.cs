using System;

namespace Görsel_Programlama_2_Proje.Properties
{
    internal sealed partial class Settings
    {
        public Settings()
        {
            // Ayarları kaydetmek ve değiştirmek üzere olay işleyicileri eklemek için alttaki açıklama satırlarını kaldırın:

            // Bu olay, bir ayarın değeri değiştirilmeden önce tetiklenir
            this.SettingChanging += this.SettingChangingEventHandler;

            // Bu olay, ayar değerleri kaydedilmeden önce tetiklenir
            this.SettingsSaving += this.SettingsSavingEventHandler;
        }

        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            // Bir ayar değişmeden önce yapılacak işlemleri burada gerçekleştirin
            Console.WriteLine($"Setting {e.SettingName} is about to change to {e.NewValue}");
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Ayar değerleri kaydedilmeden önce yapılacak işlemleri burada gerçekleştirin
            Console.WriteLine("Settings are about to be saved.");
        }
    }
}

