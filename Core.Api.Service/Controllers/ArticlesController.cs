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
            try
            {
                var articles = _articleService.GetAll();
                return Ok(articles);
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
                var article = _articleService.Get(id);
                return Ok(article);
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

        // GET api/GetAllDetail
        [HttpGet("GetAllDetail")]
        public IActionResult GetAllDetail()
        {
            try
            {
                var article = _articleService.GetAllDetail();

                if (article == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(article);
                }

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET api/GetDetail/1
        [HttpGet("GetDetail/{id}")]
        public IActionResult GetDetail(int id)
        {
            try
            {
                var article = _articleService.GetDetail(id);

                if (article == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(article);
                }

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}