using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Api.Business.Abstract;
using Core.Api.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Api.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET api/articles
        [HttpGet]
        public IActionResult Get()
        {
            var articles = _articleService.GetAll();
            return Ok(articles);
        }

        // GET api/articles/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var article = _articleService.Get(id);
            return Ok(article);
        }

        // POST api/articles
        [HttpPost]
        public IActionResult Post(Article article)
        {
             _articleService.Add(article);
            return new StatusCodeResult(201);
        }

        // PUT api/articles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/articles/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}