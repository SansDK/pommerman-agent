/*
 * Bombersauce API
 *
 * API for an agent of the Bombersauce AI-hackathon.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body">Game state</param>
        /// <response code="200">The action to take</response>
        [HttpPost]
        [Route("/act")]
        [ValidateModelState]
        [SwaggerOperation("ActPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ActResponse), description: "The action to take")]
        public virtual IActionResult ActPost([FromBody]ActRequest body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ActResponse));

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ActResponse>(exampleJson)
            : default(ActResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body">Episode end body</param>
        /// <response code="200">Ok</response>
        [HttpPost]
        [Route("/episode_end")]
        [ValidateModelState]
        [SwaggerOperation("EpisodeEndPost")]
        public virtual IActionResult EpisodeEndPost([FromBody]EpisodeEndRequest body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body">Initialize body</param>
        /// <response code="200">Ok</response>
        [HttpPost]
        [Route("/init_agent")]
        [ValidateModelState]
        [SwaggerOperation("InitAgentPost")]
        public virtual IActionResult InitAgentPost([FromBody]InitAgentRequest body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <response code="200">Ok</response>
        [HttpGet]
        [Route("/ping")]
        [ValidateModelState]
        [SwaggerOperation("PingGet")]
        public virtual IActionResult PingGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body">Shutdown body</param>
        /// <response code="200">Ok</response>
        [HttpPost]
        [Route("/shutdown")]
        [ValidateModelState]
        [SwaggerOperation("ShutdownPost")]
        public virtual IActionResult ShutdownPost([FromBody]Object body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }
    }
}
