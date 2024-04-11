var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql", port: 14329)
                 .AddDatabase("sqldata")
                 .WithEndpoint(hostPort: 14330);

builder.AddProject<Projects.SupportTicketApi>("api")
    .WithReference(sql);

builder.Build().Run();
