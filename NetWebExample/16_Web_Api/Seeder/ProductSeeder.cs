using _16_Web_Api.DataContext;
using _16_Web_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace _16_Web_Api.Seeder
{
    public static class ProductSeeder
    {
        public static void Seed(ProductContext context)
        {
            context.Database.Migrate();

            if (context.Products.Any())
            {
                return;
            }
            var products = new List<Product>
            {
                new Product
                {

                    Title = "Essence Mascara Lash Princess",
                    Description = "The Essence Mascara Lash Princess is a popular mascara known for its volumizing and lengthening effects. Achieve dramatic lashes with this long-lasting and cruelty-free formula.",
                    Category = "beauty",
                    Price =  9.99m,
                    DiscountPercentage = 10.48m,
                    Rating = 2.56,
                    Stock = 99,
                    Tags = new List<string> { "beauty", "mascara" },
                    Brand = "Essence",
                    Sku = "BEA-ESS-ESS-001",
                    Weight = 4,
                    WarrantyInformation = "1 week warranty",
                    ShippingInformation = "Ships in 3-5 business days",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 48,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/beauty/essence-mascara-lash-princess/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/beauty/essence-mascara-lash-princess/1.webp" }
                },
                new Product
                {

                    Title = "Eyeshadow Palette with Mirror",
                    Description = "The Eyeshadow Palette with Mirror offers a versatile range of eyeshadow shades for creating stunning eye looks. With a built-in mirror, it's convenient for on-the-go makeup application.",
                    Category = "beauty",
                    Price = 19.99m,
                    DiscountPercentage = 18.19m,
                    Rating = 2.86,
                    Stock = 34,
                    Tags = new List<string> { "beauty", "eyeshadow" },
                    Brand = "Glamour Beauty",
                    Sku = "BEA-GLA-EYE-002",
                    Weight = 9,
                    WarrantyInformation = "1 year warranty",
                    ShippingInformation = "Ships in 2 weeks",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 20,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/beauty/eyeshadow-palette-with-mirror/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/beauty/eyeshadow-palette-with-mirror/1.webp" }
                },
                new Product
                {

                    Title = "Powder Canister",
                    Description = "The Powder Canister is a finely milled setting powder designed to set makeup and control shine. With a lightweight and translucent formula, it provides a smooth and matte finish.",
                    Category = "beauty",
                    Price = 14.99m,
                    DiscountPercentage = 9.84m,
                    Rating = 4.64,
                    Stock = 89,
                    Tags = new List<string> { "beauty", "face powder" },
                    Brand = "Velvet Touch",
                    Sku = "BEA-VEL-POW-003",
                    Weight = 8,
                    WarrantyInformation = "3 months warranty",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 22,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/beauty/powder-canister/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/beauty/powder-canister/1.webp" }
                },
                new Product
                {

                    Title = "Red Lipstick",
                    Description = "The Red Lipstick is a classic and bold choice for adding a pop of color to your lips. With a creamy and pigmented formula, it provides a vibrant and long-lasting finish.",
                    Category = "beauty",
                    Price = 12.99m,
                    DiscountPercentage = 12.16m,
                    Rating = 4.36,
                    Stock = 91,
                    Tags = new List<string> { "beauty", "lipstick" },
                    Brand = "Chic Cosmetics",
                    Sku = "BEA-CHI-LIP-004",
                    Weight = 1,
                    WarrantyInformation = "3 year warranty",
                    ShippingInformation = "Ships in 1 week",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 40,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/beauty/red-lipstick/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/beauty/red-lipstick/1.webp" }
                },
                new Product
                {

                    Title = "Red Nail Polish",
                    Description = "The Red Nail Polish offers a rich and glossy red hue for vibrant and polished nails. With a quick-drying formula, it provides a salon-quality finish at home.",
                    Category = "beauty",
                    Price = 8.99m,
                    DiscountPercentage = 11.44m,
                    Rating = 4.32,
                    Stock = 79,
                    Tags = new List<string> { "beauty", "nail polish" },
                    Brand = "Nail Couture",
                    Sku = "BEA-NAI-NAI-005",
                    Weight = 8,
                    WarrantyInformation = "1 month warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 22,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/beauty/red-nail-polish/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/beauty/red-nail-polish/1.webp" }
                },
                new Product
                {

                    Title = "Calvin Klein CK One",
                    Description = "CK One by Calvin Klein is a classic unisex fragrance, known for its fresh and clean scent. It's a versatile fragrance suitable for everyday wear.",
                    Category = "fragrances",
                    Price = 49.99m,
                    DiscountPercentage = 1.89m,
                    Rating = 4.37,
                    Stock = 29,
                    Tags = new List<string> { "fragrances", "perfumes" },
                    Brand = "Calvin Klein",
                    Sku = "FRA-CAL-CAL-006",
                    Weight = 7,
                    WarrantyInformation = "1 week warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "90 days return policy",
                    MinimumOrderQuantity = 9,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/fragrances/calvin-klein-ck-one/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/fragrances/calvin-klein-ck-one/1.webp", "https://cdn.dummyjson.com/product-images/fragrances/calvin-klein-ck-one/2.webp", "https://cdn.dummyjson.com/product-images/fragrances/calvin-klein-ck-one/3.webp" }
                },
                new Product
                {

                    Title = "Chanel Coco Noir Eau De",
                    Description = "Coco Noir by Chanel is an elegant and mysterious fragrance, featuring notes of grapefruit, rose, and sandalwood. Perfect for evening occasions.",
                    Category = "fragrances",
                    Price = 129.99m,
                    DiscountPercentage = 16.51m,
                    Rating = 4.26,
                    Stock = 58,
                    Tags = new List<string> { "fragrances", "perfumes" },
                    Brand = "Chanel",
                    Sku = "FRA-CHA-CHA-007",
                    Weight = 7,
                    WarrantyInformation = "3 year warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 1,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/fragrances/chanel-coco-noir-eau-de/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/fragrances/chanel-coco-noir-eau-de/1.webp", "https://cdn.dummyjson.com/product-images/fragrances/chanel-coco-noir-eau-de/2.webp", "https://cdn.dummyjson.com/product-images/fragrances/chanel-coco-noir-eau-de/3.webp" }
                },
                new Product
                {

                    Title = "Dior J'adore",
                    Description = "J'adore by Dior is a luxurious and floral fragrance, known for its blend of ylang-ylang, rose, and jasmine. It embodies femininity and sophistication.",
                    Category = "fragrances",
                    Price = 89.99m,
                    DiscountPercentage = 14.72m,
                    Rating = 3.8,
                    Stock = 98,
                    Tags = new List<string> { "fragrances", "perfumes" },
                    Brand = "Dior",
                    Sku = "FRA-DIO-DIO-008",
                    Weight = 4,
                    WarrantyInformation = "1 week warranty",
                    ShippingInformation = "Ships in 2 weeks",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 10,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/fragrances/dior-j'adore/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/fragrances/dior-j'adore/1.webp", "https://cdn.dummyjson.com/product-images/fragrances/dior-j'adore/2.webp", "https://cdn.dummyjson.com/product-images/fragrances/dior-j'adore/3.webp" }
                },
                new Product
                {

                    Title = "Dolce Shine Eau de",
                    Description = "Dolce Shine by Dolce & Gabbana is a vibrant and fruity fragrance, featuring notes of mango, jasmine, and blonde woods. It's a joyful and youthful scent.",
                    Category = "fragrances",
                    Price = 69.99m,
                    DiscountPercentage = 0.62m,
                    Rating = 3.96,
                    Stock = 4,
                    Tags = new List<string> { "fragrances", "perfumes" },
                    Brand = "Dolce & Gabbana",
                    Sku = "FRA-DOL-DOL-009",
                    Weight = 6,
                    WarrantyInformation = "3 year warranty",
                    ShippingInformation = "Ships in 1 month",
                    AvailabilityInformation = "Low Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 2,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/fragrances/dolce-shine-eau-de/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/fragrances/dolce-shine-eau-de/1.webp", "https://cdn.dummyjson.com/product-images/fragrances/dolce-shine-eau-de/2.webp", "https://cdn.dummyjson.com/product-images/fragrances/dolce-shine-eau-de/3.webp" }
                },
                new Product
                {

                    Title = "Gucci Bloom Eau de",
                    Description = "Gucci Bloom by Gucci is a floral and captivating fragrance, with notes of tuberose, jasmine, and Rangoon creeper. It's a modern and romantic scent.",
                    Category = "fragrances",
                    Price = 79.99m,
                    DiscountPercentage = 14.39m,
                    Rating = 2.74,
                    Stock = 91,
                    Tags = new List<string> { "fragrances", "perfumes" },
                    Brand = "Gucci",
                    Sku = "FRA-GUC-GUC-010",
                    Weight = 7,
                    WarrantyInformation = "6 months warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 2,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/fragrances/gucci-bloom-eau-de/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/fragrances/gucci-bloom-eau-de/1.webp", "https://cdn.dummyjson.com/product-images/fragrances/gucci-bloom-eau-de/2.webp", "https://cdn.dummyjson.com/product-images/fragrances/gucci-bloom-eau-de/3.webp" }
                },
                new Product
                {

                    Title = "Annibale Colombo Bed",
                    Description = "The Annibale Colombo Bed is a luxurious and elegant bed frame, crafted with high-quality materials for a comfortable and stylish bedroom.",
                    Category = "furniture",
                    Price = 1899.99m,
                    DiscountPercentage = 8.57m,
                    Rating = 4.77,
                    Stock = 88,
                    Tags = new List<string> { "furniture", "beds" },
                    Brand = "Annibale Colombo",
                    Sku = "FUR-ANN-ANN-011",
                    Weight = 10,
                    WarrantyInformation = "1 year warranty",
                    ShippingInformation = "Ships in 1 month",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 1,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-bed/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-bed/1.webp", "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-bed/2.webp", "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-bed/3.webp" }
                },
                new Product
                {

                    Title = "Annibale Colombo Sofa",
                    Description = "The Annibale Colombo Sofa is a sophisticated and comfortable seating option, featuring exquisite design and premium upholstery for your living room.",
                    Category = "furniture",
                    Price = 2499.99m,
                    DiscountPercentage = 14.4m,
                    Rating = 3.92,
                    Stock = 60,
                    Tags = new List<string> { "furniture", "sofas" },
                    Brand = "Annibale Colombo",
                    Sku = "FUR-ANN-ANN-012",
                    Weight = 6,
                    WarrantyInformation = "Lifetime warranty",
                    ShippingInformation = "Ships in 1 week",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 1,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-sofa/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-sofa/1.webp", "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-sofa/2.webp", "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-sofa/3.webp" }
                },
                new Product
                {

                    Title = "Bedside Table African Cherry",
                    Description = "The Bedside Table in African Cherry is a stylish and functional addition to your bedroom, providing convenient storage space and a touch of elegance.",
                    Category = "furniture",
                    Price = 299.99m,
                    DiscountPercentage = 19.09m,
                    Rating = 2.87,
                    Stock = 64,
                    Tags = new List<string> { "furniture", "bedside tables" },
                    Brand = "Furniture Co.",
                    Sku = "FUR-FUR-BED-013",
                    Weight = 2,
                    WarrantyInformation = "5 year warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 3,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/furniture/bedside-table-african-cherry/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/furniture/bedside-table-african-cherry/1.webp", "https://cdn.dummyjson.com/product-images/furniture/bedside-table-african-cherry/2.webp", "https://cdn.dummyjson.com/product-images/furniture/bedside-table-african-cherry/3.webp" }
                },
                new Product
                {

                    Title = "Knoll Saarinen Executive Conference Chair",
                    Description = "The Knoll Saarinen Executive Conference Chair is a modern and ergonomic chair, perfect for your office or conference room with its timeless design.",
                    Category = "furniture",
                    Price = 499.99m,
                    DiscountPercentage = 2.01m,
                    Rating = 4.88,
                    Stock = 26,
                    Tags = new List<string> { "furniture", "office chairs" },
                    Brand = "Knoll",
                    Sku = "FUR-KNO-KNO-014",
                    Weight = 10,
                    WarrantyInformation = "2 year warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "60 days return policy",
                    MinimumOrderQuantity = 5,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/furniture/knoll-saarinen-executive-conference-chair/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/furniture/knoll-saarinen-executive-conference-chair/1.webp", "https://cdn.dummyjson.com/product-images/furniture/knoll-saarinen-executive-conference-chair/2.webp", "https://cdn.dummyjson.com/product-images/furniture/knoll-saarinen-executive-conference-chair/3.webp" }
                },
                new Product
                {

                    Title = "Wooden Bathroom Sink With Mirror",
                    Description = "The Wooden Bathroom Sink with Mirror is a unique and stylish addition to your bathroom, featuring a wooden sink countertop and a matching mirror.",
                    Category = "furniture",
                    Price = 799.99m,
                    DiscountPercentage = 8.8m,
                    Rating = 3.59,
                    Stock = 7,
                    Tags = new List<string> { "furniture", "bathroom" },
                    Brand = "Bath Trends",
                    Sku = "FUR-BAT-WOO-015",
                    Weight = 10,
                    WarrantyInformation = "3 year warranty",
                    ShippingInformation = "Ships in 3-5 business days",
                    AvailabilityInformation = "Low Stock",
                    ReturnPolicy = "60 days return policy",
                    MinimumOrderQuantity = 2,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/furniture/wooden-bathroom-sink-with-mirror/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/furniture/wooden-bathroom-sink-with-mirror/1.webp", "https://cdn.dummyjson.com/product-images/furniture/wooden-bathroom-sink-with-mirror/2.webp", "https://cdn.dummyjson.com/product-images/furniture/wooden-bathroom-sink-with-mirror/3.webp" }
                },
                new Product
                {

                    Title = "Apple",
                    Description = "Fresh and crisp apples, perfect for snacking or incorporating into various recipes.",
                    Category = "groceries",
                    Price = 1.99m,
                    DiscountPercentage = 12.62m,
                    Rating = 4.19,
                    Stock = 8,
                    Tags = new List<string> { "fruits" },
                    Brand = "",
                    Sku = "GRO-BRD-APP-016",
                    Weight = 9,
                    WarrantyInformation = "3 year warranty",
                    ShippingInformation = "Ships in 2 weeks",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "90 days return policy",
                    MinimumOrderQuantity = 7,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/apple/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/apple/1.webp" }
                },
                new Product
                {

                    Title = "Beef Steak",
                    Description = "High-quality beef steak, great for grilling or cooking to your preferred level of doneness.",
                    Category = "groceries",
                    Price = 12.99m,
                    DiscountPercentage = 9.61m,
                    Rating = 4.47,
                    Stock = 86,
                    Tags = new List<string> { "meat" },
                    Brand = "",
                    Sku = "GRO-BRD-BEE-017",
                    Weight = 10,
                    WarrantyInformation = "3 year warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "60 days return policy",
                    MinimumOrderQuantity = 43,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/beef-steak/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/beef-steak/1.webp" }
                },
                new Product
                {

                    Title = "Cat Food",
                    Description = "Nutritious cat food formulated to meet the dietary needs of your feline friend.",
                    Category = "groceries",
                    Price = 8.99m,
                    DiscountPercentage = 9.58m,
                    Rating = 3.13,
                    Stock = 46,
                    Tags = new List<string> { "pet supplies", "cat food" },
                    Brand = "",
                    Sku = "GRO-BRD-FOO-018",
                    Weight = 10,
                    WarrantyInformation = "1 year warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 18,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/cat-food/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/cat-food/1.webp" }
                },
                new Product
                {

                    Title = "Chicken Meat",
                    Description = "Fresh and tender chicken meat, suitable for various culinary preparations.",
                    Category = "groceries",
                    Price = 9.99m,
                    DiscountPercentage = 13.7m,
                    Rating = 3.19,
                    Stock = 97,
                    Tags = new List<string> { "meat" },
                    Brand = "",
                    Sku = "GRO-BRD-CHI-019",
                    Weight = 1,
                    WarrantyInformation = "1 year warranty",
                    ShippingInformation = "Ships in 1 month",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 22,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/chicken-meat/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/chicken-meat/1.webp", "https://cdn.dummyjson.com/product-images/groceries/chicken-meat/2.webp" }
                },
                new Product
                {

                    Title = "Cooking Oil",
                    Description = "Versatile cooking oil suitable for frying, sautéing, and various culinary applications.",
                    Category = "groceries",
                    Price = 4.99m,
                    DiscountPercentage = 9.33m,
                    Rating = 4.8,
                    Stock = 10,
                    Tags = new List<string> { "cooking essentials" },
                    Brand = "",
                    Sku = "GRO-BRD-COO-020",
                    Weight = 5,
                    WarrantyInformation = "Lifetime warranty",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "30 days return policy",
                    MinimumOrderQuantity = 46,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/cooking-oil/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/cooking-oil/1.webp" }
                },
                new Product
                {

                    Title = "Cucumber",
                    Description = "Crisp and hydrating cucumbers, ideal for salads, snacks, or as a refreshing side.",
                    Category = "groceries",
                    Price = 1.49m,
                    DiscountPercentage = 0.16m,
                    Rating = 4.07,
                    Stock = 84,
                    Tags = new List<string> { "vegetables" },
                    Brand = "",
                    Sku = "GRO-BRD-CUC-021",
                    Weight = 4,
                    WarrantyInformation = "2 year warranty",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 2,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/cucumber/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/cucumber/1.webp" }
                },
                new Product
                {

                    Title = "Dog Food",
                    Description = "Specially formulated dog food designed to provide essential nutrients for your canine companion.",
                    Category = "groceries",
                    Price = 10.99m,
                    DiscountPercentage = 10.27m,
                    Rating = 4.55,
                    Stock = 71,
                    Tags = new List<string> { "pet supplies", "dog food" },
                    Brand = "",
                    Sku = "GRO-BRD-FOO-022",
                    Weight = 10,
                    WarrantyInformation = "No warranty",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "60 days return policy",
                    MinimumOrderQuantity = 43,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/dog-food/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/dog-food/1.webp" }
                },
                new Product
                {

                    Title = "Eggs",
                    Description = "Fresh eggs, a versatile ingredient for baking, cooking, or breakfast.",
                    Category = "groceries",
                    Price = 2.99m,
                    DiscountPercentage = 11.05m,
                    Rating = 2.53,
                    Stock = 9,
                    Tags = new List<string> { "dairy" },
                    Brand = "",
                    Sku = "GRO-BRD-EGG-023",
                    Weight = 2,
                    WarrantyInformation = "1 week warranty",
                    ShippingInformation = "Ships in 1 week",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 32,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/eggs/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/eggs/1.webp" }
                },
                new Product
                {

                    Title = "Fish Steak",
                    Description = "Quality fish steak, suitable for grilling, baking, or pan-searing.",
                    Category = "groceries",
                    Price = 14.99m,
                    DiscountPercentage = 4.23m,
                    Rating = 3.78,
                    Stock = 74,
                    Tags = new List<string> { "seafood" },
                    Brand = "",
                    Sku = "GRO-BRD-FIS-024",
                    Weight = 6,
                    WarrantyInformation = "1 month warranty",
                    ShippingInformation = "Ships in 3-5 business days",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "60 days return policy",
                    MinimumOrderQuantity = 50,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/fish-steak/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/fish-steak/1.webp" }
                },
                new Product
                {

                    Title = "Green Bell Pepper",
                    Description = "Fresh and vibrant green bell pepper, perfect for adding color and flavor to your dishes.",
                    Category = "groceries",
                    Price = 1.29m,
                    DiscountPercentage = 0.16m,
                    Rating = 3.25,
                    Stock = 33,
                    Tags = new List<string> { "vegetables" },
                    Brand = "",
                    Sku = "GRO-BRD-GRE-025",
                    Weight = 2,
                    WarrantyInformation = "1 month warranty",
                    ShippingInformation = "Ships in 1 week",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "30 days return policy",
                    MinimumOrderQuantity = 12,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/green-bell-pepper/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/green-bell-pepper/1.webp" }
                },
                new Product
                {

                    Title = "Green Chili Pepper",
                    Description = "Spicy green chili pepper, ideal for adding heat to your favorite recipes.",
                    Category = "groceries",
                    Price = 0.99m,
                    DiscountPercentage = 1m,
                    Rating = 3.66,
                    Stock = 3,
                    Tags = new List<string> { "vegetables" },
                    Brand = "",
                    Sku = "GRO-BRD-GRE-026",
                    Weight = 7,
                    WarrantyInformation = "2 year warranty",
                    ShippingInformation = "Ships in 1 week",
                    AvailabilityInformation = "Low Stock",
                    ReturnPolicy = "30 days return policy",
                    MinimumOrderQuantity = 39,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/green-chili-pepper/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/green-chili-pepper/1.webp" }
                },
                new Product
                {

                    Title = "Honey Jar",
                    Description = "Pure and natural honey in a convenient jar, perfect for sweetening beverages or drizzling over food.",
                    Category = "groceries",
                    Price = 6.99m,
                    DiscountPercentage = 14.4m,
                    Rating = 3.97,
                    Stock = 34,
                    Tags = new List<string> { "condiments" },
                    Brand = "",
                    Sku = "GRO-BRD-HON-027",
                    Weight = 2,
                    WarrantyInformation = "1 month warranty",
                    ShippingInformation = "Ships in 1-2 business days",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "90 days return policy",
                    MinimumOrderQuantity = 47,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/honey-jar/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/honey-jar/1.webp" }
                },
                new Product
                {

                    Title = "Ice Cream",
                    Description = "Creamy and delicious ice cream, available in various flavors for a delightful treat.",
                    Category = "groceries",
                    Price = 5.49m,
                    DiscountPercentage = 8.69m,
                    Rating = 3.39,
                    Stock = 27,
                    Tags = new List<string> { "desserts" },
                    Brand = "",
                    Sku = "GRO-BRD-CRE-028",
                    Weight = 1,
                    WarrantyInformation = "1 month warranty",
                    ShippingInformation = "Ships in 2 weeks",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 42,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/ice-cream/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/ice-cream/1.webp", "https://cdn.dummyjson.com/product-images/groceries/ice-cream/2.webp", "https://cdn.dummyjson.com/product-images/groceries/ice-cream/3.webp", "https://cdn.dummyjson.com/product-images/groceries/ice-cream/4.webp" }
                },
                new Product
                {

                    Title = "Juice",
                    Description = "Refreshing fruit juice, packed with vitamins and great for staying hydrated.",
                    Category = "groceries",
                    Price = 3.99m,
                    DiscountPercentage = 12.06m,
                    Rating = 3.94,
                    Stock = 50,
                    Tags = new List<string> { "beverages" },
                    Brand = "",
                    Sku = "GRO-BRD-JUI-029",
                    Weight = 1,
                    WarrantyInformation = "6 months warranty",
                    ShippingInformation = "Ships in 1 week",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "No return policy",
                    MinimumOrderQuantity = 25,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/juice/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/juice/1.webp" }
                },
                new Product
                {

                    Title = "Kiwi",
                    Description = "Nutrient-rich kiwi, perfect for snacking or adding a tropical twist to your dishes.",
                    Category = "groceries",
                    Price = 2.49m,
                    DiscountPercentage = 15.22m,
                    Rating = 4.93,
                    Stock = 99,
                    Tags = new List<string> { "fruits" },
                    Brand = "",
                    Sku = "GRO-BRD-KIW-030",
                    Weight = 5,
                    WarrantyInformation = "6 months warranty",
                    ShippingInformation = "Ships overnight",
                    AvailabilityInformation = "In Stock",
                    ReturnPolicy = "7 days return policy",
                    MinimumOrderQuantity = 30,
                    Thumbnail = "https://cdn.dummyjson.com/product-images/groceries/kiwi/thumbnail.webp",
                    Images = new List<string> { "https://cdn.dummyjson.com/product-images/groceries/kiwi/1.webp" }
                },
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
