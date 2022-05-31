using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnhNH.Application.ViewModels.Stories.Manages
{
    public class GetStoryPagingRequest:PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
