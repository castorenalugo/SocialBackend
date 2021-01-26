using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Backend.Domain.DTOs;
using Backend.Domain.Entities;
using Backend.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postRepository.GetPosts();
            var postsDto = _mapper.Map<IEnumerable<PostDto>>(posts);
            return Ok(postsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await _postRepository.GetPost(id);
            var postDto = _mapper.Map<PostDto>(post);
            return Ok(postDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostDto post)
        {
            await _postRepository.InsertPost(_mapper.Map<Post>(post));
            return Ok(post);
        }
    }
}
