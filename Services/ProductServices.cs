using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApi.Data;
using WebShopApi.Models;
using WebShopApi.Models.ServiceModels;

namespace WebShopApi.Services
{
    public class ProductServices : IProductServices
    {

        private readonly SqlDbContext _context;

        public ProductServices(SqlDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateBasicAsync(CreateBasicModel createBasicModel)
        {

            try
            {

                if (createBasicModel.Destination == "Brand")
                {
                    if (! _context.Brands.Any(brand => brand.BrandName == createBasicModel.Name))
                    {
                        try
                        {
                            var brand = new Brand()
                            {
                                BrandName = createBasicModel.Name
                            };

                            _context.Brands.Add(brand);
                            await _context.SaveChangesAsync();
                            return true;
                        }
                        catch 
                        {

                            
                        }
                    }
                }
                if (createBasicModel.Destination == "Category")
                {
                    if (!_context.Categories.Any(categories => categories.CategorieName == createBasicModel.Name))
                    {
                        try
                        {
                            var categories = new Category()
                            {
                                CategorieName = createBasicModel.Name
                            };

                            _context.Categories.Add(categories);
                            await _context.SaveChangesAsync();
                            return true;
                        }
                        catch
                        {


                        }
                    }
                }
                if (createBasicModel.Destination == "Size")
                {
                    if (!_context.Sizes.Any(size => size.SizeName == createBasicModel.Name))
                    {
                        try
                        {
                            var size = new Size()
                            {
                                SizeName = createBasicModel.Name
                            };

                            _context.Sizes.Add(size);
                            await _context.SaveChangesAsync();
                            return true;
                        }
                        catch
                        {


                        }
                    }
                }
                if (createBasicModel.Destination == "Tag")
                {
                    if (!_context.Tags.Any(tag => tag.TagName == createBasicModel.Name))
                    {
                        try
                        {
                            var tag = new Tag()
                            {
                                TagName = createBasicModel.Name
                            };

                            _context.Tags.Add(tag);
                            await _context.SaveChangesAsync();
                            return true;
                        }
                        catch
                        {


                        }
                    }
                }
               
            }
            catch 
            {
                

            }
            return false;
        }

        public async Task<bool> CreateColorAsync(CreateColorModel createColorModel)
        {
            if (!_context.Colors.Any(color => color.ColorName == createColorModel.ColorName))
            {
                try
                {
                    var color = new Color()
                    {
                        ColorName = createColorModel.ColorName,
                        ColorHex = createColorModel.ColorHex
                    };

                    _context.Colors.Add(color);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch
                {


                }
            }
            return false;
        }
    }
}
