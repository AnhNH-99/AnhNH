using AnhNH.Application.ViewModels;
using AnhNH.Application.ViewModels.Stories.Manages;
using AnhNH.Data.EF;
using AnhNH.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Application.Services.Stories
{
    public class ManageProductService : IManageProductService
    {
        private readonly AnhNHDbContext _context;
        public ManageProductService(AnhNHDbContext context)
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

        public async Task<PagedResult<StoryViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(StoryUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
