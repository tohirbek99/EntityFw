namespace EntityFw.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public bool LanguageStasus { get; set; }

        public List<ProductTranslate> ProductTranslates { get; set; }
        public List<OrderTranslate> OrderTranslates { get; set; }

    }
}
