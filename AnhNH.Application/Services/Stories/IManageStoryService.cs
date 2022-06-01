using AnhNH.Application.ViewModels;
using AnhNH.Application.ViewModels.Stories.Manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Application.Services.Stories
{
    public interface IManageStoryService
    {
        Task<int> Create(StoryCreateRequest request);
        Task<int> Update(StoryUpdateRequest request);
        Task<int> Delete(int storyId);
        Task<List<StoryViewModel>> GetAll();
        Task<PagedResult<StoryViewModel>> GetAllPaging(GetStoryPagingRequest request);
    }
}
