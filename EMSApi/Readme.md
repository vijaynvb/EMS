1. Install using nuget package manager. select proper version as per project
    Microsoft.EntityFrameworkCore.Design
    Microsoft.EntityFrameworkCore.SqlServer
    Microsoft.EntityFrameworkCore.Tools

2. Create Db Context Class 
    Folder Data 
    Class ProjectNameDbContext
        1. Extend it with DbContext of EntityFrameWorkCore Library 
        2. Override OnConfiguring method 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EMSDb;Trusted_Connection=True;");
        3. create a property for the model needed in db. 
            public DbSet<Employee> Employees { get; set; }

3. In program.cs 
    1. add Db Context to enable db before AddControllers
        builder.Services.AddDbContext<EMSDbContext>();

4. In Package ManagerConsole type below commands.
    1. get-help EntityFrameWorkCore
    2. add-migration init 
    3. update-database 