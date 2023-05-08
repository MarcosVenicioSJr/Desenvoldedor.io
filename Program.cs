using Balta.ContentContext;
using Balta.SubscriptionContext;

List<Article> articles = new List<Article>();
articles.Add(new Article("OOP", "orientacao-objeto"));

foreach (Article at in articles)
{
  Console.WriteLine(at.Title);
  Console.WriteLine(at.Url);
}

List<Course> courses = new List<Course>();
Course courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
Course courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");

courses.Add(courseOOP);
courses.Add(courseCsharp);

List<Career> careers = new List<Career>();
Career career = new Career("Especialista .NET", "especialista-dotnet");
CareerItem careerItem = new CareerItem(1, "Comece por aqui", "", null);
CareerItem careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);

career.Items.Add(careerItem);
careers.Add(career);

PayPalSubscription payPalSubscription = new PayPalSubscription();
Student student = new Student();
student.Subscriptions.Add(payPalSubscription);