# Dependency Injection

## Register Service
Register a service using the builder inside your startup class.

For most .net maui use cases singleton will be good since it uses a single instance of that class

<code>builder.Services.AddSingleton<ServiceName>();</code>

## Consuming a Service
### Razor Pages
use <code>@inject class object</code> to inject and use services 