var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql", port: 14329)
                 .AddDatabase("sqldata")
                 .WithEndpoint(port: 14330);

builder.AddProject<Projects.SupportTicketApi_Api>("api")
    .WithReference(sql);

builder.Build().Run();
