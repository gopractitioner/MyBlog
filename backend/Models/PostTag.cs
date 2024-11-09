namespace backend.Models;

public class PostTag
{
    public int PostId { get; set; }
    public int TagId { get; set; }

    // 导航属性
    public Post Post { get; set; }
    public Tag Tag { get; set; }
}
