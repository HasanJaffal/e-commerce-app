namespace Server.Domain.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }  // ID from ImgBB for deletion
    }
}
