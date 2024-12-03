﻿using Store1.Data.Dtos;
using Store1.Data.Entities;

namespace Store1.Data.Services
{
    public interface ICategoryService
    {
        int Add(Category category);
        int Update(Category category);
        int Remove(Category category);
        Category? FindOne(int? Id);
        List<CategoryDto> LoadCategories();
    }
    public class CategoryService:ICategoryService
    {
        private readonly ApplicationDbContext _db;

        public CategoryService(ApplicationDbContext db)
        {
            this._db = db;
        }

        public List<CategoryDto> LoadCategories()
        {
            return _db.Categories!.Where(m => !(m.IsDeleted ?? false))
                .Select(s => new CategoryDto
                {
                    Id = s.Id,
                    ImagePath = s.ImagePath,
                    IsActive = s.IsActive,
                    NameAr = s.NameAr,
                    OrderIndex = s.OrderIndex,

                })
                .ToList();
        }
        public Category? FindOne(int?Id)
        {
            return _db.Categories!.Take(1).SingleOrDefault();
        }
        public int Add(Category category )
        {
            _db.Categories!.Add(category);
            return _db.SaveChanges();
        }
        public int Update(Category category)
        {
            _db.Categories!.Update(category);
            return _db.SaveChanges();
        }

        public int Remove(Category category)
        {
            _db.Categories!.Remove(category);
            return _db.SaveChanges();
        }

    }
}
