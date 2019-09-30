using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Api.Business.Abstract;
using Core.Api.Entities.Concrete;
using Core.Api.Entities.ContextTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Api.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        IArticleService _articleService;
        IMapper _mapper;

        public ArticlesController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
    }

        // GET api/articles
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var articles = _articleService.GetAllDetail();
                var articleToReturn = _mapper.Map<List<ArticleModelDTO>>(articles);

                if (articleToReturn == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(articleToReturn);
                }

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET api/articles/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var article = _articleService.GetDetail(id);
                var articleToReturn = _mapper.Map<ArticleModelDTO>(article);

                if (articleToReturn == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(articleToReturn);
                }

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET api/articles/search/test
        [HttpGet("search/{key}")]
        public IActionResult Search(string key)
        {
            try
            {
                var articles = _articleService.GetAllDetail().Where(x=>x.ArticleName.ToLower() ==  key.ToLower());
                var articleToReturn = _mapper.Map<List<ArticleModelDTO>>(articles);

                if (articleToReturn == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(articleToReturn);
                }

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // POST api/articles
        [HttpPost]
        public IActionResult Post(Article article)
        {
            try
            {
                _articleService.Add(article);
                return new StatusCodeResult(201);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT api/articles/5
        [HttpPut]
        public IActionResult Put(Article article)
        {
            try
            {
                _articleService.Update(article);
                return Ok(article);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // DELETE api/articles/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _articleService.Delete(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    
    }
}