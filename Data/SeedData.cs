using Models;
using Services;

namespace Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            ProductService productService = services.GetRequiredService<ProductService>();
            IEnumerable<Product> existingProducts = await productService.GetProductsAsync();
            if (existingProducts.Any())
                return;

            List<Product> Products = new List<Product>
            {
                new Product
                {
                    Name = "Blazor",
                    Price = 5.50m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "Blazor pros",
                            Value = "Reusable Components, Fast Rendering, .NET Integration",
                        },
                        new ProductDetail { Label = "Platform", Value = "WebAssembly, Server" },
                        new ProductDetail { Label = "Language", Value = "C#, HTML, CSS" },
                    },
                },
                new Product
                {
                    Name = "ASP.NET Core",
                    Price = 7.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "ASP.NET Core pros",
                            Value = "Cross-platform, High Performance, Cloud Ready",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#, F#, VB.NET" },
                    },
                },
                new Product
                {
                    Name = "Entity Framework",
                    Price = 4.25m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "EF Core pros",
                            Value = "ORM, LINQ Support, Migrations",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "SignalR",
                    Price = 3.75m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "SignalR pros",
                            Value = "Real-time, WebSockets, Scalable",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "MAUI",
                    Price = 9.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "MAUI pros",
                            Value = "Cross-platform UI, Native Controls, .NET Integration",
                        },
                        new ProductDetail
                        {
                            Label = "Platform",
                            Value = "Windows, Android, iOS, macOS",
                        },
                        new ProductDetail { Label = "Language", Value = "C#, XAML" },
                    },
                },
                new Product
                {
                    Name = "Blazor",
                    Price = 5.50m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "Blazor pros",
                            Value = "Reusable Components, Fast Rendering, .NET Integration",
                        },
                        new ProductDetail { Label = "Platform", Value = "WebAssembly, Server" },
                        new ProductDetail { Label = "Language", Value = "C#, HTML, CSS" },
                    },
                },
                new Product
                {
                    Name = "ASP.NET Core",
                    Price = 7.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "ASP.NET Core pros",
                            Value = "Cross-platform, High Performance, Cloud Ready",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#, F#, VB.NET" },
                    },
                },
                new Product
                {
                    Name = "Entity Framework",
                    Price = 4.25m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "EF Core pros",
                            Value = "ORM, LINQ Support, Migrations",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "SignalR",
                    Price = 3.75m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "SignalR pros",
                            Value = "Real-time, WebSockets, Scalable",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "MAUI",
                    Price = 9.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "MAUI pros",
                            Value = "Cross-platform UI, Native Controls, .NET Integration",
                        },
                        new ProductDetail
                        {
                            Label = "Platform",
                            Value = "Windows, Android, iOS, macOS",
                        },
                        new ProductDetail { Label = "Language", Value = "C#, XAML" },
                    },
                },
                new Product
                {
                    Name = "Blazor",
                    Price = 5.50m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "Blazor pros",
                            Value = "Reusable Components, Fast Rendering, .NET Integration",
                        },
                        new ProductDetail { Label = "Platform", Value = "WebAssembly, Server" },
                        new ProductDetail { Label = "Language", Value = "C#, HTML, CSS" },
                    },
                },
                new Product
                {
                    Name = "ASP.NET Core",
                    Price = 7.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "ASP.NET Core pros",
                            Value = "Cross-platform, High Performance, Cloud Ready",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#, F#, VB.NET" },
                    },
                },
                new Product
                {
                    Name = "Entity Framework",
                    Price = 4.25m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "EF Core pros",
                            Value = "ORM, LINQ Support, Migrations",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "SignalR",
                    Price = 3.75m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "SignalR pros",
                            Value = "Real-time, WebSockets, Scalable",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "MAUI",
                    Price = 9.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "MAUI pros",
                            Value = "Cross-platform UI, Native Controls, .NET Integration",
                        },
                        new ProductDetail
                        {
                            Label = "Platform",
                            Value = "Windows, Android, iOS, macOS",
                        },
                        new ProductDetail { Label = "Language", Value = "C#, XAML" },
                    },
                },
                new Product
                {
                    Name = "Blazor",
                    Price = 5.50m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "Blazor pros",
                            Value = "Reusable Components, Fast Rendering, .NET Integration",
                        },
                        new ProductDetail { Label = "Platform", Value = "WebAssembly, Server" },
                        new ProductDetail { Label = "Language", Value = "C#, HTML, CSS" },
                    },
                },
                new Product
                {
                    Name = "ASP.NET Core",
                    Price = 7.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "ASP.NET Core pros",
                            Value = "Cross-platform, High Performance, Cloud Ready",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#, F#, VB.NET" },
                    },
                },
                new Product
                {
                    Name = "Entity Framework",
                    Price = 4.25m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "EF Core pros",
                            Value = "ORM, LINQ Support, Migrations",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "SignalR",
                    Price = 3.75m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "SignalR pros",
                            Value = "Real-time, WebSockets, Scalable",
                        },
                        new ProductDetail { Label = "Platform", Value = ".NET" },
                        new ProductDetail { Label = "Language", Value = "C#" },
                    },
                },
                new Product
                {
                    Name = "MAUI",
                    Price = 9.99m,
                    ImageUrl = "images/blazor-card.png",
                    ProductDetails = new List<ProductDetail>
                    {
                        new ProductDetail
                        {
                            Label = "MAUI pros",
                            Value = "Cross-platform UI, Native Controls, .NET Integration",
                        },
                        new ProductDetail
                        {
                            Label = "Platform",
                            Value = "Windows, Android, iOS, macOS",
                        },
                        new ProductDetail { Label = "Language", Value = "C#, XAML" },
                    },
                },
            };

            foreach (Product product in Products)
            {
                await productService.CreateProductAsync(product);
            }
        }
    }
}
