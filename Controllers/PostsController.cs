using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fans.Data;
using Fans.Models;

namespace Fans.Controllers
{
    public class PostsController : Controller
    {
        private readonly PostsContext _context;

        public PostsController(PostsContext context)
        {
            _context = context;
        }

    }
}