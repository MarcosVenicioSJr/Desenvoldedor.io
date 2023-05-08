namespace Balta.ContentContext
{
  public class Course : Content
  {
    public Course(string title, string url) : base(title, url)
    {
      Modules = new List<Module>();
    }

    public string Tag { get; set; }
    protected IList<Module> Modules { get; set; }
  }
}



