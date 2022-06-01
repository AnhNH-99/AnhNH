using AnhNH.Application.ViewModels;
using AnhNH.Application.ViewModels.Stories.Manages;
using AnhNH.Data.EF;
using AnhNH.Data.Entities;
using AnhNH.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Application.Services.Stories
{
    public class ManageStoryService : IManageStoryService
    {
        private readonly AnhNHDbContext _context;
        public ManageStoryService(AnhNHDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(StoryCreateRequest request)
        {
            var story = new Story()
            {
                Name = request.Name,
                Title = request.Title,
                Description = request.Description,
                Status = request.Status,
                Author = request.Author
            };
            _context.Stories.Add(story);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int storyId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StoryViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<StoryViewModel>> GetAllPaging(GetStoryPagingRequest request)
        {
            var query = _context.Stories.Select(x => new StoryViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Title = x.Title,
                Description = x.Description,
                Author = x.Author,
                Status = x.Status,
                Views = x.Views,
                Likes = x.Likes,
                Follows = x.Follows,
                CreatedAt = x.CreatedAt,
                CreatedBy = x.CreatedBy,
                UpdatedAt = x.UpdatedAt,
                UpdatedBy = x.UpdatedBy
            });

            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.Name.Contains(request.Keyword));

            int totalRow = await query.CountAsync();

            var data = query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize);

            var pagedResult = new PagedResult<StoryViewModel>()
            {
                TotalRecord = totalRow,
                Items = await query.ToListAsync()
            };
            return pagedResult;
    }

        public async Task<int> Update(StoryUpdateRequest request)
        {
            var story = await _context.Stories.FindAsync(request.Id);
            if (story == null) throw new AnhNHException($"Cannot find a story: {request.Id}");
            story.Name = request.Name;
            story.Title = request.Title;
            story.Description = request.Description;
            story.Author = request.Author;
            return await _context.SaveChangesAsync();
        }
    }
}
