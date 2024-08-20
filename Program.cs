var builder = Host.CreateApplicationBuilder(args);
var options = builder.Configuration.GetAWSOptions();

builder.Services.AddDefaultAWSOptions(options);
builder.Services.AddAWSService<IAmazonSQS>();
builder.Services.AddHostedService<QueueLister>();

var app = builder.Build();
await app.RunAsync();