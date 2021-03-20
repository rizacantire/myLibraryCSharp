using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BookAdded = "Kitap eklendi";
        public static string ProductNameInvalid = "Kitap ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string BooksListed ="Kitaplar listelendi";
        public static string Listed = "İçerik listelendi";
        public static string BookCountOfCategoryError="Bir kategoride en fazla 10 kitap olabilir";
        public static string BookNameAlreadyExists="Bu isimde zaten başka bir kitap var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni kitap eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string BookDeleted = "Kitap silindi";
        public static string BookUpdated = "Kitap güncellendi";
        public static string AuthorDeleted = "Yazar silindi";
        public static string AuthorUpdated = "Yazar güncellendi";
        public static string AuthorAdded = "Yazar eklendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string CategoryAdded = "Kategori eklendi";
        public static string AuthorListed = "Yazar listelendi";
        public static string CategoryListed = "Kategori listelendi";
    }
}
