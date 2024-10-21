var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

// middlewares 
app.Use(async (context, next) =>
{
    //context.Request;
    context.Response.WriteAsync("Middleware 1 request flow 1 \n");
    await next();
    context.Response.WriteAsync("Middleware 1 response flow 1 \n");

});

app.Use( async (context, next) =>
{
    //context.Request;
    context.Response.WriteAsync("\t Middleware 2 request flow 1 \n");
    await next();
    context.Response.WriteAsync("\t Middleware 2 response flow 1 \n");

} );

// last middleware
app.Run( async (context) =>
{
    //context.Request;

     context.Response.WriteAsync("\t \t hello from applicarion \n"); // body willl be prepared

    //context.Response.;

});

// is for server
app.Run();

/*class Employee
{
    public int Id { get; set; }
    public string  Name { get; set; }
}*/