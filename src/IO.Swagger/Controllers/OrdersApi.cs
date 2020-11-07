/*
 * Just Order Api
 *
 * An API to create and retrieve Food items and orders.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: john.doe@somecomp.com
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
    public class OrdersApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Create an order with a list of Line Items</remarks>
        /// <param name="body"></param>
        /// <response code="201">The Order will be Returned with the generated UUID and all the billing details.</response>
        /// <response code="400">The Submitted Request is Malformed.</response>
        [HttpPost]
        [Route("/VinodhThiagarajan1309/just-orders-api/1.0.0/order")]
        [ValidateModelState]
        [SwaggerOperation("CreateV1Order")]
        [SwaggerResponse(statusCode: 201, type: typeof(Order), description: "The Order will be Returned with the generated UUID and all the billing details.")]
        [SwaggerResponse(statusCode: 400, type: typeof(BadRequestMadeModel), description: "The Submitted Request is Malformed.")]
        public virtual IActionResult CreateV1Order([FromBody]List<LineItem> body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(Order));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(BadRequestMadeModel));
            string exampleJson = null;
            exampleJson = "{\n  \"lineItems\" : [ {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  }, {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  } ],\n  \"total\" : 13.53,\n  \"orderId\" : \"02e4d444-1997-49e7-b287-a496c41d73d6\",\n  \"salesTax\" : 0.65,\n  \"orderSubTotal\" : 12.88\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Order>(exampleJson)
                        : default(Order);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get 1 order based on a UUID</remarks>
        /// <param name="orderId">The UUID of the Order that needs to be retreived.</param>
        /// <response code="200">A successful retrieval of the Order</response>
        /// <response code="400">The Submitted Request is Malformed.</response>
        [HttpGet]
        [Route("/VinodhThiagarajan1309/just-orders-api/1.0.0/order/{orderId}")]
        [ValidateModelState]
        [SwaggerOperation("GetV1Order")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "A successful retrieval of the Order")]
        [SwaggerResponse(statusCode: 400, type: typeof(BadRequestMadeModel), description: "The Submitted Request is Malformed.")]
        public virtual IActionResult GetV1Order([FromRoute][Required]string orderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Order));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(BadRequestMadeModel));
            string exampleJson = null;
            exampleJson = "{\n  \"lineItems\" : [ {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  }, {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  } ],\n  \"total\" : 13.53,\n  \"orderId\" : \"02e4d444-1997-49e7-b287-a496c41d73d6\",\n  \"salesTax\" : 0.65,\n  \"orderSubTotal\" : 12.88\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Order>(exampleJson)
                        : default(Order);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get the List of order from the system.</remarks>
        /// <param name="limit"></param>
        /// <response code="200">The list of recently added orders  will be returned.</response>
        /// <response code="400">The Submitted Request is Malformed.</response>
        [HttpGet]
        [Route("/VinodhThiagarajan1309/just-orders-api/1.0.0/order")]
        [ValidateModelState]
        [SwaggerOperation("GetV1OrderList")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Order>), description: "The list of recently added orders  will be returned.")]
        [SwaggerResponse(statusCode: 400, type: typeof(BadRequestMadeModel), description: "The Submitted Request is Malformed.")]
        public virtual IActionResult GetV1OrderList([FromQuery][Required()]decimal? limit)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Order>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(BadRequestMadeModel));
            string exampleJson = null;
            exampleJson = "[ {\n  \"lineItems\" : [ {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  }, {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  } ],\n  \"total\" : 13.53,\n  \"orderId\" : \"02e4d444-1997-49e7-b287-a496c41d73d6\",\n  \"salesTax\" : 0.65,\n  \"orderSubTotal\" : 12.88\n}, {\n  \"lineItems\" : [ {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  }, {\n    \"itemId\" : \"a72419bc-0991-456b-90e2-af648bfeb37c\",\n    \"quantity\" : 4,\n    \"itemPrice\" : 2.99\n  } ],\n  \"total\" : 13.53,\n  \"orderId\" : \"02e4d444-1997-49e7-b287-a496c41d73d6\",\n  \"salesTax\" : 0.65,\n  \"orderSubTotal\" : 12.88\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Order>>(exampleJson)
                        : default(List<Order>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
