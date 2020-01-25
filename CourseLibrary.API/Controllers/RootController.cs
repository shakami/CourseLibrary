﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseLibrary.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = "GetRoot")]
        public IActionResult GetRoot()
        {
            var links = new List<LinkDto>
            {
                new LinkDto(Url.Link("GetRoot", new { }),
                                "self",
                                "GET"),

                new LinkDto(Url.Link("GetAuthors", new { }),
                                "authors",
                                "GET"),

                new LinkDto(Url.Link("CreateAuthor", new { }),
                                "create_author",
                                "POST")
            };

            return Ok(links);
        }
    }
}