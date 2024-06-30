
namespace WebApplication7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            var gmailAddress = "d32193412@gmail.com";
            var gmailPassword = "h m b b a g g y z r t p g y y b"; // סיסמת האפליקציה של גימייל

            var smtpClient = new GmailSmtpClient(gmailAddress, gmailPassword);
            smtpClient.SendEmail("d32193412@gmail.com", "Subject", "Email body text");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }


        
            
        
    }
}
